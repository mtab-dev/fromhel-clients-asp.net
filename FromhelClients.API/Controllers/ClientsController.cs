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


        // GET: api/<ClientsController>
        [HttpGet("getClients")]
        public async Task<IEnumerable<ClientEntity>> Get()
        {   
            return await _clientRepository.GetClients();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientsController>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
