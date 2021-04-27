using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Aisel
    {
		public String name { get; set; }
		public String type { get; set; }
		public int Capacitymax { get; set; }
		public virtual List<Product> products { get; set; }
	}
}