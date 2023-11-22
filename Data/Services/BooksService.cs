using System;
using System.Security.Permissions;
using Libreria_CESAR.Data.ViewModels;
using Libreria_CESAR.Data.Models;

namespace Libreria_CESAR.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CovertUrl = book.CovertUrl,
                DateAdded = DateTime.Now,
            };
            _context.Books.Add(_book);
            _context.SaveChanges();

        }
    }
}
