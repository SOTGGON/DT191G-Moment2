using System.Text.Json;
using gunpla.Models;
using Microsoft.AspNetCore.Mvc;

namespace gunpla.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("/produkt")]
    public IActionResult Product()
    {
        string guide = "Klicka på produkter för att läsa mer";
        ViewBag.guide = guide;
        return View();
    }

    [Route("/produkt")]
    [HttpPost]
    public IActionResult Product(GunplaModel model)
    {
        // Validate input
        if (ModelState.IsValid)
        {
            string jsonStr = System.IO.File.ReadAllText("gunpla.json");

            // Deserialize JSON
            var gunpla = JsonSerializer.Deserialize<List<GunplaModel>>(jsonStr);

            // Lägg till ny gunpla model
            if (gunpla != null)
            {
                gunpla.Add(model);

                // Serialize JSON
                jsonStr = JsonSerializer.Serialize(gunpla);

                // Skriv ändringar till gunpla.json
                System.IO.File.WriteAllText("gunpla.json", jsonStr);
            }

            // Rensa input form
            ModelState.Clear();

            return RedirectToAction("Index", "Wishlist");
        }
        return View();
    }

    [Route("/wishlist")]
    public IActionResult Wishlist()
    {

        string jsonStr = System.IO.File.ReadAllText("gunpla.json");

        // Deserialize JSON
        var gunpla = JsonSerializer.Deserialize<List<GunplaModel>>(jsonStr);
        return View(gunpla);
    }

    public IActionResult Product1()
    {
        return View();
    }

    public IActionResult Product2()
    {
        return View();
    }

    public IActionResult Product3()
    {
        return View();
    }
}