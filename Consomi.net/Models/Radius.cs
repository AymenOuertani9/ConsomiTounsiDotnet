using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Radius
    {
		public  int IdRadius { get; set; }
		public  string Name { get; set; }
		public string Type { get; set; }
		public  int Capacitymax { get; set; }

		public virtual List<Product> Products { get; set; }

        public Radius()
        {
        }

        public Radius(int idRadius, string name, string type, int capacitymax, List<Product> products)
        {
            IdRadius = idRadius;
            Name = name;
            Type = type;
            Capacitymax = capacitymax;
            Products = products;
        }
    }
}