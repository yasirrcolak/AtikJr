using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class AracController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
