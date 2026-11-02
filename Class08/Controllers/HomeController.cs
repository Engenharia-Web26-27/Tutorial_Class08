using Class08.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Class08.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
                       return View();
        }

        [Authorize(Roles ="Admin")]
        public IActionResult OnlyAdmins()
        {
            return View();
        }

        [Authorize(Roles = "Client")]
        public IActionResult OnlyClients()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Client")]
        public IActionResult OnlyAdminsAndClients()
        {
            return View();
        }



        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
