using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POS.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace POS.Controllers
{
    public class SalesController : Controller
    {
        private readonly POSDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public SalesController(UserManager<ApplicationUser> userManager, POSDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.Tables.Where(x => x.User.Id == currentUser.Id));
        }
        [Route("/Sales/AddTableForm")]
        public IActionResult AddTableForm()
        {
            return View();
        }
        [Route("/Sales/AddTable")]
        [HttpPost]
        public async Task<IActionResult> AddTable(Table table)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            table.User = currentUser;
            _db.Tables.Add(table);
            _db.SaveChanges();
            return RedirectToAction("Index", "Sales");
        }
    }
}
