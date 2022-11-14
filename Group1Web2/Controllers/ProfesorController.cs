using Group1Web2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group1Web2.Controllers
{
    public class ProfesorController : Controller
    {
        public IActionResult Index()
        {
            Group1Web2.Models.Profesori prof1 = new Profesori("Leron", "Berisha");
            Profesori prof2 = new Profesori("Shkelqim", "Miftari");
            List<Profesori> profesoret = new List<Profesori>();
            profesoret.Add(prof1);
            profesoret.Add(prof2);
            return View(profesoret);
        }

        public IActionResult MesoHtml()
        {
            return View();
        }

    }
}
