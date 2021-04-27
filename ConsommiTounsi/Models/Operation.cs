using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Operation
    {
		public long NumeroOperation { get; set; }
		public DateTime DateOperation { get; set; }
		public double Montant { get; set; }
		public virtual  Compte Compte { get; set; }


        public Operation()

        {
             
        }
        public Operation(long numeroOperation, DateTime dateOperation, double montant, Compte compte)
        {
            NumeroOperation = numeroOperation;
            DateOperation = dateOperation;
            Montant = montant;
            Compte = compte;
        }
    }
}