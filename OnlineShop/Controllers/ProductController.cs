using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;
using System.Linq;

namespace OnlineShop.Controllers;
public class ProductController : Controller
{
    public readonly ApplicationDbContext _db;
    public ProductController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Product> products = new List<Product>();
        products = _db.Products.ToList();
        return View(products);
    }
    [HttpGet]
    public IActionResult AddNewProduct()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddNewProduct(Product obj)
    {
        if (ModelState.IsValid)
        {
            _db.Products.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }
}
