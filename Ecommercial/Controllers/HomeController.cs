using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecommercial.Models;
using Models.AdminPanel.ViewModels.Accounting;

namespace Ecommercial.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            Service.UserServices.AddUser(new UserViewModel()
            {
                FirstName = "daviti",
                LastName = "chivadze",
                BirthDate = DateTime.Now,
                UserName = "dato1996",
                PIN = "35001122068",
                Address = "dadiani 56"
            });
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

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
