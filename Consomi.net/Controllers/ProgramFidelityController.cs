using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consomi.net.Service;
using Consomi.net.Models;
namespace Consomi.net.Controllers
{
    public class ProgramFidelityController : Controller
    {
        private ProgrammeFideliteService pfs = new ProgrammeFideliteService();
        // GET: ProgramFidelity
        public ActionResult Index()
        {
            return View(pfs.GetAll());
        }
        public ActionResult Indexuser()
        {
            return View(pfs.GetAll());
        }
        public ActionResult Details(int id)
        {
            ProgrammeFidelite pf = pfs.GetById(id);

            if (pf != null)
            {

                return View(pf);
            }


            return View();
        }
        public ActionResult addpointfidelity(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            ProgrammeFidelite pf = pfs.GetById(id);




            if (pf != null)
            {

                return View(pf);
            }


            return View();


        }
        // POST: ProgrammeFidelite/Edit/5
        [HttpPost]
        public ActionResult addpointfidelity(ProgrammeFidelite pf)
        {

            if (pfs.addpointfidelity(pf))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
        // GET: Comand/Create
        public ActionResult Addprogramfidelity()
        {



         //  ViewBag.type = new SelectList(new String< palierachat, seuilachat, reductionachat >);

            //ViewBag.IdProduct = new SelectList(lcService.getAllProduct(), "IdProduct", "ProductName");


            return View();
        }

        // POST: Comand/Create
        [HttpPost]
        public ActionResult Addprogramfidelity(ProgrammeFidelite pf)
        {



            if (pfs.Addprogramfidelity(pf))
            {
                return RedirectToAction("Indexuser");
            }



            return View();

        }
    }

}