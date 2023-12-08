using System;
using System.Collections.Generic;

namespace Libreria_CESAR.Data.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CovertUrl { get; set; }
        public DateTime DateAdded { get; set; }


        //TE QUEDASTE EN EL MINUTO 10:00 EN EL SEGUNDO VIDEO


        //Propiedades de navegacion (en esta parte es donde "mapeamos")
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Book_Author> book_Authors { get; set; }
    }
}