using FromhelClients.API.Abstractions;
using FromhelClients.API.Entities;

namespace FromhelClients.API.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<ClientEntity> CreateClient(ClientEntity client)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> DeleteClient(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> GetClient(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientEntity>> GetClients()
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> UpdateClient(string id, ClientEntity client)
        {
            throw new NotImplementedException();
        }
    }
}
