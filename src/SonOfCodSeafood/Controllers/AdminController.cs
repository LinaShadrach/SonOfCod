using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCodSeafood.Controllers
{
    public class AdminController : Controller
    {
        private SonOfCodSeafoodContext db = new SonOfCodSeafoodContext();
        // GET: /<controller>/
        [Authorize]
        public IActionResult Newsletter()
        {
            List<Recipient> Recipients = db.Recipients.ToList();
            return View(Recipients);
        }
    }
}
