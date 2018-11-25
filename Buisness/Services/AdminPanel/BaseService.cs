using Database.Interfaces;
using Database.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Services.AdminPanel
{
  public class BaseService
    {
        private IUserRepository _userRepository;
        protected IUserRepository UserRepository
        {
            get
            {
                return _userRepository=_userRepository?? new UserRepository(); 
            }
        }
    }
}
