﻿using FromhelClients.API.Abstractions;
using FromhelClients.API.DTO;
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
        private IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("getClients")]
        public async Task<IEnumerable<ClientEntity>> Get()
        {
            return await _clientService.GetClients();
        }

        [HttpGet("getClient/{id}")]
        public async Task<ClientEntity> Get(string id)
        {
            return await _clientService.GetClient(id);
        }

        [HttpPost("createClient")]
        public async Task<IActionResult> CreateClient(CreateClientDTO client)
        {
            var createdClient = await _clientService.CreateClient(client); 

            return Ok(createdClient);
        }

        [HttpDelete("deleteClient/{id}")]
        public async Task<IActionResult> DeleteClient(string id)
        {
            var deletedClient = await _clientService.DeleteClient(id);
            return Ok(deletedClient);
        }

        [HttpPut("updateClient/{id}")]
        public async Task<IActionResult> UpdateClient(string id, [FromBody] CreateClientDTO client)
        {
            var updatedClient = await _clientService.UpdateClient(id, client);
            return Ok(updatedClient);
        }

    }
}
