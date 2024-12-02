using ApplicationMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationMVC.Controllers
{
    public class RoupaController : Controller
    {
        private readonly IRoupaRepository _roupaRepository;

        public RoupaController(IRoupaRepository roupaRepository)
        {
            _roupaRepository = roupaRepository;
        }

        public IActionResult List()
        {
            var roupas = _roupaRepository.Roupas;
            return View(roupas);
        }
    }
}
