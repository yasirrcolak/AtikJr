using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class atik : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
