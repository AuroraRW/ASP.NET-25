using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;

namespace SchoolApp.Controllers
{
    public class ClassController : Controller
    {
        private readonly SchoolDbContext schoolDbContext;
        public ClassController(SchoolDbContext schoolDbContext)
        {
            this.schoolDbContext = schoolDbContext;
        }
        [HttpGet]
        [Route("Class")]
        public async Task<IActionResult> Index()
        {
            var classes = await schoolDbContext.Class
                .Include(c=>c.Teacher)
                .Include(c => c.Subject)
                .Include(c => c.Classroom)
                .Include(c => c.Student)
                .ToListAsync();
            return View(classes);
        }
    }
}
