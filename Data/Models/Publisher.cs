using System;
using System.Collections.Generic;

namespace Libreria_CESAR.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion
        public List<Book> Books { get; set; }
    }
}
