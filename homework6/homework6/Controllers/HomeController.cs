using homework6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new BirthdayCard());
        }

        // Receive the data coming from the browser
        [HttpPost]
        public IActionResult Index(Models.BirthdayCard guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("SendCard", guestResponse);
            }
            else
            {
                return View(guestResponse);
            }
        }

        public IActionResult SendCard()
        {
            return View();
        }
    }
}
