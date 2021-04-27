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
    public class UserService
    {
        HttpClient httpClient;
        public UserService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<User> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getuser").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var lc = tokenResponse.Content.ReadAsAsync<IEnumerable<User>>().Result;
                // string responseBody =  tokenResponse.Content.ToString();
                return lc;
            }

            return new List<User>();
        }
    }
}