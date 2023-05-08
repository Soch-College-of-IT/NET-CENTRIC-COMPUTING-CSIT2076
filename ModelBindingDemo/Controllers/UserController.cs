using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;

namespace ModelBindingDemo.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new WebUser() { FirstName = "Alice", LastName = "Hansen"});
        }
    }
}
