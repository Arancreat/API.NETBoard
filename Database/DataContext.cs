using API.NETBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace API.NETBoard.Database
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Board> Boards { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
