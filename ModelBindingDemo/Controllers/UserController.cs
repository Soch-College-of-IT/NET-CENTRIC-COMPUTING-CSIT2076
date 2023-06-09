﻿using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;

namespace ModelBindingDemo.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new UserViewModel() { FirstName = "Alice", LastName = "Hansen", Email = "alice@example.com"});
        }

        [HttpPost]
        public IActionResult SimpleBinding(UserViewModel webUser)
        {
            if (ModelState.IsValid)
            {
                return Content("Thank you!" + $"User {webUser.FirstName} updated!");
            }
            else
            {
                return View(webUser);
            }
            // Update in DB
            //return Content($"User {webUser.FirstName} updated!");
        }
    }
}
