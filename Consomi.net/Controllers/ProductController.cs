using Consomi.net.Models;
using Consomi.net.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consomi.net.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductService ps = new ProductService();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult detail(int id)
        {

            Product cart = ps.GetById(id);

            if (cart != null)
            {

                return View(cart);
            }

            return View();

        }
    }
}