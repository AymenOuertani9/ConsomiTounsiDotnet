using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consomi.net.Models;
using Consomi.net.Service;
namespace Consomi.net.Controllers
{
    public class CompteController : Controller
    {
        private CompteService cs = new CompteService();
        private CartService cartService = new CartService();
        // GET: Compte
        public ActionResult Index()
        {
            return View(cs.GetAll());
        }
        // GET: Compte/Create
        public ActionResult Create()
        {



            ViewBag.Iduser = new SelectList(cartService.getAllUser(), "Iduser", "Iduser");




            return View();
        }

        // POST: Compte/Create
        [HttpPost]
        public ActionResult Create(Compte c)
        {



            if (cs.Add(c))
            {
                return RedirectToAction("Index");
            }



            return View();

        }
    }
}