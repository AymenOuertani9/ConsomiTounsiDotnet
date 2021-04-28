using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class QuanStockController : Controller
    {
        // GET: QuanStock
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuanStock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanStock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanStock/Create
        [HttpPost]
        public ActionResult Create(QuanStock quan)
        {
            //HttpPostedFileBase file = ads.madia;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:8081");
                var postJob = client.PutAsJsonAsync<QuanStock>("/SpringMVC/servlet/AddQStock/1", quan);
                postJob.Wait();
                // return View();
                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)

                    return RedirectToAction("Index");
            }
            //ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin!");
            return View(quan);
        }

        // GET: QuanStock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuanStock/Edit/5
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

        // GET: QuanStock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuanStock/Delete/5
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
