using Libreria_CESAR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria_CESAR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Book> Books { get; set; }
    }
}
