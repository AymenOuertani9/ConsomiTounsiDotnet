using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class LigneComand
    {
		public int Idlc { get; set; }
		public int Qte { get; set; }

		public double Pice { get; set; }

		public DateTime Date { get; set; }

		public virtual Cart Cart { get; set; }

		public virtual Product Produit { get; set; }


        public LigneComand()
        {

        }
        public LigneComand(int idlc, int qte, double pice, DateTime date, Cart cart, Product produit)
        {
            Idlc = idlc;
            Qte = qte;
            Pice = pice;
            Date = date;
            Cart = cart;
            Produit = produit;
        }
    }
}