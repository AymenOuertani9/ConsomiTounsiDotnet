using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Sponsor :User
    {

        public string brand { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }


        public Sponsor()
        {

        }

        public Sponsor(string brand, string url, string status)
        {
            this.brand = brand;
            Url = url;
            Status = status;
        }
    }
}