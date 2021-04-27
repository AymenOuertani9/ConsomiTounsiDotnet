using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/SignIn
        public ActionResult SignIn()
        {
            return View();
        }

        // POST: User/SignIn
        [HttpPost]
        public ActionResult SignIn(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("SignIn");
            }
            catch
            {
                return View();
            }
        }
        // POST: User/SignUp
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("SignIn");
            }
            catch
            {
                return View();
            }
        }
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ManageUsers()
        {
            ViewBag.Message = "Your application description page.";

            return View("ManageUsers");
        }
        public ActionResult Chat()
        {
            ViewBag.Message = "Your application description page.";

            return View("Chat");
        }
    }


}
