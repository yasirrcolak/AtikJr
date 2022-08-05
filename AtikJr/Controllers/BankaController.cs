using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class BankaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
