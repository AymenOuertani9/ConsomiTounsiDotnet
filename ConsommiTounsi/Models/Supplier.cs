using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Supplier
    {
		public DateTime DateCreation { get; set; }
		public String Name { get; set; }
		public String product { get; set; }
		public float coast { get; set; }
		public virtual List<supplying> supplying { get; set; }
	}
}