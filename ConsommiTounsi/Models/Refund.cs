using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Refund
    {
        public int idrefund { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }

        public DateTime Date { get; set; }

        public Refund()
        {
        }

        public Refund(int idrefund, string description, float amount, DateTime date)
        {
            this.idrefund = idrefund;
            Description = description;
            Amount = amount;
            Date = date;
        }
    }
}