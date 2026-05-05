using Microsoft.AspNetCore.Mvc;

namespace Ders1_1_MVC.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
