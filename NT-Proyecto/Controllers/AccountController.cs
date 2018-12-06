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
        //
        // GET: Details
        public ActionResult Details(int id)
        {
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View("Details", account);
        }
        public ActionResult Create()
        {
            return View("Create");
        }

        //
        // GET: /Account/Logout
        public ActionResult Logout()
        {
            Session["log"] = null;
            return RedirectToAction("Index", "Home");
        }

        //
        //GET: /Account/ErrorLog
        public ActionResult ErrorLog()
        {
            return View();
        }
        //GET: /Account/ErrorReg
        public ActionResult ErrorReg()
        {
            return View();
        }
        //
        // POST: /Account/LogIn
        //
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account Account)
        {
            var v = db.Accounts.Where(l => l.Email.Equals(Account.Email) && l.Password.Equals(Account.Password)).FirstOrDefault();
            if (v != null)
            {
                Session["log"] = v.Nombre + " " + v.Apellido;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("ErrorLog", "Account");
            }
            //return RedirectToAction("Index", "Home");
        }

        // POST: /Account/Create
        [HttpPost]
        public ActionResult Create(Account Account)
        {
            var isRepeated = db.Accounts.FirstOrDefault(l => l.Email.Equals(Account.Email));
            if (isRepeated == null) { 
                if (ModelState.IsValid)
                {
                    db.Accounts.Add(Account);
                    db.SaveChanges();
                    return RedirectToAction("Details", new { id = Account.ID });
                }
                else
                {
                    return RedirectToAction("ErrorReg", "Account");
                }
            }
            else
            {
                return RedirectToAction("ErrorReg", "Account");
            }
        }
    }
}
