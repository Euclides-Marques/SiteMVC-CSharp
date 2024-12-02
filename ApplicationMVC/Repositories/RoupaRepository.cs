using ApplicationMVC.Context;
using ApplicationMVC.Models;
using ApplicationMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApplicationMVC.Repositories
{
    public class RoupaRepository : IRoupaRepository
    {
        private readonly AppDbContext _context;

        public RoupaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Roupa> Roupas => _context.Roupas.Include(c => c.Categoria);

        public Roupa GetRoupaById(Guid RoupaId)
        {
            return _context.Roupas.FirstOrDefault(l => l.RoupaId.Equals(RoupaId));
        }
    }
}
