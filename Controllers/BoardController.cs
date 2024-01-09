using API.NETBoard.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.NETBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController(IBoardService boardService) : ControllerBase
    {
        private readonly IBoardService _boardService = boardService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _boardService.GetAll());
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
