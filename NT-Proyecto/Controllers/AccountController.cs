using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NT_Proyecto.Models;

namespace NT_Proyecto.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private MarketContext db = new MarketContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View("Create");
        }
        //
        // POST: /Account
        [HttpPost]
        public ActionResult Create(Account Account, Domicilio domicilio, MedioDePago medioDePago)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(Account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(Account);
            }
        }
    }
}
