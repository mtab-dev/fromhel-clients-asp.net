using FromhelClients.API.Abstractions;
using FromhelClients.API.DTO;
using FromhelClients.API.Entities;

namespace FromhelClients.API.Services
{
    public class ClientService : IClientService
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

        public async Task<ClientEntity> CreateClient(CreateClientDTO clientDto)
        {
            var client = new ClientEntity(clientDto.Name, clientDto.Email);

            var insertedClient = await _clientRepository.CreateClient(client);

            return insertedClient;
        }

        public Task<ClientEntity> UpdateClient(string id, ClientEntity client)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> DeleteClient(string id)
        {
            throw new NotImplementedException();
        }
    }
}
