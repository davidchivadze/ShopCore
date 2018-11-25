using Models.AdminPanel.Database;
using Models.AdminPanel.Database.Accounting;
using Models.AdminPanel.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.AdminPanel.Mappers
{
   public static class Transformer
    {
        public static UserViewModel AsViewModel(User model)
        {
            return new UserViewModel()
            {
                ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                PIN = model.PIN,
                Address = model.Address,
                IsDeleted = model.IsDeleted,

            };
        }
        public static User AsDatabaseModel(UserViewModel model)
        {
            return new User()
            {
                //ID = model.ID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                PIN = model.PIN,
                Address = model.Address,
                UserName=model.UserName,
                IsDeleted = model.IsDeleted,
                Password=model.Password,
                

            };
        }
    }
}
