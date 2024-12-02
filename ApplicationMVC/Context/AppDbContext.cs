using ApplicationMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Roupa> Roupas { get; set; }
    }
}
