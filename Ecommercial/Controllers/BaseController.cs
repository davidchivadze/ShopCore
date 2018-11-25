using Buisness;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommercial.Controllers
{
    public class BaseController:Controller
    {
        private AdminBuisnessServices _services;
        protected AdminBuisnessServices Service
        {
            get
            {
                return _services = _services ?? new AdminBuisnessServices();
            }
        }
    }
}
