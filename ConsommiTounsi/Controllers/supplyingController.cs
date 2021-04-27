using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class supplyingController : Controller
    {
        // GET: supplying
        public ActionResult Index()
        {
            return View();
        }

        // GET: supplying/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: supplying/Create
        public ActionResult Create(supplying supplying)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var postJob = client.PostAsJsonAsync<supplying>("/SpringMVC/servlet/AddSupplying", supplying);
                postJob.Wait();
                // return View();
                var postResult = postJob.Result;
                DateTime dateCreation = DateTime.Now;

                if (postResult.IsSuccessStatusCode)

                    return RedirectToAction("ManageAds");
            }
            //ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin!");
            return View(supplying);
        }

        // POST: supplying/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: supplying/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: supplying/Edit/5
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

        // GET: supplying/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: supplying/Delete/5
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
    }
}
