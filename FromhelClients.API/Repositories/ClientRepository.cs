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
            return _clientCollection.FindOneAndDeleteAsync(client => client.ClientId == id);
        }

        public Task<ClientEntity> GetClient(string id)
        {
            return _clientCollection.Find(client => client.ClientId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ClientEntity>> GetClients()
        {
            return await _clientCollection.Find(client => true).ToListAsync();
        }

        public async Task<ClientEntity> UpdateClient(string id, ClientEntity client)
        {
            var filter = Builders<ClientEntity>.Filter.Eq(c => c.ClientId, id);
            var update = Builders<ClientEntity>.Update
                .Set(c => c.Name, client.Name)
                .Set(c => c.Email, client.Email);

            return await _clientCollection.FindOneAndUpdateAsync(filter, update);
        }

    }
}
