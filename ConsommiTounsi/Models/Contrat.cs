using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Contrat
    {
		public int Idcontrat { get; set; }
		public float Salary { get; set; }
		public DateTime DateDebut { get; set; }
		public DateTime DateFin { get; set; }
		public ContratType Typecontrat { get; set; }
		public virtual UserConsomi User { get; set; }


        public Contrat()
        {

        }
        public Contrat(int idcontrat, float salary, DateTime dateDebut, DateTime dateFin, ContratType typecontrat, UserConsomi user)
        {
            Idcontrat = idcontrat;
            Salary = salary;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Typecontrat = typecontrat;
            User = user;
        }
    }
}