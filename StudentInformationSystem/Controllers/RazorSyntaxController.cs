using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSystem.Controllers
{
    public class RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
