using Microsoft.AspNetCore.Mvc;
using ModelBindingApp.Models;

namespace ModelBindingApp.Controllers
{
    public class BookController : Controller
    {
        [Route("/Books/{BookId?}/{Author?}")]
        public IActionResult Book(Book book)
        {
            if (book.BookId.HasValue == false)
            {
                return Content("ID is not found", "Text/plain");
            }

            if (!ModelState.IsValid)
            {
                List<string> errors = new List<string>();
                foreach (var value in ModelState.Values)
                {
                    foreach(var error in value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string errorMessages = string.Join("\n", errors);
                return BadRequest(errorMessages);
            }
            return Content($"Book ID is:{book.BookId}\nAuthor is {book.Author}", "text/plain");
        }
    }
}
