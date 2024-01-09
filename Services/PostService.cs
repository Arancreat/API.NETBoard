using API.NETBoard.Database;
using API.NETBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.NETBoard.Services
{
    public interface IPostService
    {
        public Task<List<Post>> GetThreads();

        public Task<List<Post>> GetReplies(long threadId);
    }

    public class PostService(DataContext dataContext) : IPostService
    {
        private readonly DataContext _dataContext = dataContext;
        
        public async Task<List<Post>> GetThreads()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetReplies(long threadId)
        {
            throw new NotImplementedException();
        }
    }
}
