using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.NETBoard.Models
{
    [Table("Posts"), PrimaryKey(nameof(BoardCode), nameof(Id))]
    public class Post
    {
        public string BoardCode { get; set; } = string.Empty;

        public long Id { get; set; } = 0;

        public long? ParentId { get; set; }
        
        public string? Subject { get; set; }
        
        public string? Name { get; set; }

        public string? Text { get; set; }
        
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        
        public bool IsPinned { get; set; } = false; // for thread

        public bool IsLocked { get; set; } = false; // for thread

        public bool IsHidden { get; set; } = false;
    }
}
