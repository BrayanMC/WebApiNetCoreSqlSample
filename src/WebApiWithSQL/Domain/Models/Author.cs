using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiWithSQL.Domain.Models
{
    public class Author {
        [Key]
        [Column("Id_Author")]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        [Column("Last_Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Book> Books {get; set;}
    }
}