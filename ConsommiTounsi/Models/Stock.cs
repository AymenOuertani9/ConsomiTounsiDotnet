using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Stock
    {
        public int id { get; set; }
        public DateTime DateCreation { get; set;  }
        public float quantity { get; set; }
        public virtual List<Command> commande { get; set; }
        public virtual Product product { get; set; }

        public Stock()
        {
        }


    }
}