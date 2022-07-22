using Microsoft.EntityFrameworkCore;

using WebApiAutores.Entidades;

namespace WebApiAutores.Contextos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
