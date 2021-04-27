using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Repair
    {
        public int Idrepair { get; set; }
        public float Coast { get; set; }
        public string Description { get; set; }

        public Repair()
        {
        }

        public Repair(int idrepair, float coast, string description)
        {
            Idrepair = idrepair;
            Coast = coast;
            Description = description;
        }
    }
}