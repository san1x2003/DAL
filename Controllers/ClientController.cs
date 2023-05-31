using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sanshop.Models;
using Sanshop.Services.ClientServices;

namespace Sanshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetAllClient()
        {    
             return await _clientService.GetAllClient();
        } 

        [HttpGet("(id)")]
        public async Task<ActionResult<Client>> GetSinglClient(int id)
        {
            var result = await _clientService.GetSingleClient(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpPost("PostClient")]
        public async Task<ActionResult<List<Client>>> AddClient(Client oneClient)
        {
            var result = await _clientService.AddClient(oneClient);
            return Ok(result);
        }
        
        [HttpPut("(id)")]
        public async Task<ActionResult<List<Client>>> UpdateClient(int id, Client request)
        {
            var result = await _clientService.UpdateClient(id, request);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpDelete("(id)")]
        public async Task<ActionResult<List<Client>>> DeleteClient(int id)
        {
            var result =  await _clientService.DeleteClient(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

    }
}

