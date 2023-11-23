using Libreria_CESAR.Data.Models;
using Libreria_CESAR.Data.ViewModels;
using System;

namespace Libreria_CESAR.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }


        //Metodo que nos permite agregar un nuevo Author en la BD
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName,
                
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();

        }
    }
}
