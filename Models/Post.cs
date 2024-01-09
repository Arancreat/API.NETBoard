using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.NETBoard.Models
{
    [Table("Message")]
    public class Post
    {
        [Key] 
        public long Id { get; set; }
        
        public string? Subject { get; set; }
        
        public string? Name { get; set; }

        public string? Text { get; set; }
        
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        
        public bool IsThread { get; set; } = false;
        
        public bool IsVisible { get; set; } = false;

        public bool IsPinned { get; set; } = false;
    }
}
