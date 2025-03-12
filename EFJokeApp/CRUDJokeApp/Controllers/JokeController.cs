using CRUDJokeApp.Data;
using CRUDJokeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDJokeApp.Controllers
{
    public class JokeController : Controller
    {
        private readonly JokeDbContext jokeDbContext;


        public JokeController(JokeDbContext jokeDbContext)
        {
            this.jokeDbContext = jokeDbContext;
        }

        // Get all jokes
        [HttpGet]
        [Route("Joke")]
        public async Task<IActionResult> Index()
        {
            var jokes = await jokeDbContext.Jokes.ToListAsync();
            return View(jokes);
        }

        // Get one joke
        [HttpGet]
        [Route("Joke/Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var joke = await jokeDbContext.Jokes.FirstOrDefaultAsync(a => a.Id == id);
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
        public async Task<IActionResult> Add(Joke joke)
        {
            if (ModelState.IsValid)
            {
                var newjoke = new Joke()
                {
                    JokeQuestion = joke.JokeQuestion,
                    JokeAnswer = joke.JokeAnswer,
                };
                await jokeDbContext.Jokes.AddAsync(newjoke);
                await jokeDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(joke);
        }

        // Get Edit.cshtml page
        [HttpGet]
        [Route("Joke/Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var joke = await jokeDbContext.Jokes.FirstOrDefaultAsync(a => a.Id == id);
            return View(joke);
        }
        
        // Edit one joke
        [HttpPost]
        [Route("Joke/Edit/{id}")]
        public async Task<IActionResult> Edit(Joke NewJoke)
        {
            if (ModelState.IsValid)
            {
                var joke = await jokeDbContext.Jokes.FindAsync(NewJoke.Id);
                if (joke != null)
                {
                    joke.JokeQuestion = NewJoke.JokeQuestion;
                    joke.JokeAnswer = NewJoke.JokeAnswer;
                    await jokeDbContext.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                
            }
            return View(NewJoke);
        }

        // Delete
        [HttpGet]
        [Route("Joke/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var joke = await jokeDbContext.Jokes.FindAsync(id);
            if (joke != null)
            {
                jokeDbContext.Jokes.Remove(joke);
                await jokeDbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
