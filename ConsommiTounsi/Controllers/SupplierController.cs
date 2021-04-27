using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<Supplier> supplier = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/Allsupplier");
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Supplier>>();
                    readJob.Wait();
                    supplier = readJob.Result;
                    Console.WriteLine(supplier);
                    System.Diagnostics.Debug.WriteLine("here" + supplier);
                }
                else
                {
                    //return the error
                    supplier = Enumerable.Empty<Supplier>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(supplier);
        }

        public ActionResult GetSupplierByProduct(int prodId)
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<Supplier> supplier = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/Supplier"+ prodId.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Supplier>>();
                    readJob.Wait();
                    supplier = readJob.Result;
                    Console.WriteLine(supplier);
                    System.Diagnostics.Debug.WriteLine("here" + supplier);
                }
                else
                {
                    //return the error
                    supplier = Enumerable.Empty<Supplier>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(supplier);
        }
        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supplier/Create
        public ActionResult Create(Supplier supplier)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var postJob = client.PostAsJsonAsync<Supplier>("/SpringMVC/servlet/AddSupplier", supplier);
                postJob.Wait();
                // return View();
                var postResult = postJob.Result;
                DateTime dateCreation = DateTime.Now;

                if (postResult.IsSuccessStatusCode)

                    return RedirectToAction("ManageAds");
            }
            //ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin!");
            return View(supplier);
        }

        // POST: Supplier/Create
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

        // GET: Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Supplier/Edit/5
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

        // GET: Supplier/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8085/");

                //HTTP POST
                var deleteTask = client.DeleteAsync("/DelSupplier/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("ManageUsers");

                }
                return RedirectToAction("ManageUsers");

            }

        }

        // POST: Supplier/Delete/5
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
