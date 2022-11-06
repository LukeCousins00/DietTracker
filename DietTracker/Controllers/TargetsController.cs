using Microsoft.AspNetCore.Mvc;

namespace DietTracker.Controllers
{
    public class TargetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
