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
            ViewBag.Fish = db.Fish.ToList();
            return View();
            }
        [HttpPost]
        public IActionResult SignUp(Recipient recipient, int[] fishIds)
        {
            db.Recipients.Add(recipient);
            foreach (var fishId in fishIds)
            {
                Debug.WriteLine(fishId+"**********************************");
                db.FishChoices.Add(new FishChoice(recipient.Id, fishId));
            }
            db.SaveChanges();
            return View(recipient);
        }
    }
}
