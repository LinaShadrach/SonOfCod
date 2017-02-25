using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCodSeafood.Controllers
{
    public class AdminController : Controller
    {
        private readonly SonOfCodSeafoodContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        // GET: /<controller>/
        public AdminController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SonOfCodSeafoodContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        [Authorize]
        public async Task<IActionResult> Newsletter()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            List<Recipient> Recipients = _db.Recipients
                .Include(r=>r.ApplicationUser)
                .ThenInclude(a=>a.Roles)
                .ToList();
            ViewBag.IsSuperAdmin = await _userManager.IsInRoleAsync(user, "superadmin");
            return View(Recipients);
        }
    }
}
