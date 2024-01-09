using API.NETBoard.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.NETBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController(IPostService postService) : ControllerBase
    {
        private readonly IPostService _postService = postService;

        [HttpGet("/get-threads")]
        public async Task<IActionResult> GetThreads()
        {
            try
            {
                return Ok(await _postService.GetThreads());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    err = ex.InnerException?.Message ?? ex.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }

        [HttpGet("/get-replies/{threadId}")] 
        public async Task<IActionResult> GetReplies(long threadId)
        {
            try
            {
                return Ok(await _postService.GetReplies(threadId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    err = ex.InnerException?.Message ?? ex.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }
    }
}
