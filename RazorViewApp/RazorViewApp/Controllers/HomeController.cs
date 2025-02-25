using Microsoft.AspNetCore.Mvc;
using RazorViewApp.Models;

namespace RazorView1.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public IActionResult MyPage()
        {
            // Views/Home/MyPage.cshtml
            //return View("ABC");
            //return new ViewResult { ViewName = "ABC" };
            ViewData["AppTitle"] = "Home";
            return View();
        }
        [Route("/Persons")]
        public IActionResult Index()
        {
            ViewData["AppTitle"] = "Persons";
            //ViewBag.AppTitle = "Razor View App";

            List<Person> people = new List<Person>()
            {
                new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
                new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
                new Person() { Name = "Susan", DateOfBirth = DateTime.Parse("2008-07-12"), PersonGender = Gender.Other}
            };

            //ViewData["people"] = people;

            return View("Index", people);
        }
        [Route("person-with-product")]
        public IActionResult PersonWithProduct()
        {
            ViewData["AppTitle"] = "Person and Product";
            Person person = new Person() { Name = "Sara", PersonGender = Gender.Female, DateOfBirth = Convert.ToDateTime("2004-07-01") };
            Product product = new Product() { ProductId = 1, ProductName = "Air Conditioner" };
            PersonAndProduct PAP = new PersonAndProduct() { PersonData = person, ProductData = product };
            return View(PAP);
        }
    }
}
