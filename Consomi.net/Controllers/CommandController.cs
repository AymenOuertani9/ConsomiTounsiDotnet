using Consomi.net.Models;
using Consomi.net.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consomi.net.Controllers
{

    public class CommandController : Controller
    {
        private CommandService commandService = new CommandService();
        //private LigneCommandService lcService = new LigneCommandService();
        // GET: Command
        public ActionResult Index()
        {

            return View(commandService.GetAll());

        }
        public ActionResult Indexpayement(int id)
        {

            Command lc = commandService.GetById(id);

            if (lc != null)
            {

                return View(lc);
            }


            return View();

        }
        public ActionResult accesstopaymnt()
        {

            return View(commandService.GetAll());

        }
        public ActionResult getmaxnum()
        {

            return View(commandService.Getmaxnum());

        }
        // GET: Comand/Details/5
        public ActionResult Details(int id)
        {
            Command lc = commandService.GetById(id);

            if (lc != null)
            {

                return View(lc);
            }


            return View();
        }
        public ActionResult getcmdbyuser(int iduser)
        {
            Command lc = commandService.GetcommandByIduser(iduser);

            if (lc != null)
            {

                return View(lc);
            }


            return View();
        }

        public ActionResult ListTransaction()
        {

            return View(commandService.GetAll());

        }
        public ActionResult listeOrderadmin()
        {

            return View(commandService.GetAll());

        }

        // GET: Comand/Create
        public ActionResult Create()
        {



            ViewBag.Idcart = new SelectList(commandService.getAllCart(), "Idcart", "Idcart");

            ViewBag.IdDelivery = new SelectList(commandService.getAlldelivery(), "IdDelivery", "Region");
           // ViewBag.Idcart = new SelectList(commandService.getAllCart(), "Idcart", "Idcart");

            return View();
        }

        // POST: Comand/Create
        [HttpPost]
        public ActionResult Create(Command command)
        {



            if (commandService.Add(command))
            {
                return RedirectToAction("Index");
            }



            return View();

        }
        // GET: Comand/Delete/5
        public ActionResult Delete(int id)
        {
            Command command = commandService.GetById(id);

            if (command != null)
            {


                return View(command);
            }
            return View("Command/listeOrderadmin");
        }

        // POST: Comand/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {


            if (commandService.deleteCommandById(id))
            {
                return RedirectToAction("listeOrderadmin");
            }


            return View();

        }
      
        public ActionResult CancelOrder(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult CancelOrder(int id,  Command c)
        {

            if (commandService.CancelOrder(c))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
        public ActionResult updatestatus(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult updatestatus( Command c)
        {

            if (commandService.updatestatus(c))
            {
                return RedirectToAction("ListTransaction");
            }


            return View("ListTransaction");

        }
        public ActionResult updatestatusbydelivery(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult updatestatusbydelivery( Command c)
        {

            if (commandService.updatestatusbydelivery(c))
            {
                return RedirectToAction("listeOrderadmin");
            }


            return View();

        }
        public ActionResult payin3months(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult payin3months(Command c)
        {

            if (commandService.payin3months(c))
            {
                return RedirectToAction("listeOrderadmin");
            }


            return View();

        }
        public ActionResult payin6months(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult payin6months(Command c)
        {

            if (commandService.payin6months(c))
            {
                return RedirectToAction("listeOrderadmin");
            }


            return View();

        }
        public ActionResult payin9months(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult payin9months(Command c)
        {

            if (commandService.payin9months(c))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
        public ActionResult payin12months(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult payin12months(Command c)
        {

            if (commandService.payin12months(c))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
        public ActionResult remboursercommand(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult remboursercommand(Command c)
        {

            if (commandService.remboursercommand(c))
            {
                return RedirectToAction("ListTransaction");
            }


            return View();

        }
        public ActionResult paybytransfer(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult paybytransfer(Command c)
        {

            if (commandService.payerbytransfer(c))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
        public ActionResult payamounttoseller(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult payamounttoseller(Command c)
        {

            if (commandService.payamounttoseller(c))
            {
                return RedirectToAction("ListTransaction");
            }


            return View();

        }
        public ActionResult paybyfidelity(int id)
        {


            //ViewBag.IdProduct = new SelectList(commandService.getAllProduct(), "IdProduct", "ProductName");


            Command c = commandService.GetById(id);




            if (c != null)
            {

                return View(c);
            }


            return View();


        }

        // POST: Comand/Edit/5
        [HttpPost]
        public ActionResult paybyfidelity(Command c)
        {

            if (commandService.paybyfidelity(c))
            {
                return RedirectToAction("Index");
            }


            return View();

        }
        public ActionResult paypal()
        {


          

            return View();


        }

       
       
      
    }
}