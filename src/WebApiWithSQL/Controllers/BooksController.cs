using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApiWithSQL.Domain.Models;
using WebApiWithSQL.Persistence.Contexts;
using System;

namespace WebApiWithSQL.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));

        [HttpGet]
        public IEnumerable<Book> GetAllBook()
        {
            return _context.Books.ToList();
        }
    }
}