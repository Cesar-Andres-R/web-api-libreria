using Libreria_CESAR.Data.Models;
using Libreria_CESAR.Data.ViewModels;
using System;
using System.Security.Policy;

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
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Models.Publisher()
            {
                Name = publisher.Name,
                
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();

        }
    }
}
