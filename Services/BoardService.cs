using API.NETBoard.Database;
using API.NETBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace API.NETBoard.Services
{
    public interface IBoardService
    {
        public Task<List<Board>> GetAll();
    }

    public class BoardService(DataContext dataContext) : IBoardService
    {
        private readonly DataContext _dataContext = dataContext;

        public async Task<List<Board>> GetAll()
        {
            return await _dataContext.Boards.ToListAsync();
        }
    }
}
