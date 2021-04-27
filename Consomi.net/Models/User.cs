
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class User
    {

        [JsonProperty("iduser")]
        public int Iduser { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("nbrpoint")]
        public int Nbrpoint { get; set; }
        [JsonProperty("pays")]
        public string Pays { get; set; }
        [JsonProperty("picture")]
        public string Picture { get; set; }
        [JsonProperty("pointconverti")]
        public double Pointconverti { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("adress")]
        public string Adress { get; set; }
       
        [JsonProperty("role")]
        public Role Role { get; set; }
        [JsonProperty("contrat")]
        public Contrat Contrat { get; set; }
        [JsonProperty("tel")]
        public int Tel { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
        public bool Connected { get; set; }
		public bool Active { get; set; }
        [JsonProperty("dateCreation")]
        public string DateCreation { get; set; }

        public float AccBalance { get; set; }
	    public float SalaireClient { get; set; }
	    public string Gender { get; set; }
	    public int Age { get; set; }



       
        public virtual List<Claim> Claims { get; set; }
		public virtual List<Stock> Stocks { get; set; }
		public virtual List<Donation> Donation { get; set; }
        [JsonProperty("carts")]
        public List<Cart> Carts { get; set; }
		public virtual List<Participation> Participations { get; set; }
		public virtual List<Commentaire> Commentaire { get; set; }
		public virtual List<Rating> Rating { get; set; }
		
		public virtual DeliveryRegion Workzone { get; set; }
		public bool Availability { get; set; }
		public float Premium { get; set; }
		public float TotHour { get; set; }
		public virtual UserEtat Etat { get; set; }
		public virtual List<ExtraTime> EcxtraTime { get; set; }
		public virtual List<RequestLeave> RequestLeave { get; set; }
		public virtual List<Delivery> Delivery { get; set; }
		public virtual List<Claim> Claim { get; set; }
		public virtual List<Notification> Notification { get; set; }
		public virtual List<Sponsoring> Sponsoring { get; set; }
		public virtual List<Evaluation> Evaluations { get; set; }
		public virtual  List<Event> Events { get; set; }
		//New 
		public virtual List<Meeting> Meetings { get; set; }

      

        //public UserConsomi(int iduser, string lastname, string username, string adress, string login, string password, int nbrpoint, string tel, string email, bool connected, bool active, DateTime dateCreation, string picture, float accBalance, float salaireClient, string gender, int age, double pointconverti, List<Role> role, Contrat contrat, List<Claim> claims, List<Stock> stocks, List<Donation> donation, List<Cart> carts, List<Participation> participations, List<Commentaire> commentaire, List<Rating> rating, Pays pays, DeliveryRegion workzone, bool availability, float premium, float totHour, UserEtat etat, List<ExtraTime> ecxtraTime, List<RequestLeave> requestLeave, List<Delivery> delivery, List<Claim> claim, List<Notification> notification, List<Sponsoring> sponsoring, List<Evaluation> evaluations, List<Event> events, List<Meeting> meetings)
        //{
        //    Iduser = iduser;
        //    Lastname = lastname;
        //    Username = username;
        //    Adress = adress;
        //    Login = login;
        //    Password = password;
        //    Nbrpoint = nbrpoint;
        //    Tel = tel;
        //    Email = email;
        //    Connected = connected;
        //    Active = active;
        //    DateCreation = dateCreation;
        //    Picture = picture;
        //    AccBalance = accBalance;
        //    SalaireClient = salaireClient;
        //    Gender = gender;
        //    Age = age;
        //    Pointconverti = pointconverti;
        //    Role = role;
        //    Contrat = contrat;
        //    Claims = claims;
        //    Stocks = stocks;
        //    Donation = donation;
        //    Carts = carts;
        //    Participations = participations;
        //    Commentaire = commentaire;
        //    Rating = rating;
        //    Pays = pays;
        //    Workzone = workzone;
        //    Availability = availability;
        //    Premium = premium;
        //    TotHour = totHour;
        //    Etat = etat;
        //    EcxtraTime = ecxtraTime;
        //    RequestLeave = requestLeave;
        //    Delivery = delivery;
        //    Claim = claim;
        //    Notification = notification;
        //    Sponsoring = sponsoring;
        //    Evaluations = evaluations;
        //    Events = events;
        //    Meetings = meetings;
        //}
    }



}