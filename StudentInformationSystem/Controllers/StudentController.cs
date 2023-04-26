using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
