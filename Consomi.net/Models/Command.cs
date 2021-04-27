using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Command
    {
        [JsonProperty("idcommand")]
        public int Idcommand { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("paymentterm")]
        public int Paymentterm { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("reduction")]
        public int Reduction { get; set; }

        [JsonProperty("increase")]
        public int Increase { get; set; }
        [DataType(DataType.Date)]
        [JsonProperty("dateCreation")]
        public DateTime DateCreation { get; set; }
        [DataType(DataType.Date)]
        [JsonProperty("dateSend")]
        public DateTime DateSend { get; set; }

        [JsonProperty("etat")]
        public Etat Etat { get; set; }

        [JsonProperty("numcommand")]
        public int Numcommand { get; set; }

        [JsonProperty("tva")]
        public int Tva { get; set; }

        [JsonProperty("payement")]
        public ModePayement Payement { get; set; }

        [JsonProperty("validpayement")]
        public bool Validpayement { get; set; }
        [JsonProperty("idcart")]
        public int Idcart { get; set; }
        [JsonProperty("cart")]
        public  Cart Cart { get; set; }

        [JsonProperty("idcmpt")]
        public int Idcmpt { get; set; }
        [JsonProperty("compte")]
        public Compte Compte;
        [JsonProperty("idDelivery")]
        public int IdDelivery { get; set; }

        [JsonProperty("delivery")]
        public  Delivery Delivery { get; set; }
		public  List<Remarque> Remarques { get; set; }

        public Command()
        {
        }

        //public Command(int idcommand, double price, int paymentterm, string currency, string method, string intent, string description, int reduction, int increase, DateTime dateCreation, DateTime dateSend, Etat etat, int numcommand, int tva, ModePayement payement, bool validpayement, Cart cart, ProgrammeFidelite programmefidel, Delivery delivery, List<Remarque> remarques)
        //{
        //    Idcommand = idcommand;
        //    Price = price;
        //    Paymentterm = paymentterm;
        //    Currency = currency;
        //    Method = method;
        //    Intent = intent;
        //    Description = description;
        //    Reduction = reduction;
        //    Increase = increase;
        //    DateCreation = dateCreation;
        //    DateSend = dateSend;
        //    Etat = etat;
        //    Numcommand = numcommand;
        //    Tva = tva;
        //    Payement = payement;
        //    Validpayement = validpayement;
        //    Cart = cart;
        //    Programmefidel = programmefidel;
        //    Delivery = delivery;
        //    Remarques = remarques;
        //}
    }
}