using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCForm.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            List<string> options = new List<string>() { "Select stream", "CS", "IT", "E&TC", "Mechanical","Civil" };
            ViewData["stream"] = new SelectList(options);
            return View();
           
        }
        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form)
        {
            ViewBag.RollNo = form["rollno"];
            ViewBag.Name = form["name"];
            ViewBag.Percentage = form["percentage"];
            ViewBag.Stream = form["stream"];
            
            return View("Display");




        }
    }
}
