using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class supplying
    {
		private DateTime DateCreation { get; set; }
		private float quantity { get; set; }
		private float tot_coast { get; set; }
		private DateTime d_arrivale { get; set; }
		public virtual Supplier supplier { get; set; }
		public virtual Product product { get; set; }
	}
}