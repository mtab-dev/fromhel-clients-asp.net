using FromhelClients.API.Abstractions;
using FromhelClients.API.Entities;

namespace FromhelClients.API.Services
{
    public class ClientService
    {
        private IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<ClientEntity>> GetClients()
        {
            return await _clientRepository.GetClients();
        }

        public async Task<ClientEntity> GetClient(string id)
        {
            return await _clientRepository.GetClient(id);
        }

    }
}
