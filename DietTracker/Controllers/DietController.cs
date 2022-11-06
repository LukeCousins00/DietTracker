using DietTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DietTracker.Controllers;

public class DietController : Controller
{
    private readonly ILogger<DietController> _logger;

    public DietController(ILogger<DietController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}