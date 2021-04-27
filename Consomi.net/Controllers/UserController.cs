using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consomi.net.Models;
using Consomi.net.Service;
namespace Consomi.net.Controllers
{
    public class UserController : Controller
    {
        private UserService userserv = new UserService();
        // GET: User
       
        public ActionResult Index()
        {

            return View(userserv.GetAll());

        }
    }
}