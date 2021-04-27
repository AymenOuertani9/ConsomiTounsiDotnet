using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Cart
    {

        
            [JsonProperty("idcart")]
            public int Idcart { get; set; }

            [JsonProperty("subtotal")]
            public double Subtotal { get; set; }

            [JsonProperty("currency")]
            public string Currency { get; set; }

            [JsonProperty("etatcart")]
            public string Etatcart { get; set; }

            [JsonProperty("user")]
            public  User user { get; set; }
            [JsonProperty("iduser")]
            public int Iduser { get; set; }
            [JsonProperty("lignescmd")]
            public IEnumerable<LigneComand> Lignescmd { get; set; }
        }


        //public Cart()
        //{
        //}

        //public Cart(int idcart, double subtotal, string currency, EtatCart etatcart, UserConsomi user, Command command, ICollection<LigneComand> lignescmd)
        //{
        //    Idcart = idcart;
        //    Subtotal = subtotal;
        //    Currency = currency;
        //    Etatcart = etatcart;
        //    User = user;
        //    Command = command;
        //    Lignescmd = lignescmd;
        //}



    }
