using Microsoft.EntityFrameworkCore;
using WebApiWithSQL.Domain.Models;

namespace WebApiWithSQL.Persistence.Contexts
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}