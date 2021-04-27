using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{


	using System;
	using System.Collections.Generic;

    namespace KeedoApp.Models
    {



        public class Event
        {

            public virtual List<Donation> Donations { get; set; }
            public virtual List<Advertisement> Advertisements { get; set; }
            public virtual Jackpot Jackpot { get; set; }
            public virtual List<Participation> Participations { get; set; }
            public virtual List<Notification> Notifications { get; set; }

            public virtual List<Meeting> Meeting { get; set; }


            public virtual List<Sponsoring> Sponsoring { get; set; }

            public virtual UserConsomi ManagerEvent { get; set; }


            public int IdEvenement { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public DateTime Hour { get; set; }
            public string Description { get; set; }
            public bool Status { get; set; }
            public string Address { get; set; }
            public byte[] Image { get; set; }
            public float TicketPrice { get; set; }
            public float CollAmount { get; set; }
            public int ParticipantsNbr { get; set; }
            public int PlacesNbr { get; set; }
            public bool EarlyParticipants { get; set; }
            public int NbrTicketEarlyParticipants { get; set; }
            public int Views { get; set; }
            public float DiscountPercentage { get; set; }
            public CategoryEvent Category { get; set; }


            public Event()
            {

            }
            public Event(List<Donation> donations, List<Advertisement> advertisements, Jackpot jackpot, List<Participation> participations, List<Notification> notifications, List<Meeting> meeting, List<Sponsoring> sponsoring, UserConsomi managerEvent, int idEvenement, string title, DateTime date, DateTime hour, string description, bool status, string address, byte[] image, float ticketPrice, float collAmount, int participantsNbr, int placesNbr, bool earlyParticipants, int nbrTicketEarlyParticipants, int views, float discountPercentage, CategoryEvent category)
            {
                Donations = donations;
                Advertisements = advertisements;
                Jackpot = jackpot;
                Participations = participations;
                Notifications = notifications;
                Meeting = meeting;
                Sponsoring = sponsoring;
                ManagerEvent = managerEvent;
                IdEvenement = idEvenement;
                Title = title;
                Date = date;
                Hour = hour;
                Description = description;
                Status = status;
                Address = address;
                Image = image;
                TicketPrice = ticketPrice;
                CollAmount = collAmount;
                ParticipantsNbr = participantsNbr;
                PlacesNbr = placesNbr;
                EarlyParticipants = earlyParticipants;
                NbrTicketEarlyParticipants = nbrTicketEarlyParticipants;
                Views = views;
                DiscountPercentage = discountPercentage;
                Category = category;
            }
        }
    }
}

		
		