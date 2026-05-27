using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProyectoresService _service;

        public HomeController(IProyectoresService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            //Uso del modelo de modelos de vista
            var modelo = _service.GetAll();
            //var modelo = new List<Proyector>();
            return View(modelo);
        }

        public IActionResult Create()
        {
            var proyector = new HomeCreateViewModel();
            proyector.FechaDeAlta = DateTime.Now;
            return View(proyector);
        }

        [HttpPost]
        public IActionResult Create(Proyector proyector)
        {
            if (!ModelState.IsValid)
            {
                return View(proyector);
            }
            else
            {
                _service.AddProyector(proyector);
                return RedirectToAction(nameof(Index));

            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
