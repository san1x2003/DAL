using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sanshop.Models;
using Sanshop.Services.PostServices;
using Sanshop.Services.SkladServices;

namespace Sanshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkladController : ControllerBase
    {
        private readonly ISkladService _skladService;
        public SkladController(ISkladService skladService)
        {
            _skladService = skladService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Sklad>>> GetAllSklad()
        {
            return await _skladService.GetAllSklad();
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Sklad>> GetSinglSklad(int id)
        {
            var result = await _skladService.GetSingleSklad(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Sklad>>> AddSklad(Sklad oneSklad)
        {
            var result = await _skladService.AddSklad(oneSklad);
            return Ok(result);
        }

        [HttpPut("(id)")]
        public async Task<ActionResult<List<Sklad>>> UpdateSklad(int id, Sklad request)
        {
            var result = await _skladService.UpdateSklad(id, request);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpDelete("(id)")]
        public async Task<ActionResult<List<Sklad>>> DeleteSklad(int id)
        {
            var result = await _skladService.DeleteSklad(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

    }
}