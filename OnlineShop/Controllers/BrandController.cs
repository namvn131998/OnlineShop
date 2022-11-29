using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers;
public class BrandController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
