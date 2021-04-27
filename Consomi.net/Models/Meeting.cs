﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Meeting
    {
		public int IdMeeting { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime Time { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime CanceledAt { get; set; }

		public virtual User Canceler { get; set; }
		public AppointmentStatus Status { get; set; }
		public string TypeMeeting { get; set; }
		public string Description { get; set; }



		public virtual User Users { get; set; }



		public virtual Event Events { get; set; }

        public Meeting()
        {
        }

        public Meeting(int idMeeting, DateTime startDate, DateTime time, DateTime createdAt, DateTime canceledAt, User canceler, AppointmentStatus status, string typeMeeting, string description, User Users, Event events)
        {
            IdMeeting = idMeeting;
            StartDate = startDate;
            Time = time;
            CreatedAt = createdAt;
            CanceledAt = canceledAt;
            Canceler = canceler;
            Status = status;
            TypeMeeting = typeMeeting;
            Description = description;
            this.Users = Users;
            Events = events;
        }
    }
}