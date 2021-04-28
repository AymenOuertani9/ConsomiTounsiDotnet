using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        //"http://localhost:8081/SpringMVC/servlet/GetAds";
        public ActionResult ManageAds()
        {
            System.Diagnostics.Debug.WriteLine("here" );
            IEnumerable<Ads> ads = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/SpringMVC/servlet/GetAds");
                var responseTask = client.GetAsync("/SpringMVC/servlet/GetAds");
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2"+ result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Ads>>();
                    readJob.Wait();
                    ads = readJob.Result;
                    System.Diagnostics.Debug.WriteLine("here3" + ads);
                    Console.WriteLine(ads);
                    System.Diagnostics.Debug.WriteLine("here"+ads);
                }
                else
                {
                    //return the error
                    ads = Enumerable.Empty<Ads>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(ads);

        }
        // GET: Ads/Details/5
        public ActionResult Details(int idAds)
        {
            System.Diagnostics.Debug.WriteLine(idAds);

            Ads ad = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/");

                //HTTP GET

                var responseTask = client.GetAsync("/SpringMVC/servlet/Ads/getAdsById/" + idAds.ToString());
                System.Diagnostics.Debug.WriteLine(idAds);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Ads>();
                    readTask.Wait();

                    ad = readTask.Result;
                }
            }

            return View(ad);

        }

        // GET: Ads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ads/Create
        [HttpPost]
        public ActionResult createview()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Ads ads)
        {
            //HttpPostedFileBase file = ads.madia;
                using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:8081");
                var postJob = client.PostAsJsonAsync<Ads>("/SpringMVC/servlet/AddAd", ads);
                postJob.Wait();
                // return View();
                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)

                    return RedirectToAction("ManageAds");
            }
            //ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin!");
            return View(ads);
        }

        // GET: Ads/Edit/5
        public ActionResult Edit(int idAds)
        {
            Ads ad = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/");

                //HTTP GET

                var responseTask = client.GetAsync("/SpringMVC/servlet/Ads/getAdsById/" + idAds.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Ads>();
                    readTask.Wait();

                    ad = readTask.Result;
                }
            }

            return View(ad);
        }

        // POST: Driver/Edit/5
        [HttpPost]
        public ActionResult EditSDate(int idAds,Ads ads)
        {
     
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8085/");


                //HTTP POST
                var putTask = client.PutAsJsonAsync<Ads>("/SpringMVC/servlet/ModsDate/" + idAds, ads);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("index");

                }
                return View(ads);

            }

        }

        // GET: Ads/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult AdsByFDate(DateTime fDate)
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<Ads> ads = null;
            List<Ads> ads2 = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/SpringMVC/servlet/GetAds");
                var responseTask = client.GetAsync("/SpringMVC/servlet/GetAds");
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Ads>>();
                    readJob.Wait();
                    ads = readJob.Result;
                    Console.WriteLine(ads);
                    System.Diagnostics.Debug.WriteLine("here" + ads);
                    foreach (Ads ad in ads)
                    {

                        if (ad.finishDate != (fDate)){

                            ads2=ads.ToList();
                            ads2.Remove(ad);
                        }
                    }
                }
                else
                {
                    //return the error
                    ads = Enumerable.Empty<Ads>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(ads2);

        }


    }
}
