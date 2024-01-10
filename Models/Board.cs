using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.NETBoard.Models
{
    [Table("Boards"), PrimaryKey(nameof(Code))]
    public class Board
    {
        public string Code { get; set; } = string.Empty;
        
        public string? Name { get; set; }
        
        public string? Description { get; set; }
        
        public int BumpLimit { get; set; } = 50;
        
        public int ThreadCountLimit { get; set; } = 50;
        
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public bool IsHidden { get; set; } = false;
    }
}
