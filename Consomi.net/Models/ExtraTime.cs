using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class ExtraTime
    {
		public int IdExtraTime { get; set; }
		public DateTime dateExtraTima { get; set; }
		public int NbrHour { get; set; }

		public virtual User User { get; set; }

        public ExtraTime()
        {
        }

        public ExtraTime(int idExtraTime, DateTime dateExtraTima, int nbrHour, User user)
        {
            IdExtraTime = idExtraTime;
            this.dateExtraTima = dateExtraTima;
            NbrHour = nbrHour;
            User = user;
        }
    }
}