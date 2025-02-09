using Microsoft.AspNetCore.Mvc;

namespace ControllerApp.Controllers
{
    public class BookController : Controller
    {
        //   /Books?BookId=20&IsLogged=true
        [Route("/Books")]
        public IActionResult Book()
        {
            //if (!Request.Query.ContainsKey("BookId"))
            //{
            //    return BadRequest("Id is not found");
            //}
            //int bookid = Convert.ToInt32(Request.Query["BookId"]);
            //if (bookid < 1 || bookid > 1000)
            //{
            //    return NotFound("Id is not in range of 1 to 1000!");
            //}
            //if (!Convert.ToBoolean(Request.Query["IsLogged"]))
            //{
            //    //return Unauthorized("You are not logged in!");
            //    return StatusCode(StatusCodes.Status401Unauthorized);
            //}
            //return File("/Samples/Sample.pdf", "application/pdf");

            int bookid = Convert.ToInt32(Request.Query["BookId"]);
            bool islogged = Convert.ToBoolean(Request.Query["IsLogged"]);

            return new LocalRedirectResult($"/category/books/{bookid}/{islogged}", true);
        }
    }
}
