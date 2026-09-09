using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: /Registration/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Registration/Register
        [HttpPost]
        public IActionResult Register(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Registration successful!";

                ModelState.Clear();

                return View();
            }

            return View(model);
        }
    }
}
