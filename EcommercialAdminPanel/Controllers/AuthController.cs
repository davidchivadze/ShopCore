using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Models.AdminPanel.ViewModels.Accounting;

namespace EcommercialAdminPanel.Controllers
{
    public class AuthController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                var result = BuisnesServices.UserServices.LoginUser(model);
                if (result.Count > 0) {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Hash,Guid.NewGuid().ToString()),
                    };
                    foreach(var role in result)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.ToString()));
                    }

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme,ClaimTypes.Name,ClaimTypes.Role);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    return View(model);
                }
                //return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Auth");
        }
    }
}