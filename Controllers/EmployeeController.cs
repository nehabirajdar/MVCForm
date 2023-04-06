using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCForm.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {
            List<string> options = new List<string>() { "Select department", "HR", "Admin", "Manager", "Sales" };
            ViewData["department"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.EmpId = form["empid"];
            ViewBag.EmpName = form["empname"];
            ViewBag.Salary = form["salary"];
            ViewBag.Department = form["department"];
            ViewBag.Gender = form["gender"];
            return View("Display");




        }
    }

}