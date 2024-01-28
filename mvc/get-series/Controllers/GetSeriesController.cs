using GetSeries.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class GetSeriesController : Controller {

    private ApplicationDbContext _db;

    public GetSeriesController(ApplicationDbContext db) {
        _db = db;
    }

    // 
    // GET: /GetSeries
    public IActionResult Index() {
        return View();
    }

    // 
    // GET: /GetSeries/Details/{seriesId}
    public IActionResult Details(string ID = "1") {
        ViewData["SeriesId"] = ID;
        return View();
    }

    public string SayHello(string ID, int times, string kuku) {
        string result = "";
        for (int i = 0; i < times; i++) {
            result += $"Hello {ID}, ";
        }
        return result;
    }
}
