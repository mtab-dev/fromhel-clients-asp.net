using FromhelClients.API.DTO;
using FromhelClients.API.Entities;

namespace FromhelClients.API.Abstractions
{
    public interface IClientService
    {
        public Task<IEnumerable<ClientEntity>> GetClients();
        public Task<ClientEntity> GetClient(string id);
        public Task<ClientEntity> CreateClient(CreateClientDTO client);
        public Task<ClientEntity> UpdateClient(string id, CreateClientDTO client);
        public Task<ClientEntity> DeleteClient(string id);
    }
}
