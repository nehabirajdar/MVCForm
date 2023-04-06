using Microsoft.AspNetCore.Mvc;
using MVCForm.Models;

namespace MVCForm.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            return View();
        }
        public IActionResult NewEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewEmployee(Employee emp)
        {
            return View();
        }
    }
}
