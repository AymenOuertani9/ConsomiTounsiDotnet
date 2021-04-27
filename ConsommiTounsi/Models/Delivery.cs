using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Delivery
    {

		public int IdDelivery { get; set; }
		public float ShippingCoast { get; set; }
		public DeliveryEtat Etat { get; set; }
		public string Description { get; set; }
		public string Adress { get; set; }
		public string City { get; set; }
		public DeliveryRegion Region { get; set; }
		public int Rate { get; set; }
		public float Carnetcarburant { get; set; }
		public virtual Bill Bill { get; set; }

        public Delivery()
        {
        }
            public Delivery(int idDelivery, float shippingCoast, DeliveryEtat etat, string description, string adress, string city, DeliveryRegion region, int rate, float carnetcarburant, Bill bill)
        {
            IdDelivery = idDelivery;
            ShippingCoast = shippingCoast;
            Etat = etat;
            Description = description;
            Adress = adress;
            City = city;
            Region = region;
            Rate = rate;
            Carnetcarburant = carnetcarburant;
            Bill = bill;
        }
    }
}