using ConsommiTounsi.Models.KeedoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Notification
    {

		public int IddNotif {get;set;}

		public DateTime Time { get; set; }
		public string Status { get; set; }

		public string Target { get; set; }


		public virtual Event Events { get; set; }

		public  virtual UserConsomi User { get; set; }


		public Notification()
        {

        }

        public Notification(int iddNotif, DateTime time, string status, string target, Event events, UserConsomi user)
        {
            IddNotif = iddNotif;
            Time = time;
            Status = status;
            Target = target;
            Events = events;
            User = user;
        }
    }
}