using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class GetSeriesController : Controller {
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
}
