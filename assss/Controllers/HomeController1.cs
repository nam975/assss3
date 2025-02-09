using Microsoft.AspNetCore.Mvc;

namespace assss.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
