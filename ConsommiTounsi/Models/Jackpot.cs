using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Jackpot
    {
        public int IdJack { get; set; }
        public double Total { get; set; }

        public Jackpot()
        {

        }

        public Jackpot(int idJack, double total)
        {
            IdJack = idJack;
            Total = total;
        }


    }
}