using Microsoft.AspNetCore.Mvc;

namespace DietTracker.Controllers;

public class StatisticsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
