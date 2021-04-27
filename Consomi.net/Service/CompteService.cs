using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Consomi.net.Service.utils;
using Consomi.net.Models;
using System.Net.Http.Headers;

namespace Consomi.net.Service
{
    public class CompteService
    {
        HttpClient httpClient;
        public CompteService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<Compte> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getallcompte").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var operation = tokenResponse.Content.ReadAsAsync<IEnumerable<Compte>>().Result;
                return operation;
            }

            return new List<Compte>();
        }
        public Boolean Add(Compte c)
        {

            try


            {
                var APIResponse = httpClient.PostAsJsonAsync<Compte>(Statics.baseAddress + "ajouteretaffectercompteauser/" + c.Iduser, c
              ).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);


                return true;


            }
            catch
            {
                return false;
            }
          

        }
        public Compte GetById(int id)
        {


            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getcomptebyid/" + id).Result;

            return tokenResponse.Content.ReadAsAsync<Compte>().Result;

        }
    }
}