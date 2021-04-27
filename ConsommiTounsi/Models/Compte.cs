using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Compte
    {
		public int Idcmpt { get; set; }
		public string CodeCompte { get; set; }
		public  DateTime DateCreation { get; set; }
		public double Solde { get; set; }
		public virtual UserConsomi User { get; set; }
		public virtual List<Operation> Operations { get; set; }


        public Compte()
        {

        }
        public Compte(int idcmpt, string codeCompte, DateTime dateCreation, double solde, UserConsomi user, List<Operation> operations)
        {
            Idcmpt = idcmpt;
            CodeCompte = codeCompte;
            DateCreation = dateCreation;
            Solde = solde;
            User = user;
            Operations = operations;
        }
    }
}