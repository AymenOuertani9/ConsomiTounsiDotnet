using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consomi.net.Models;
using Consomi.net.Service;
namespace Consomi.net.Controllers
{
    public class OperationController : Controller
    {
        private OperationService os = new OperationService();
        // GET: Operation
        public ActionResult Index()
        {
            return View(os.GetAll());
        }

    }
}