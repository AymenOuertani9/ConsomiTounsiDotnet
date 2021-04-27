using Consomi.net.Models;
using Consomi.net.Service.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Consomi.net.Service
{
    public class CartService
    {
        HttpClient httpClient;
        public CartService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<Cart> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "listcartitems").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var cart = tokenResponse.Content.ReadAsAsync<IEnumerable<Cart>>().Result;
                return cart;
            }

            return new List<Cart>();
        }
        public Cart GetById(int id)
        {
           

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getCartById/" + id).Result;

            return tokenResponse.Content.ReadAsAsync<Cart>().Result;

        }
        public Boolean Add(Cart c)
        {

            try


            {
                var APIResponse = httpClient.PostAsJsonAsync<Cart>(Statics.baseAddress + "ajouteretaffecterCartaUser/" +c.Iduser,c
              ).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);


                return true;


            }
            catch
            {
                return false;
            }


        }

        public IEnumerable<User> getAllUser()
        {

            var response = httpClient.GetAsync(Statics.baseAddress + "getAll").Result;

            if (response.IsSuccessStatusCode)
            {
                var users = response.Content.ReadAsAsync<IEnumerable<User>>().Result;

                return users;
            }

            return new List<User>();

        }

        public bool deleteCartById(int Idcart)
        {
            try
            {

                var APIResponse = httpClient.DeleteAsync(Statics.baseAddress + "deleteCartById/" + Idcart);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}