using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sanshop.Models;
using Sanshop.Services.TovarServices;

namespace Sanshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TovarController : ControllerBase
    {
        private readonly ITovarService _tovarService;
        public TovarController(ITovarService tovarService)
        {
            _tovarService = tovarService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tovar>>> GetAllTovar()
        {
            return await _tovarService.GetAllTovar();
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Tovar>> GetSinglTovar(int id)
        {
            var result = await _tovarService.GetSingleTovar(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Tovar>>> AddTovar(Tovar oneTovar)
        {
            var result = await _tovarService.AddTovar(oneTovar);
            return Ok(result);
        }

        [HttpPut("(id)")]
        public async Task<ActionResult<List<Tovar>>> UpdateTovar(int id, Tovar request)
        {
            var result = await _tovarService.UpdateTovar(id, request);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpDelete("(id)")]
        public async Task<ActionResult<List<Tovar>>> DeleteTovar(int id)
        {
            var result = await _tovarService.DeleteTovar(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

    }
}

