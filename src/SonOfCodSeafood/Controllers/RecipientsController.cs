using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCodSeafood.Controllers
{
    public class RecipientsController : Controller
    {
        private SonOfCodSeafoodContext db = new SonOfCodSeafoodContext();
        // GET: /<controller>/
        public IActionResult Newsletter()
        {
            Debug.WriteLine("***************************************");
            foreach(Fish fish in db.Fish.ToList())
            {
                Debug.WriteLine(fish.Id + "***********" + fish.Name);
            }
            ViewBag.Fish = new SelectList(db.Fish, "FishId", "Name");
            return View();
            }
        [HttpPost]
        public IActionResult SignUp(Recipient recipient, List<Fish> Fish)
        {
            db.Recipients.Add(recipient);
            db.SaveChanges();
            return View(recipient);
        }
    }
}
