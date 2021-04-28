using Consomi.net.Service.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Consomi.net.Models;
namespace Consomi.net.Service
{
    public class BillService
    {
        HttpClient httpClient;
        public BillService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<Bill> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getallbill").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var bill = tokenResponse.Content.ReadAsAsync<IEnumerable<Bill>>().Result;
                return bill;
            }

            return new List<Bill>();
        }
        public IEnumerable<Lignefacture> getAlllf()
        {

            var response = httpClient.GetAsync(Statics.baseAddress + "/getlign").Result;

            if (response.IsSuccessStatusCode)
            {
                var lfs = response.Content.ReadAsAsync<IEnumerable<Lignefacture>>().Result;

                return lfs;
            }

            return new List<Lignefacture>();

        }
        public Boolean Add(Bill b)
        {

            try


            {
                var APIResponse = httpClient.PostAsJsonAsync<Bill>(Statics.baseAddress + "addandassigndelveryabill/"+b.Idlig, b
              ).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);


                return true;


            }
            catch
            {
                return false;
            }


        }
        public bool deleteBillById(int Idbill)
        {
            try
            {

                var APIResponse = httpClient.DeleteAsync(Statics.baseAddress + "deletebyid/" + Idbill);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Bill GetById(int id)
        {


            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getbillbyid/" + id).Result;

            return tokenResponse.Content.ReadAsAsync<Bill>().Result;

        }
    }
}