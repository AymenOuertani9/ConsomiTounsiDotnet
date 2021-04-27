using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class ExtraTime
    {
		public int IdExtraTime { get; set; }
		public DateTime dateExtraTima { get; set; }
		public int NbrHour { get; set; }

		public virtual UserConsomi User { get; set; }

        public ExtraTime()
        {
        }

        public ExtraTime(int idExtraTime, DateTime dateExtraTima, int nbrHour, UserConsomi user)
        {
            IdExtraTime = idExtraTime;
            this.dateExtraTima = dateExtraTima;
            NbrHour = nbrHour;
            User = user;
        }
    }
}