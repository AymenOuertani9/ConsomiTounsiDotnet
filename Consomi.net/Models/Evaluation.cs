using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Evaluation
    {
		public int Rate { get; set; }

		public virtual User User { get; set; }
		public virtual Product Product { get; set; }



		public Evaluation()
        {

        }

        public Evaluation(int rate, User user, Product product)
        {
            Rate = rate;
            User = user;
            Product = product;
        }
    }
}