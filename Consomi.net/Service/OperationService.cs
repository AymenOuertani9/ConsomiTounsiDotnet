using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Consomi.net.Service.utils;
using Consomi.net.Models;
namespace Consomi.net.Service
{
    public class OperationService
    {
        
            HttpClient httpClient;
            public OperationService()
            {

                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(Statics.baseAddress);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

            }
        public IEnumerable<Operation> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "listoperations").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var operation = tokenResponse.Content.ReadAsAsync<IEnumerable<Operation>>().Result;
                return operation;
            }

            return new List<Operation>();
        }
    }
}