using System;

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
        public string Autor {  get; set; }
        public string CovertUrl { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
