using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buisness;
using Microsoft.AspNetCore.Mvc;

namespace EcommercialAdminPanel.Controllers
{
    public class BaseController : Controller
    {
        private AdminBuisnessServices _buisnesService;
        protected AdminBuisnessServices BuisnesServices
        {
            get
            {
                return _buisnesService = _buisnesService ?? new AdminBuisnessServices();
            }
        }
    }
}