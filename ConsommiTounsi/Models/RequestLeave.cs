using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class RequestLeave
    
    {

        public int IdRequestLeave { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public RequestLeaveEtat Etat { get; set; }
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public virtual UserConsomi User  { get; set; }

        public enum RequestLeaveEtat
        {
            accepted,
            refuse,
            in_progress
        }

        public RequestLeave()
        {

        }

        public RequestLeave(int idRequestLeave, DateTime startDate, DateTime endDate, RequestLeaveEtat etat, string description, int viewCount, UserConsomi user)
        {
            IdRequestLeave = idRequestLeave;
            StartDate = startDate;
            EndDate = endDate;
            Etat = etat;
            Description = description;
            ViewCount = viewCount;
            User = user;
        }
    }
}