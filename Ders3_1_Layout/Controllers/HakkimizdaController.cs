using Microsoft.AspNetCore.Mvc;

namespace Ders3_1_Layout.Controllers
{
    public class HakkimizdaController : Controller
    {
        /*
         https://bootsnipp.com/snippets/pj2aa
         */
        public IActionResult Index()
        {
            return View();
        }
    }
}
