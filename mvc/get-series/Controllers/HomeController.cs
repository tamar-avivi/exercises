using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using get_series.Models;
using GetSeries.Data;

namespace get_series.Controllers;

public class HomeController : Controller {
    // private readonly ILogger<HomeController> _logger;

    private ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db) {
        _db = db;
    }

    public IActionResult Index() {
        var seriesList = _db.Series.ToList();
        return View(seriesList);
    }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
