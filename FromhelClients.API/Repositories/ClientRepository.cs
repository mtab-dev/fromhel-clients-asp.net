using FromhelClients.API.Abstractions;
using FromhelClients.API.Entities;
using FromhelClients.API.Infra;
using MongoDB.Driver;

namespace FromhelClients.API.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IMongoCollection<ClientEntity> _clientCollection;

        public ClientRepository(MongoDbService mongoDbService)
        {
            _clientCollection = mongoDbService.Database.GetCollection<ClientEntity>("clients");
        }

        public async Task<ClientEntity> CreateClient(ClientEntity client)
        {
            await _clientCollection.InsertOneAsync(client);

            return client;
        }

        public Task<ClientEntity> DeleteClient(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> GetClient(string id)
        {
            return _clientCollection.Find(client => client.ClientId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ClientEntity>> GetClients()
        {
            return await _clientCollection.Find(client => true).ToListAsync();
        }

        public Task<ClientEntity> UpdateClient(string id, ClientEntity client)
        {
            throw new NotImplementedException();
        }
    }
}
