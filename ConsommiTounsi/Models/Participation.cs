using ConsommiTounsi.Models.KeedoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Participation
    {

		public float Price { get; set; }

		public DateTime ParticipationDate { get; set; }

		public virtual UserConsomi User { get; set; }
		public virtual Event Events { get; set; }


        public Participation()
        {
             
        }
        public Participation(float price, DateTime participationDate, UserConsomi user, Event events)
        {
            Price = price;
            ParticipationDate = participationDate;
            User = user;
            Events = events;
        }
    }
	}