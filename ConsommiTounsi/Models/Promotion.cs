using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Promotion
    {

		public int IdPromotion { get; set; }
		public string Libelle { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int Description { get; set; }
		public int Percentage { get; set; }
		public virtual Product Products { get; set; }

        public Promotion()
        {
        }

        public Promotion(int idPromotion, string libelle, DateTime startDate, DateTime endDate, int description, int percentage, Product products)
        {
            IdPromotion = idPromotion;
            Libelle = libelle;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            Percentage = percentage;
            Products = products;
        }
    }
}