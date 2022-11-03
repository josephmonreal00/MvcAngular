using Microsoft.AspNetCore.Mvc;
using NikeCopy.Services;
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
        private readonly INullMailService _mailService;
        public AppController(INullMailService mailService)
        {
            _mailService = mailService;
        }
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
            if (!ModelState.IsValid) {
                // Dont send email
                return View();
            }
            else
            {
                // Send Email
                _mailService.SendMessage("joemonreal23@icloud.com", "subject", "onemore");
                return View();
            }
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
