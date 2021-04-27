using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Bill
    {
        public int IdBill { get; set; }

		public int NumBill { get; set; }
		public double Totalfinal { get; set; }
		public DateTime Datereglement { get; set; }
		public DateTime Datebill { get; set; }
		public virtual TypeFacture Typeofbill { get; set; }
		public virtual Delivery Delivery { get; set; }
        public Bill()
        {
        }

        public Bill(int idBill, int numBill, double totalfinal, DateTime datereglement, DateTime datebill, TypeFacture typeofbill, Delivery delivery) 
        {
            NumBill = numBill;
            Totalfinal = totalfinal;
            Datereglement = datereglement;
            Datebill = datebill;
            Typeofbill = typeofbill;
            Delivery = delivery;
        }

    }
}