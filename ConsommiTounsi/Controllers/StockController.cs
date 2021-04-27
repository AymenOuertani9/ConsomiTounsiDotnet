using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace ConsommiTounsi.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            return View();
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stock/Create
        [HttpPost]
        public ActionResult createview()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddQS(Stock stock)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var postJob = client.PostAsJsonAsync<Stock>("/SpringMVC/servlet/AddAd", stock);
                postJob.Wait();
                // return View();
                var postResult = postJob.Result;
                DateTime dateCreation = DateTime.Now;

                if (postResult.IsSuccessStatusCode)

                    return RedirectToAction("ManageStock");
            }
            //ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin!");
            return View(stock);
        }

        // POST: Stock/Create
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

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stock/Edit/5
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

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stock/Delete/5
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

        public ActionResult Managestock()
        {
            ViewBag.Message = "Your application description page.";

            return View("ManageStock");
        }

        public ActionResult AddStock()
        {
            return View("AddStock");
        }

        public ActionResult GetStock(int ProdId)
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<Stock> stock = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/GetStock/" + ProdId.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Stock>>();
                    readJob.Wait();
                    stock = readJob.Result;
                    Console.WriteLine(stock);
                    System.Diagnostics.Debug.WriteLine("here" + stock);
                }
                else
                {
                    //return the error
                    stock = Enumerable.Empty<Stock>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(stock);
        }

        public ActionResult GetStockQuantity(float quan)
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<Stock> stock = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/GetStockQuan/" + quan.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Stock>>();
                    readJob.Wait();
                    stock = readJob.Result;
                    Console.WriteLine(stock);
                    System.Diagnostics.Debug.WriteLine("here" + stock);
                }
                else
                {
                    //return the error
                    stock = Enumerable.Empty<Stock>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(stock);
        }
    }
}
