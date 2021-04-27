using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Consomi.net.Models;
using Consomi.net.Service;

namespace Consomi.net.Controllers
{
    public class CartController : Controller
    {
        private CartService cartService = new CartService();
        // GET: Cart
        public ActionResult Index()
        {
            return View(cartService.GetAll());
        }
        public ActionResult Viewl()
        {
            return View();
        }
        public ActionResult detailcart(int id)
        {

            Cart cart = cartService.GetById(id);

            if (cart != null)
            {

                return View(cart);
            }

            return View();

        }
        // GET: Cart/Create
        public ActionResult Create()
        {



            ViewBag.Iduser = new SelectList(cartService.getAllUser(), "Iduser", "Iduser");

            


            return View();
        }

        // POST: Cart/Create
        [HttpPost]
        public ActionResult Create( Cart c)
        {



            if (cartService.Add(c))
            {
                return RedirectToAction("Index");
            }



            return View();

        }
        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            Cart c = cartService.GetById(id);

            if (c != null)
            {


                return View(c);
            }
            return View();
        }

        // POST: Cart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {


            if (cartService.deleteCartById(id))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
    }
    }
