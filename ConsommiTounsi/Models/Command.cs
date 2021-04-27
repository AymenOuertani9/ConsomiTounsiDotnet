using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Command
    {
		public int Idcommand { get; set; }

		public double Price { get; set; }
		public int Paymentterm { get; set; }
		public string Currency { get; set; }

		public string Method { get; set; }
		public string Intent { get; set; }

		public string Description { get; set; }
		public int Reduction { get; set; }
		public int Increase { get; set; }
		public DateTime DateCreation { get; set; }
		public DateTime DateSend { get; set; }
		public Etat Etat { get; set; }
		public int Numcommand { get; set; }
		public int Tva { get; set; }
		public virtual ModePayement Payement { get; set; }
		public bool Validpayement { get; set; }


		public virtual Cart Cart { get; set; }

		public virtual ProgrammeFidelite Programmefidel { get; set; }

		public virtual Delivery Delivery { get; set; }
		public virtual List<Remarque> Remarques { get; set; }

        public Command()
        {
        }

        public Command(int idcommand, double price, int paymentterm, string currency, string method, string intent, string description, int reduction, int increase, DateTime dateCreation, DateTime dateSend, Etat etat, int numcommand, int tva, ModePayement payement, bool validpayement, Cart cart, ProgrammeFidelite programmefidel, Delivery delivery, List<Remarque> remarques)
        {
            Idcommand = idcommand;
            Price = price;
            Paymentterm = paymentterm;
            Currency = currency;
            Method = method;
            Intent = intent;
            Description = description;
            Reduction = reduction;
            Increase = increase;
            DateCreation = dateCreation;
            DateSend = dateSend;
            Etat = etat;
            Numcommand = numcommand;
            Tva = tva;
            Payement = payement;
            Validpayement = validpayement;
            Cart = cart;
            Programmefidel = programmefidel;
            Delivery = delivery;
            Remarques = remarques;
        }
    }
}