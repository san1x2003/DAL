using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sanshop.Models;
using Sanshop.Services.PostServices;

namespace Sanshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAllPost()
        {
            return await _postService.GetAllPost();
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Post>> GetSinglPost(int id)
        {
            var result = await _postService.GetSinglePost(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Post>>> AddPost(Post onePost)
        {
            var result = await _postService.AddPost(onePost);
            return Ok(result);
        }

        [HttpPut("(id)")]
        public async Task<ActionResult<List<Post>>> UpdatePost(int id, Post request)
        {
            var result = await _postService.UpdatePost(id, request); 
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

        [HttpDelete("(id)")]
        public async Task<ActionResult<List<Post>>> DeletePost(int id)
        {
            var result = await _postService.DeletePost(id);
            if (result is null)
                return NotFound("Sorry");

            return Ok(result);
        }

    }
}