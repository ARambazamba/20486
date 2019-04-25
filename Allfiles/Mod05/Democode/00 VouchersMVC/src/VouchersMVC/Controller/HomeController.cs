using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vouchers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "The Vouchers App";
            return View();
        }
    }
}
