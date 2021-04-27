using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Sponsor :UserConsomi
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