using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.AdminPanel.ViewModels.Accounting;
namespace EcommercialAdminPanel.Controllers
{
    public class UsersController : BaseController
    {
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult UsersList()
        {
            var data = new UserListModel();
            data.UsersList = BuisnesServices.UserServices.GetUsersList();
            return View(data);
        }
        public IActionResult GetUser(int userID)
        {
            var data = BuisnesServices.UserServices.GetUserByID(userID);
            return Json(new
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                BirthDate = data.BirthDate.ToString("yyyy-MM-dd"),
                PIN = data.PIN,
                Address = data.Address,
                ID = data.ID,
                UserName = data.UserName
            });
        }
        public IActionResult UpdateUser(UserViewModel model)
        {
            try
            {
                if (BuisnesServices.UserServices.UpdateUser(model) != null)
                {
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}