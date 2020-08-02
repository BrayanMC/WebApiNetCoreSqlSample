using Microsoft.EntityFrameworkCore;
using WebApiWithSQL.Library.API.Domain.Models;

namespace WebApiWithSQL.Library.API.Persistence.Contexts
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}