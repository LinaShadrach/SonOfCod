﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using SonOfCodSeafood.ViewModels;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCodSeafood.Controllers
{
    public class AccountController : Controller
    {
        private readonly SonOfCodSeafoodContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SonOfCodSeafoodContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model, string adminPassword)
        {
            ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded && (adminPassword=="admin"))
            {
                await _userManager.AddToRoleAsync(user, "superadmin");
                return await RegisterLogin(user, model.Password);
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public async Task<IActionResult> RegisterLogin(ApplicationUser user, string password)
        {

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user.Email, password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterViewModel model, string name, string zipCode, int[] fishIds)
        {
            ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "user");
                RecipientsController recipientsController = new RecipientsController();
                return recipientsController.Subscribe(name, zipCode, fishIds, user.Id);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);

            bool isAdmin= await _userManager.IsInRoleAsync(user, "admin");
            if (result.Succeeded && isAdmin)
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> GrantAdmin(int RecipientId)
        {
            Recipient recipient = _db.Recipients.FirstOrDefault(r => r.Id == RecipientId);
            ApplicationUser user = _db.Users.Where(u => u.Id.Equals(recipient.ApplicationUserId, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            if (_userManager.IsInRoleAsync(user, "user").Result)
            {
               await _userManager.RemoveFromRoleAsync(user, "user");
            }
           await _userManager.AddToRoleAsync(user, "admin");
            _db.SaveChanges();
            return RedirectToAction("Newsletter", "Admin");
        }
    }
}
