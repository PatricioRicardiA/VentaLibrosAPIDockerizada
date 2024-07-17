using Microsoft.EntityFrameworkCore;
using VentaLibrosAPI.Models;

namespace VentaLibrosAPI.Contexts
{
    public class AppLibrosBDContext : DbContext
    {
        public AppLibrosBDContext(DbContextOptions<AppLibrosBDContext> options):base(options) { }

        public DbSet<AutorModel> Autor { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<ClienteModel> Clientes { get; set;}
        public DbSet<DetalleCompraLibroModel> DetalleCompraLibros { get; set; }
        public DbSet<LibroModel> Libros { get; set; }
        public DbSet<NacionalidadModel> Nacionalidades { get; set;}
    }
}
