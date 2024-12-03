using ApplicationMVC.Models;

namespace ApplicationMVC.ViewModels
{
    public class RoupaListViewModel
    {
        public IEnumerable<Roupa> Roupas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
