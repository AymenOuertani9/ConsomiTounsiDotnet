using ConsommiTounsi.Models.KeedoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Donation
    {
		public int IdDonation { get; set; }
		public DateTime Date { get; set; }
		public float Amount { get; set; }
		public virtual Event Events { get; set; }

		public virtual UserConsomi User { get; set; }

        public Donation()
        {

        }
        public Donation(int idDonation, DateTime date, float amount, Event events, UserConsomi user)
        {
            IdDonation = idDonation;
            Date = date;
            Amount = amount;
            Events = events;
            User = user;
        }
    }
}