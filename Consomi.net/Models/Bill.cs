using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Bill
    {
        public int IdBill { get; set; }

		public int NumBill { get; set; }
		public double Totalfinal { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datereglement { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datebill { get; set; }
		public virtual TypeFacture Typeofbill { get; set; }
        [JsonProperty("idDelivery")]
        public int IdDelivery { get; set; }

        [JsonProperty("delivery")]
        public Delivery Delivery { get; set; }
        [JsonProperty("idlig")]
        public int Idlig { get; set; }
        [JsonProperty("lignefacture")]
        public Lignefacture Lignefacture { get; set; }
        public Bill()
        {
        }

       

    }
}