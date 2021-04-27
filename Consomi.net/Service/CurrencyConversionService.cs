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
    public class CurrencyConversionService
    {
        HttpClient httpClient;
        public CurrencyConversionService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        //public bool Conversionargent(CurrencyConversionBean c)
        //{
        //    //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);

        //    try
        //    {
        //        var APIResponse = httpClient.PutAsJsonAsync<CurrencyConversionBean>(Statics.baseAddress + "/currency-converter/from/"+c.From+"/to/"+c.To+"/amount/"+c.Command.Price,
        //         null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

        //        System.Diagnostics.Debug.WriteLine(APIResponse.Result);

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}
        public IEnumerable<CurrencyConversionBean> GetAll(CurrencyConversionBean cs)
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "/currency-converter/from/"+cs.From+"/to/"+cs.To+"/amount/"+cs.Amount).Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var lc = tokenResponse.Content.ReadAsAsync<IEnumerable<CurrencyConversionBean>>().Result;
                // string responseBody =  tokenResponse.Content.ToString();
                return lc;
            }

            return new List<CurrencyConversionBean>();
        }
    }
}