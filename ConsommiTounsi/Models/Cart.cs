using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Cart
    {
		public int Idcart { get; set; }
		public double Subtotal { get; set; }

		public string  Currency { get; set; }
		public virtual EtatCart Etatcart { get; set; }

		public virtual UserConsomi User { get; set; }
		public virtual Command Command { get; set; }
		public virtual List<LigneComand> Lignescmd { get; set; }

        public Cart()
        {
        }

        public Cart(int idcart, double subtotal, string currency, EtatCart etatcart, UserConsomi user, Command command, List<LigneComand> lignescmd)
        {
            Idcart = idcart;
            Subtotal = subtotal;
            Currency = currency;
            Etatcart = etatcart;
            User = user;
            Command = command;
            Lignescmd = lignescmd;
        }



    }
}