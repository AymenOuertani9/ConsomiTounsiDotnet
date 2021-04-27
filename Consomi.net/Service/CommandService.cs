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
    public class CommandService
    {
        HttpClient httpClient;
        public CommandService()
        {

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Statics.baseAddress);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer{0}", Statics._AccessToken));

        }
        public IEnumerable<Command> GetAll()
        {

            var tokenResponse = httpClient.GetAsync(Statics.baseAddress + "getorders").Result;

            if (tokenResponse.IsSuccessStatusCode)
            {
                var lc = tokenResponse.Content.ReadAsAsync<IEnumerable<Command>>().Result;
                // string responseBody =  tokenResponse.Content.ToString();
                return lc;
            }

            return new List<Command>();
        }

        public Command Getmaxnum()
        {

            Command c = null;

            var response = httpClient.GetAsync(Statics.baseAddress + "getmaxnumorder").Result;

            if (response.IsSuccessStatusCode)
            {
                var cmd = response.Content.ReadAsAsync<Command>().Result;

                return cmd;
            }


            return c;
        }
        public Boolean Add(Command comand)
        {

            try


            {
                var APIResponse = httpClient.PostAsJsonAsync<LigneComand>(Statics.baseAddress + "/passercommand/cart/" + comand.Idcart + "/" + comand.IdDelivery, null
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
        public IEnumerable<Delivery> getAlldelivery()
        {

            var response = httpClient.GetAsync(Statics.baseAddress + "getdeliv").Result;

            if (response.IsSuccessStatusCode)
            {
                var deliverys = response.Content.ReadAsAsync<IEnumerable<Delivery>>().Result;

                return deliverys;
            }

            return new List<Delivery>();

        }
        public Command GetById(int idc)
        {

            Command c = null;

            var response = httpClient.GetAsync(Statics.baseAddress + "getorder/" + idc).Result;

            if (response.IsSuccessStatusCode)
            {
                var cmd = response.Content.ReadAsAsync<Command>().Result;

                return cmd;
            }


            return c;

        }
        public Compte GetcompteByIduser(int iduser)
        {

            Compte c = null;

            var response = httpClient.GetAsync(Statics.baseAddress + "getcomptebyid/" + iduser).Result;

            if (response.IsSuccessStatusCode)
            {
                var compte = response.Content.ReadAsAsync<Compte>().Result;

                return compte;
            }


            return c;

        }
        public Command GetcommandByIduser(int iduser)
        {

            Command c = null;

            var response = httpClient.GetAsync(Statics.baseAddress + "displayorderhistoryofeachuser/" + iduser).Result;

            if (response.IsSuccessStatusCode)
            {
                var Command = response.Content.ReadAsAsync<Command>().Result;

                return Command;
            }


            return c;

        }
        public bool deleteCommandById(int Idc)
        {
            try
            {

                var APIResponse = httpClient.DeleteAsync(Statics.baseAddress + "deletecmd/" + Idc);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCommandByDate(DateTime date)
        {
            try
            {

                var APIResponse = httpClient.DeleteAsync(Statics.baseAddress + "cleanup");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CancelOrder(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);

            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Command>(Statics.baseAddress + "cancel/" + c.Idcommand,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool updatestatus(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);

            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Command>(Statics.baseAddress + "updatestatus/" + c.Idcommand,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool updatestatusbydelivery(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);

            try
            {
                var APIResponse = httpClient.PutAsJsonAsync<Command>(Statics.baseAddress + "/updatestatusbydelivred/command/" + c.Idcommand,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool payin3months(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "payin3months/cmd/" + c.Idcommand + "/compte/" + co.Idcmpt + "/" + 2;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool payin6months(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "payin6months/cmd/" + c.Idcommand + "/compte/" + co.Idcmpt + "/" + 2;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool payin9months(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "payin9months/cmd/" + c.Idcommand + "/compte/" + co.Idcmpt + "/" + 2;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool payin12months(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "payin12months/cmd/" + c.Idcommand + "/compte/" + co.Idcmpt + "/" + 2;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool remboursercommand(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "/refund/compte1/" + co.Idcmpt + "/compte2/" + 2 + "/command/" + c.Idcommand;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool payerbytransfer(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "/paybytransfer/command/" + c.Idcommand + "/compteclient/" + co.Idcmpt + "/compteresponsable/" + 2;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool payamounttoseller(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "/payamounttoseller/compteresponsable/" + co.Idcmpt + "/command/" + c.Idcommand;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

                System.Diagnostics.Debug.WriteLine(APIResponse.Result);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool paybyfidelity(Command c)
        {
            //System.Diagnostics.Debug.WriteLine(lc.Produit.IdProduct);
            Compte co = this.GetcompteByIduser(1);
            try
            {
                var url = Statics.baseAddress + "/paymentbyfidelite/cmd/" + c.Idcommand + "/" + co.Idcmpt;
                var APIResponse = httpClient.PutAsync(url,
                 null).ContinueWith(postTask => postTask.Result.EnsureSuccessStatusCode());

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