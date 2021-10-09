using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody] BookVM model)
        {
            _booksService.AddBook(model);
            return Ok();
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookbyId(int id)
        {
            return Ok(_booksService.GetBookById(id));
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            return Ok(_booksService.GetAllBooks());
        }

        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] BookVM book)
        {
            return Ok(_booksService.UpdateBookById(id, book));
        }
        [HttpDelete("delete-book-by-id")]
        public IActionResult DeleteBookById(int id)
        {
            _booksService.DeleteBookById(id);
            return Ok();
        }
    }
}
