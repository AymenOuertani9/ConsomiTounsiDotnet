using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Consomi.net.Models;
using Consomi.net.Service.utils;

namespace Consomi.net.Service
{
    public class ProgrammeFideliteService
    {
        HttpClient httpClient;
        public ProgrammeFideliteService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<ProgrammeFidelite> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "listfidelity").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var lc = tokenResponse.Content.ReadAsAsync<IEnumerable<ProgrammeFidelite>>().Result;
                // string responseBody =  tokenResponse.Content.ToString();
                return lc;
            }

            return new List<ProgrammeFidelite>();
        }
        public ProgrammeFidelite GetById(int idc)
        {

            ProgrammeFidelite c = null;

            var response = httpClient.GetAsync(Statics.baseAddress + "listfidelity/" +idc).Result;

            if (response.IsSuccessStatusCode)
            {
                var pfd = response.Content.ReadAsAsync<ProgrammeFidelite>().Result;

                return pfd;
            }


            return c;

        }
        public bool addpointfidelity(ProgrammeFidelite pf)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);

            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<ProgrammeFidelite>(Statics.baseAddress + "addprogrammefidelite/" + pf.Idfidilite,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean Addprogramfidelity(ProgrammeFidelite pf)
        {

            try


            {
                var APIResponse = httpClient.PostAsJsonAsync< ProgrammeFidelite> (Statics.baseAddress + "addprogfidelity/" + pf.Idcommand, pf
              ).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

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