using Microsoft.AspNetCore.Mvc;

namespace ControllerApp.Controllers
{
    public class FileController : Controller
    {
        [Route("/File1")]
        public VirtualFileResult File1()
        {
            //return new VirtualFileResult("/Samples/Sample.pdf", "application/pdf");
            return File("/Samples/Sample.pdf", "application/pdf");
        }

        [Route("/File2")]
        public PhysicalFileResult File2() 
        {
            //return new PhysicalFileResult("C:\\files\\Sample2.pdf", "application/pdf");
            return PhysicalFile("C:\\files\\Sample2.pdf", "application/pdf");
        }

        [Route("/File3")]
        public IActionResult File3() 
        {
            return new VirtualFileResult("/Samples/Sample.pdf", "application/pdf");
        }

    }
}
