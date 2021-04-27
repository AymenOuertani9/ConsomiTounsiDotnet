using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Consomi.net.Models
{
    public class LigneComand
    {
        [JsonProperty("idlc")]
        public int Idlc { get; set; }

        [JsonProperty("qte")]
        public int Qte { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("cart")]
        public Cart Cart { get; set; }
        
        [JsonProperty("produit")]
        public Product Produit { get; set; }
        [JsonProperty("idcart")]
        public int Idcart { get; set; }
        [JsonProperty("idProduct")]
        public int IdProduct { get; set; }
        //public LigneComand()
        //{

        //}
        //public LigneComand(int idlc, int qte, double price, DateTime date, Cart cart, Product produit)
        //{
        //    Idlc = idlc;
        //    Qte = qte;
        //    Price = price;
        //    Date = date;
        //    Cart = cart;
        //    Produit = produit;
        //}
    }
}