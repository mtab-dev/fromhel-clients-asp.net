using FromhelClients.API.Abstractions;
using FromhelClients.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FromhelClients.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private IClientRepository _clientRepository;
        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet("getClients")]
        public async Task<IEnumerable<ClientEntity>> Get()
        {   
            return await _clientRepository.GetClients();
        }

        [HttpGet("getClient/{id}")]
        public async Task<ClientEntity> Get(string id)
        {
            return await _clientRepository.GetClient(id);
        }

    }
}
