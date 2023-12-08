using Libreria_CESAR.Data.Models;
using Libreria_CESAR.Data.ViewModels;
using Libreria_CESAR.Exceptions;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text.RegularExpressions;
using Publisher = Libreria_CESAR.Data.Models.Publisher;//Si falla este Using es el responsable

namespace Libreria_CESAR.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;

        public PublishersService(AppDbContext context)
        {
            _context = context;
        }


        //Metodo que nos permite agregar una nueva Editora en la BD
        public Publisher AddPublisher(PublisherVM publisher)
        {
            if (StringStartsWithNumber(publisher.Name)) throw new PublisherNameException("El nombre empieza con un número",
                publisher.Name);

            var _publisher = new Models.Publisher()
            {
                Name = publisher.Name,
                
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();

            return _publisher;
        }



        public Publisher GetPublisherById(int id) => _context.Publishers.FirstOrDefault(n => n.Id == id);


        public PublisherWithBooksAndAuthorsVM GetPublisherData(int publisherId)
        {
            var _publisherData = _context.Publishers.Where(n => n.Id == publisherId)
                .Select(n => new PublisherWithBooksAndAuthorsVM()
                {
                    Name = n.Name,
                    BookAuthors = n.Books.Select(n => new BookAuthorVM()
                    {
                        BookName = n.Titulo,
                        BookAuthors = n.book_Authors.Select(n => n.Author.FullName).ToList(),
                    }).ToList()
                }).FirstOrDefault();
            return _publisherData;
        }

        internal void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(n => n.Id == id);
            if (_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception($"La editorial con el id {id} no existe!");
            }
        }


        private bool StringStartsWithNumber(string name) => (Regex.IsMatch(name, @"^\d"));
        
    }
}
