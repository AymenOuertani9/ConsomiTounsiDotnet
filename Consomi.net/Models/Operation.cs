using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Operation
    {
		public long NumeroOperation { get; set; }
		public string DateOperation { get; set; }
		public double Montant { get; set; }
		public virtual  Compte Compte { get; set; }


        public Operation()

        {
             
        }
       
    }
}