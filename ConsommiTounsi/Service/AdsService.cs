using ConsommiTounsi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace ConsommiTounsi.Service
{
    public class AdsService
    {
        HttpClient httpClient;
        public AdsService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8081/SpringMVC/servlet/GetAds");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var _AccessToken = Session[" AccessToken "]) ;
            //httpClient.DefaultRequestHeaders.Add(" Authorization ", String.Format(" Bearer {0} ", _AccessToken));
        }
        public Boolean Add(Ads ad)
        {
            try
            {
                
                var APIResponse = httpClient.PostAsJsonAsync<Ads>("http://localhost:8081/SpringMVC/servlet/GetAds",ad).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());
                System.Diagnostics.Debug.WriteLine(APIResponse.Result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Ads getAdsByFdate(DateTime Fdate)
        {
            Ads ad = null;
            var response = httpClient.GetAsync("http://localhost:8081/SpringMVC/servlet/GetAdsByFDate").Result;
            if (response.IsSuccessStatusCode)
            {
                var ads = response.Content.ReadAsAsync<Ads>().Result;
                return ad;
            }
            return ad;
        }

        public Ads getAdsBySdate(DateTime Sdate)
        {
            Ads ad = null;
            var response = httpClient.GetAsync("http://localhost:8081/SpringMVC/servlet/GetAdsBySDate").Result;
            if (response.IsSuccessStatusCode)
            {
                var ads = response.Content.ReadAsAsync<Ads>().Result;
                return ad;
            }
            return ad;
        }

        public Ads getPrevious(int ProdId)
        {
            Ads ad = null;
            var response = httpClient.GetAsync("http://localhost:8081/SpringMVC/servlet/getPrevious/"+ ProdId).Result;
            if (response.IsSuccessStatusCode)
            {
                var ads = response.Content.ReadAsAsync<Ads>().Result;
                return ad;
            }
            return ad;
        }

        public bool UpdateSdate(int id, Ads ad)
        {
            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Ads>("http://localhost:8081/SpringMVC/servlet//ModsDate/" +id, ad).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());
                System.Diagnostics.Debug.WriteLine(APIResponse.Result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateFdate(int id, Ads ad)
        {
            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Ads>("http://localhost:8081/SpringMVC/servlet//ModfDate/" + id, ad).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());
                System.Diagnostics.Debug.WriteLine(APIResponse.Result);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTargetView(int id, Ads ad)
        {
            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Ads>("http://localhost:8081/SpringMVC/servlet/ModTargetView/" + id, ad).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());
                System.Diagnostics.Debug.WriteLine(APIResponse.Result);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}