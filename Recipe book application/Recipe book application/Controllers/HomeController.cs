using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_book_application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Login page
        {
            return View();
        }
    }
}
