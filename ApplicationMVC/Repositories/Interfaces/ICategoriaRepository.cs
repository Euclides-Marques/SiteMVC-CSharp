using ApplicationMVC.Models;

namespace ApplicationMVC.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
