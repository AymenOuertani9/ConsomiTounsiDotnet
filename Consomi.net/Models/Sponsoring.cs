
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Sponsoring
    {
		//	private SponsoringPk sponsoringPk;

		public string ProductName { get; set; }
		public int ProductQuantity { get; set; }
		public float PriceProduct { get; set; }
		public TypeSupport TypeSupport { get; set; }
		public DateTime DateSponsoring { get; set; }
		public string Status { get; set; }


		public virtual User Sponsor { get; set; }

		public virtual Event Events { get; set; }

        public Sponsoring()
        {
        }

        public Sponsoring(string productName, int productQuantity, float priceProduct, TypeSupport typeSupport, DateTime dateSponsoring, string status, User sponsor, Event events)
        {
            ProductName = productName;
            ProductQuantity = productQuantity;
            PriceProduct = priceProduct;
            TypeSupport = typeSupport;
            DateSponsoring = dateSponsoring;
            Status = status;
            Sponsor = sponsor;
            Events = events;
        }
    }
	}