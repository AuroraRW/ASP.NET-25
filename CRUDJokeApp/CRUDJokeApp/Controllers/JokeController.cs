using CRUDJokeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDJokeApp.Controllers
{
    public class JokeController : Controller
    {
        // Get all jokes
        [HttpGet]
        [Route("Joke")]
        public IActionResult Index()
        {
            var jokes = JokeRepository.GetJokeList();
            return View(jokes);
        }

        // Get one joke
        [HttpGet]
        [Route("Joke/Details/{id}")]
        public IActionResult Details(int id)
        {
            var joke = JokeRepository.GetJokeById(id);
            return View(joke);
        }

        // Get the Add.cshtml page
        [HttpGet]
        [Route("Joke/Add")]
        public IActionResult Add()
        {
            return View();
        }

        // Create a new joke
        [HttpPost]
        [Route("Joke/Add")]
        public IActionResult Add(Joke joke)
        {
            if (ModelState.IsValid)
            {
                JokeRepository.AddJoke(joke);
                return RedirectToAction("Index");
            }
            return View(joke);
        }

        // Get Edit.cshtml page
        [HttpGet]
        [Route("Joke/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var joke = JokeRepository.GetJokeById(id);
            return View(joke);
        }
        
        // Edit one joke
        [HttpPost]
        [Route("Joke/Edit/{id}")]
        public IActionResult Edit(Joke joke)
        {
            if (ModelState.IsValid)
            {
                JokeRepository.UpdateJoke(joke);
                return RedirectToAction("Index");
            }
            return View(joke);
        }

        // Delete
        [HttpGet]
        [Route("Joke/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            JokeRepository.DeleteJoke(id);
            return RedirectToAction("Index");
        }
    }
}
