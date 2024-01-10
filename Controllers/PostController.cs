using API.NETBoard.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.NETBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController(IPostService postService) : ControllerBase
    {
        private readonly IPostService _postService = postService;

        [HttpGet("get-all-ops")]
        public async Task<IActionResult> GetAllOPs()
        {
            try
            {
                return Ok(await _postService.GetAllOPs());
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

        [HttpGet("get-thread/{threadId}")] 
        public async Task<IActionResult> GetThread(long threadId)
        {
            try
            {
                return Ok(await _postService.GetThread(threadId));
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
