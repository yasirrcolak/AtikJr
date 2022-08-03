using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class HomeController1 : Controller
    {

        public string Index()
        {
            return "first page";
        }

        public string Test()
        {
            return "test page";
        }

    }
}
