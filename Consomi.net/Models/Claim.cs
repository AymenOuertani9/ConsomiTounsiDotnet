﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Claim
    {
		public int Idclaim { get; set; }
		public string Description { get; set; }
		public DateTime DateClaim { get; set; }
		public ClaimEtat Etat { get; set; }
		public float Amount { get; set; }

		public virtual User User { get; set; }

		public virtual Product Product { get; set; }

        public Claim()
        {

        }
        public Claim(int idclaim, string description, DateTime dateClaim, ClaimEtat etat, float amount, User user, Product product)
        {
            Idclaim = idclaim;
            Description = description;
            DateClaim = dateClaim;
            Etat = etat;
            Amount = amount;
            User = user;
            Product = product;
        }
    }
}