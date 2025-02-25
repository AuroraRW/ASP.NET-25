using Microsoft.AspNetCore.Mvc;
using RazorViewApp.Models;

namespace RazorViewApp.Controllers
{
    public class ProductController : Controller
    {
        [Route("products/all")]
        public IActionResult All()
        {
            ViewData["AppTitle"] = "All Products";
            Product product = new Product() { ProductId = 1, ProductName = "Air Conditioner" };
            return View(product);
        }
    }
}
