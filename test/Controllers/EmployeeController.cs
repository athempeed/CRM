using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("index");
        }
    }
}
