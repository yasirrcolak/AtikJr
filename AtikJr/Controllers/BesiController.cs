using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class BesiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
