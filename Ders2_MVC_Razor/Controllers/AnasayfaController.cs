using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            //Razor => html safasında c# kodları yazmak için kullanılan bir teknolojidir
            return View();
        }


        public IActionResult Menu()
        {
            return View();
        }
    }
}
