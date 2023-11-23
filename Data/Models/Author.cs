using System;
using System.Collections.Generic;

namespace Libreria_CESAR.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Propiedades de navegacion

        public List<Book_Author> book_Authors { get; set; }
    }
}
