using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Evaluation
    {
		public int Rate { get; set; }

		public virtual UserConsomi User { get; set; }
		public virtual Product Product { get; set; }



		public Evaluation()
        {

        }

        public Evaluation(int rate, UserConsomi user, Product product)
        {
            Rate = rate;
            User = user;
            Product = product;
        }
    }
}