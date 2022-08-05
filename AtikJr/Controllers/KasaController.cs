using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class KasaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
