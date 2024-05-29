
using Microsoft.EntityFrameworkCore;
using Biblioteca_2._0.Models;

namespace Biblioteca_2._0.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
    }
}