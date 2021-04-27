using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class ExchangeValue
    {
		public int Id { get; set; }
		public string From { get; set; }
		public string T { get; set; }
		public decimal ConversionMultiple { get; set; }
		public decimal Quantity { get; set; }
		public decimal TotalCalculatedAmount { get; set; }
		public decimal Your_Amount { get; set; }
		public int Port { get; set; }

        public ExchangeValue()
        {
        }

        public ExchangeValue(int id, string from, string t, decimal conversionMultiple, decimal quantity, decimal totalCalculatedAmount, decimal your_Amount, int port)
        {
            Id = id;
            From = from;
            T = t;
            ConversionMultiple = conversionMultiple;
            Quantity = quantity;
            TotalCalculatedAmount = totalCalculatedAmount;
            Your_Amount = your_Amount;
            Port = port;
        }
    }
}