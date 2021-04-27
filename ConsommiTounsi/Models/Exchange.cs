using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Exchange
    {
        public int Idexchange { get; set; }
        public string Type { get; set; }

        public Exchange()
        {
        }

        public Exchange(int idexchange, string type)
        {
            Idexchange = idexchange;
            Type = type;
        }
    }
}