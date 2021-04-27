using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class CurrencyConversionBean
    {
		public int Id { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public decimal ConversionMultiple { get; set; }
		public decimal Amount { get; set; }
		public decimal TotalCalculatedAmount { get; set; }
		public int Port { get; set; }
		public  virtual Command Command { get; set; }

        public CurrencyConversionBean()
        {
        }

        public CurrencyConversionBean(int id, string from, string to, decimal conversionMultiple, decimal amount, decimal totalCalculatedAmount, int port, Command command)
        {
            Id = id;
            From = from;
            To = to;
            ConversionMultiple = conversionMultiple;
            Amount = amount;
            TotalCalculatedAmount = totalCalculatedAmount;
            Port = port;
            Command = command;
        }
    }
}