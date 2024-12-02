using ApplicationMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Categoria> G2_CATEGORIAS { get; set; }
        public DbSet<Roupa> G2_ROUPAS { get; set; }
    }
}
