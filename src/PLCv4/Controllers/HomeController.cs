using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using PLCv4.Models;

namespace PLCv4.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<Utilizador> userManager;

        public HomeController(UserManager<Utilizador> userManager)
        {
            this.userManager = userManager;
        }


        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            string userName = userManager.GetUserName(User);
            return View("Index", userName);
        }

        [AllowAnonymous]

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
