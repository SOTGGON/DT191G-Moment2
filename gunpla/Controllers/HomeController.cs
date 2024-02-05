using Microsoft.AspNetCore.Mvc;

namespace gunpla.Controllers;

public class HomeController : Controller 
{
    public IActionResult Index() {
        return View();
    }

    [Route("/produkt")]
    public IActionResult Product() {
        return View();
    }

    [Route("/omoss")]
    public IActionResult About() {
        return View();
    }
}