using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NT_Proyecto.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categoria()
        {
            return View();
        }

        public ActionResult Supermercado()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

    }
}