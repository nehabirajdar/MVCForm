using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCForm.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonDetails()
        {
            List<string> options = new List<string>() { "Select option", "Yes", "No" };
            ViewData["options"] = new SelectList(options);
            return View();
        }


        [HttpPost]
        public IActionResult PersonDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.Contact = form["contact"];
            ViewBag.Gender = form["gender"];
            ViewBag.Options = form["options"];
            return View("Display");
        }

    }
}
