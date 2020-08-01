using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiWithSQL.Domain.Models
{
    public class Book 
    {
        [Key]
        [Column("Id_Book")]
        public int BookId { get; set; }
        [Column("Id_Author")]
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Section { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
    }
}