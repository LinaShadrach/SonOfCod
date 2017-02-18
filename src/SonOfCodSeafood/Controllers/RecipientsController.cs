using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using SonOfCodSeafood.ViewModels;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCodSeafood.Controllers
{
    public class RecipientsController : Controller
    {
        private SonOfCodSeafoodContext db = new SonOfCodSeafoodContext();
        // GET: /<controller>/
        public IActionResult Newsletter()
        {
            ViewBag.FishList = db.Fish.ToList();
            return View();
         }
        public IActionResult Subscribe(string id)
        {
            Recipient recipient = db.Recipients.FirstOrDefault(r => r.ApplicationUserId.Equals(id));
            return View(recipient);
        }
        [HttpPost]
        public IActionResult Subscribe(string name, string zipCode, int[] fishIds, string userId)
        {

            Recipient recipient = new Recipient(name, zipCode);
            recipient.ApplicationUserId = userId;
            db.Recipients.Add(recipient);
            foreach (var fishId in fishIds)
            {
                db.FishChoices.Add(new FishChoice(recipient.Id, fishId));
            }
            db.SaveChanges();

            return RedirectToAction("Subscribe", "Recipients", new { id = userId });
        }
        [HttpPost]
        public IActionResult Unsubscribe(string email)
        {
            ApplicationUser user = db.Users.FirstOrDefault(r => r.Email == email);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
 
        public IActionResult UnsubscribeUser(int RecipientId)
        {
            Debug.WriteLine("**************");
            Recipient recipient = db.Recipients.FirstOrDefault(r => r.Id == RecipientId);
            db.Recipients.Remove(recipient);
            db.SaveChanges();
            return RedirectToAction("Newsletter", "Admin");
        }
    }
}
