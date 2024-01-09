using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.NETBoard.Models
{
    [Table("Board")]
    public class Board
    {
        [Key] 
        public string ShortName { get; set; } = string.Empty;
        
        public string? Name { get; set; }
        
        public string? Description { get; set; }
        
        public int BumpLimit { get; set; } = 50;
        
        public int ThreadLimit { get; set; } = 5;
        
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public bool IsVisible { get; set; } = false;
    }
}
