using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using WebApiWithSQL.Library.API.Persistence.Contexts;
using WebApiWithSQL.Library.API.Domain.Models;

namespace WebApiWithSQL.Library.API.Controllers
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