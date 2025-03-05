using Microsoft.AspNetCore.Mvc;

namespace CRUDJokeApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
