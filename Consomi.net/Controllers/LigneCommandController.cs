using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Consomi.net.Models;
using Consomi.net.Service;
namespace Consomi.net.Controllers
{
    public class LigneCommandController : Controller
    {
        private LigneCommandService lcService = new LigneCommandService();
        private static Cart cart = new Cart();
        private static Product product = new Product();
        // GET: Cart
        public ActionResult Index()
        {
            return View(lcService.GetAll());
        }
        // GET: LigneComand/Details/5
        public ActionResult Details(int id)
        {
            LigneComand lc = lcService.GetById(id);

            if (lc != null)
            {

                return View(lc);
            }


            return View();
        }
        public ActionResult getbestseller()
        {

            return View(lcService.Getbestseller());

        }
        // GET: LigneComand/Create
        public ActionResult Create()
        {



            ViewBag.Idcart = new SelectList(lcService.getAllCart(), "Idcart", "Idcart");

            ViewBag.IdProduct = new SelectList(lcService.getAllProduct(), "IdProduct" , "ProductName");


            return View();
        }

        // POST: LigneComand/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Qte,Idcart,IdProduct")] LigneComand lc)
        {



            if (lcService.Add(lc))
            {
                return RedirectToAction("Index");
            }



            return View();

        }
        public ActionResult Edit(int id)
        {


            ViewBag.IdProduct = new SelectList(lcService.getAllProduct(), "IdProduct", "ProductName");


            LigneComand lc = lcService.GetById(id);




            if (lc != null)
            {

                return View(lc);
            }


            return View();


        }

        // POST: LigneComand/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "Idlc,Qte,Date,IdProduct")] LigneComand lc)
        {

            if (lcService.Update(lc))
            {
                return RedirectToAction("Index");
            }


            return View();

        }

        // GET: LigneComand/Delete/5
        public ActionResult Delete(int id)
        {
            LigneComand lc = lcService.GetById(id);

            if (lc != null)
            {


                return View(lc);
            }
            return View();
        }

        // POST: LigneComand/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {


            if (lcService.deleteLignCommandById(id))
            {
                return RedirectToAction("Index");
            }


            return View();

        }

    }
}