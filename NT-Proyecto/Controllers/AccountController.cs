﻿using System;
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
    }
}
