using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Consomi.net.Service.utils;


using System.Net.Http.Headers;
using System.Web;
using Consomi.net.Models;
using System.Net.Http;

namespace Consomi.net.Service
{
    public class ProductService
    {
        HttpClient httpClient;
        public ProductService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public Product GetById(int id)
        {


            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "/listproducts/" + id).Result;

            return tokenResponse.Content.ReadAsAsync<Product>().Result;

        }
    }
}