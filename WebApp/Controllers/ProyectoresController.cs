using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        //public IActionResult Index()
        //{
        //    return new ContentResult()
        //    {
        //        Content = ("<h1>Aqui se mostrara la lista de proyectores registrados</h1>"),
        //        ContentType = "text/html"
        //    };
        //}

        //FORMA DE PONER ACENTOS &aacute

        public IActionResult Index()
        {
            return Content(
                "<h1>Aqu&iacute se mostrar&aacute la lista de proyectores registrados</h1>",
                "text/html"
                );
        }

        public IActionResult Details(string id)
        {
            string html = "<h1>Nuevo Proyector</h1>";
            html += $"<p>Aqu&iacute se mostrar&aacute la informaci&oacuten del proyector {id}</p>";
            return Content(html, "text/html");
        }

        public IActionResult Delete(string id)
        {
            string html = "<h1>Dar de Baja</h1>";
            html += $"<p>Aqu&iacute se dar&aacute de baja el proyector {id}</p>";
            return Content(html, "text/html");
        }

        public IActionResult Edit(string id)
        {
            string html = "<h1>Editar Proyector</h1>";
            html += $"<p>Aqu&iacute se modificar$aacute la informacii&oacuten del proyector {id}</p>";
            return Content(html, "text/html");
        }


    }
}
