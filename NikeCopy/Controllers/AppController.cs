﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
