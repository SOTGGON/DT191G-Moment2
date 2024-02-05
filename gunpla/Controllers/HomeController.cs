using System.Text.Json;
using gunpla.Models;
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

    [Route("/produkt")]
    [HttpPost]
    public IActionResult Product(GunplaModel model) {
        // Validate input
        if(ModelState.IsValid){
            string jsonStr = System.IO.File.ReadAllText("gunpla.json");

            // Deserialize JSON
            var gunpla = JsonSerializer.Deserialize<List<GunplaModel>>(jsonStr);

            // Lägg till ny gunpla model
            if(gunpla != null) {
                gunpla.Add(model);

                // Serialize JSON
                jsonStr = JsonSerializer.Serialize(gunpla);

                // Skriv ändringar till gunpla.json
                System.IO.File.WriteAllText("gunpla.json", jsonStr);
            }

            // Rensa input form
            ModelState.Clear();

        }
        return View();
    }

    [Route("/omoss")]
    public IActionResult About() {
        return View();
    }
}