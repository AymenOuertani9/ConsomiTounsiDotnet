using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class ExchangeRequest
    {

        public int Id { get; set; }
        public  virtual Meeting Requestor { get; set; }
        public virtual Meeting Requested { get; set; }

        public ExchangeStatus Status { get; set; }

        public ExchangeRequest()
        {
        }

        public ExchangeRequest(int id, Meeting requestor, Meeting requested, ExchangeStatus status)
        {
            Id = id;
            Requestor = requestor;
            Requested = requested;
            Status = status;
        }
    }
}