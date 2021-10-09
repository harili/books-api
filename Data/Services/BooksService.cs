using my_books.Data.ViewModels;
using my_books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class BooksService
    {
        private AppDbContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public BooksService(AppDbContext context)
        {
            _ctx = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void AddBook(BookVM model)
        {
            var book = new Book
            {
                Title = model.Title,
                Description = model.Description,
                IsRead = model.IsRead,
                DateRead = model.IsRead ? model.DateRead.Value : null,
                Rate = model.IsRead ? model.Rate.Value : null,
                Genre = model.Genre,
                Author = model.Author,
                ConverUrl = model.ConverUrl,
                DateAdded = DateTime.Now
            };

            _ctx.Books.Add(book);
            _ctx.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks() => _ctx.Books.ToList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public Book GetBookById(int bookId) => _ctx.Books.FirstOrDefault(b => b.Id == bookId);

        public Book UpdateBookById(int bookId, BookVM model)
        {
            var book = _ctx.Books.FirstOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                book.Title = model.Title;
                book.Author = model.Author;
                book.Genre = model.Genre;
                book.Description = model.Description;
                book.Rate = model.Rate;
                book.IsRead = model.IsRead;
                book.ConverUrl = model.ConverUrl;
                book.DateRead = model.DateRead;

                _ctx.SaveChanges();
            }
            return book;
        }

        public void DeleteBookById(int bookId)
        {
            var book = _ctx.Books.FirstOrDefault(b => b.Id == bookId);
            _ctx.Remove(book);
            _ctx.SaveChanges();
        }
    }
}
