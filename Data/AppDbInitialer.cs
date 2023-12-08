using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Libreria_CESAR.Data.Models;
using System.Linq;
using System;

namespace Libreria_CESAR.Data
{
    public class AppDbInitialer
    {
        //Metodo que agrega datos a nuestra BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope =  applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();


                //Creo que el "Books" va a dar problema, porque no es como en el video que era "Bookss".
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        CovertUrl = "https...",
                        DateAdded = DateTime.Now,
                    },

                    new Book()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Description",
                        IsRead = true,
                        Genero = "Biography",
                        CovertUrl = "https...",
                        DateAdded = DateTime.Now,
                    });
                    context.SaveChanges();


                    //en el minuto 16:50 en el video 2, no se a que clase le cambio el nombre.
                }
            }
        }
    }
}
