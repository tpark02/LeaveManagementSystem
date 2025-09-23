using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1954, 12, 01),
            };
            return View(data);
        }

    }
}
