using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class AdsViewController : Controller
    {
        // GET: AdsView
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<AdsView> adsview = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/getAllAdsView");
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<AdsView>>();
                    readJob.Wait();
                    adsview = readJob.Result;
                    Console.WriteLine(adsview);
                    System.Diagnostics.Debug.WriteLine("here" + adsview);
                }
                else
                {
                    //return the error
                    adsview = Enumerable.Empty<AdsView>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(adsview);
        }

        // GET: AdsView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdsView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdsView/Create
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

        // GET: AdsView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdsView/Edit/5
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

        // GET: AdsView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdsView/Delete/5
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

        public ActionResult FinalStat()
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<AdsView> adsview = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/finalStats");
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<AdsView>>();
                    readJob.Wait();
                    adsview = readJob.Result;
                    Console.WriteLine(adsview);
                    System.Diagnostics.Debug.WriteLine("here" + adsview);
                }
                else
                {
                    //return the error
                    adsview = Enumerable.Empty<AdsView>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(adsview);
        }
    }
}
