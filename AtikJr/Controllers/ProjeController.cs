using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class ProjeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
