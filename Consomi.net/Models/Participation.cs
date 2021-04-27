
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Participation
    {

		public float Price { get; set; }

		public DateTime ParticipationDate { get; set; }

		public virtual User User { get; set; }
		public virtual Event Events { get; set; }


        public Participation()
        {
             
        }
        public Participation(float price, DateTime participationDate, User user, Event events)
        {
            Price = price;
            ParticipationDate = participationDate;
            User = user;
            Events = events;
        }
    }
	}