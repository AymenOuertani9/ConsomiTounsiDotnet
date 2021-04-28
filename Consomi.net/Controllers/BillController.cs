using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consomi.net.Models;
using Consomi.net.Service;
namespace Consomi.net.Controllers
{
    public class BillController : Controller
    {
        private BillService billserv = new BillService();
        private CommandService cs = new CommandService();
        // GET: Bill
        public ActionResult Index()
        {
            return View(billserv.GetAll());
        }
        // GET: Bill/Create
        public ActionResult Create()
        {



            ViewBag.Idlig = new SelectList(billserv.getAlllf(), "Idlig", "Idlig");




            return View();
        }

        // POST: Bill/Create
        [HttpPost]
        public ActionResult Create(Bill b)
        {



            if (billserv.Add(b))
            {
                return RedirectToAction("Index");
            }



            return View();

        }
        // GET: Bill/Delete/5
        public ActionResult Delete(int id)
        {
            Bill b = billserv.GetById(id);

            if (b != null)
            {


                return View(b);
            }
            return View();
        }

        // POST: Bill/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {


            if (billserv.deleteBillById(id))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
    }
}