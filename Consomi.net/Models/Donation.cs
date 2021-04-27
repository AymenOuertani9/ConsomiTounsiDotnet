
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Donation
    {
		public int IdDonation { get; set; }
		public DateTime Date { get; set; }
		public float Amount { get; set; }
		public virtual Event Events { get; set; }

		public virtual User User { get; set; }

        public Donation()
        {

        }
        public Donation(int idDonation, DateTime date, float amount, Event events, User user)
        {
            IdDonation = idDonation;
            Date = date;
            Amount = amount;
            Events = events;
            User = user;
        }
    }
}