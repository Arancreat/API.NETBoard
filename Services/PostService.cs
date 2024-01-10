using API.NETBoard.Database;
using API.NETBoard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.NETBoard.Services
{
    public interface IPostService
    {
        public Task<List<Post>> GetAllOPs();

        public Task<List<Post>> GetThread(long threadId);
    }

    public class PostService(DataContext dataContext) : IPostService
    {
        private readonly DataContext _dataContext = dataContext;
        
        public async Task<List<Post>> GetAllOPs()
        {
            return await _dataContext.Posts.Where(p => p.ParentId == null).ToListAsync();
        }

        public async Task<List<Post>> GetThread(long threadId)
        {
            return await _dataContext.Posts
                .Where(p => p.Id == threadId || p.ParentId == threadId)
                .OrderBy(p => p.Id).ToListAsync();
        }
    }
}
