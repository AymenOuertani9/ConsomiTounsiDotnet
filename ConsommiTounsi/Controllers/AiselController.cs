using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ConsommiTounsi.Controllers
{
    public class AiselController : Controller
    {
        // GET: Aisel
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("here");
            IEnumerable<Aisel> aisel = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var responseTask = client.GetAsync("/SpringMVC/servlet/AllAisel");
                responseTask.Wait();
                var result = responseTask.Result;
                System.Diagnostics.Debug.WriteLine("here2" + result);
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<Aisel>>();
                    readJob.Wait();
                    aisel = readJob.Result;
                    Console.WriteLine(aisel);
                    System.Diagnostics.Debug.WriteLine("here" + aisel);
                }
                else
                {
                    //return the error
                    aisel = Enumerable.Empty<Aisel>();
                    ModelState.AddModelError(String.Empty, "error");
                    Console.WriteLine("erreur");
                }

            }
            return View(aisel);
        }

        // GET: Aisel/Details/5
        public ActionResult Details(int id)
        {
            Aisel aisel = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/");

                //HTTP GET

                var responseTask = client.GetAsync("/SpringMVC/servlet/Aisel/getAiselById/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Aisel>();
                    readTask.Wait();

                    aisel = readTask.Result;
                }
            }

            return View(aisel);
        }

        // GET: Aisel/Create
        [HttpPost]
        public ActionResult create(Aisel aisel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081");
                var postJob = client.PostAsJsonAsync<Aisel>("/SpringMVC/servlet/AddAisel", aisel);
                postJob.Wait();
                // return View();
                var postResult = postJob.Result;
                DateTime dateCreation = DateTime.Now;

                if (postResult.IsSuccessStatusCode)

                    return RedirectToAction("ManageAds");
            }
            //ModelState.AddModelError(string.Empty, "Server occured errors. Please check with admin!");
            return View(aisel);
        }

        // POST: Aisel/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Aisel/Edit/5
        public ActionResult Edit(int id)
        {
            Aisel aisel = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/");

                //HTTP GET

                var responseTask = client.GetAsync("/SpringMVC/servlet/Aisel/getAiselById/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Aisel>();
                    readTask.Wait();

                    aisel= readTask.Result;
                }
            }

            return View(aisel);
        }

        // POST: Aisel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Aisel aisel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8081/");


                //HTTP POST
                var putTask = client.PutAsJsonAsync<Aisel>("/SpringMVC/servlet/ModAisel/" + id, aisel);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("index");

                }
                return View(aisel);

            }


        }

        // GET: Aisel/Delete/5
        /*public ActionResult Delete(int id)
        {
            return View();
        }
        */

        // POST: Aisel/Delete/5
        [HttpPost]
        public ActionResult Delete(int idAisel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8085/");

                //HTTP POST
                var deleteTask = client.DeleteAsync("/SpringMVC/servlet/DeleteAisel/" + idAisel.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");

                }
                return RedirectToAction("Index");

            }

        }
        
        [HttpPost]
        public ActionResult ProdToAisel(int catId, int aiselId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8085/");
                var putTask = client.PutAsJsonAsync<Aisel>("/ProdToaisel/" + catId.ToString() + "/" + aiselId.ToString(), null);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("index");

                }
                return View();

            }


        }
        

    } 
}

