using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Ajitkumar Govinbdaraj",
                Dob = new DateTime(1997, 11, 08)
            };

            return View(data);
        }
    }
}
