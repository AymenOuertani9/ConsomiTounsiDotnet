using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Consomi.net.Service.utils;

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Consomi.net.Models;
namespace Consomi.net.Service
{
    public class LigneCommandService
    {
        HttpClient httpClient;
        public LigneCommandService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<LigneComand> Getbestseller()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "findTopFiveBestSeller").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var lc = tokenResponse.Content.ReadAsAsync<IEnumerable<LigneComand>>().Result;
                // string responseBody =  tokenResponse.Content.ToString();
                return lc;
            }

            return new List<LigneComand>();
        }
        public IEnumerable<LigneComand> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getall").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var lc = tokenResponse.Content.ReadAsAsync<IEnumerable<LigneComand>>().Result;
               // string responseBody =  tokenResponse.Content.ToString();
                return lc;
            }

            return new List<LigneComand>();
        }
        public LigneComand GetById(int idlc)
        {

            LigneComand lc = null;

            var response = httpClient.GetAsync(Statics.baseAddress +"getbyid/"+idlc).Result;

            if (response.IsSuccessStatusCode)
            {
                var folder = response.Content.ReadAsAsync<LigneComand>().Result;

                return folder;
            }


            return lc;

        }


    


    public Boolean Add(LigneComand lc)
        {

            try

               
            { 
                var APIResponse = httpClient.PostAsJsonAsync<LigneComand>(Statics.baseAddress + "addproducttocart/product/" + lc.IdProduct + "/cart/" + lc.Idcart+ "/qte/" + lc.Qte,null
              ).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);


                return true;


            }
            catch
            {
                return false;
            }


        }
        public IEnumerable<Cart> getAllCart()
        {

            var response = httpClient.GetAsync(Statics.baseAddress + "listcartitems").Result;

            if (response.IsSuccessStatusCode)
            {
                var carts = response.Content.ReadAsAsync<IEnumerable<Cart>>().Result;

                return carts;
            }

            return new List<Cart>();

        }

        public IEnumerable<Product> getAllProduct()
        {

            var response = httpClient.GetAsync(Statics.baseAddress + "listproducts").Result;
            System.Diagnostics.Debug.WriteLine(response.StatusCode);
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;

                return products;
            }

            return new List<Product>();

        }
      
        public bool Update(LigneComand lc) 
{
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
    
            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<LigneComand>(Statics.baseAddress +"updateproductfromcart/lc/"+lc.Idlc+"/product/"+lc.IdProduct+"/qte/"+lc.Qte,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }

        }
        

        public bool deleteLignCommandById(int Idlc)
        {
            try { 
            
                var APIResponse = httpClient.DeleteAsync(Statics.baseAddress + "supprimerLignecommande/" + Idlc);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}