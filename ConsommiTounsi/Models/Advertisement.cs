using ConsommiTounsi.Models.KeedoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
	public class Advertisement
	{
      

        public int IdAd { get; set; }
		public string Name { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int ViewCount { get; set; }

		public string Description { get; set; }
		public string Ad { get; set; }

		public byte[] Image { get; set; }
		public virtual Event Events { get; set; }
		public float Cost { get; set; }


        public Advertisement()
        {
        }

        public Advertisement(int idAd, string name, DateTime startDate, DateTime endDate, int viewCount, string description, string ad, byte[] image, Event events, float cost)
        {
            IdAd = idAd;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            ViewCount = viewCount;
            Description = description;
            Ad = ad;
            Image = image;
            Events = events;
            Cost = cost;
        }
    }
}