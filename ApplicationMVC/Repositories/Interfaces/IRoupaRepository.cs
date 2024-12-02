using ApplicationMVC.Models;

namespace ApplicationMVC.Repositories.Interfaces
{
    public interface IRoupaRepository
    {
        IEnumerable<Roupa> Roupas { get; }
        Roupa GetRoupaById(Guid RoupaId);
    }
}
