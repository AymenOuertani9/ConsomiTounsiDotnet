using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class CommandProduct
    {
		public int Idcomm { get; set; }
		public DateTime DateDelivery { get; set; }
		public float Price { get; set; }
		public virtual List<Product> Products { get; set; }

        public CommandProduct()
        {
        }

        public CommandProduct(int idcomm, DateTime dateDelivery, float price, List<Product> products)
        {
            Idcomm = idcomm;
            DateDelivery = dateDelivery;
            Price = price;
            Products = products;
        }
    }
}