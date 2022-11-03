using Microsoft.AspNetCore.Mvc;
using NikeCopy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeCopy.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index() {
            if (!ModelState.IsValid) { 
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model) {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
