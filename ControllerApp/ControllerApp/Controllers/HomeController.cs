using ControllerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult()
            //{
            //    Content = "<h1>Welcome!</h1>",
            //    ContentType = "text/html"
            //};

            return Content("<h1>Welcome!</h1>", "text/html");
        }

        [Route("/Employee/John")]
        public JsonResult Employee()
        {
            Employee emp = new Employee() { 
                ID = 101, 
                Name = "John", 
                Salary = 10000, 
                Age = 28 };
            return new JsonResult(emp);
        }
    }
}
