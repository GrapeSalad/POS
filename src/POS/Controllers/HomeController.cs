using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POS.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace POS.Controllers
{
    public class HomeController : Controller
    {
        private POSDbContext db = new POSDbContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
