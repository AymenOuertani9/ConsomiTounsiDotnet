using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class ConfirmationToken
    {
        public int Id { get; set; }

        public string Token { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiresAt { get; set; }

        public DateTime ConfirmedAt { get; set; }


        public virtual User User { get; set; }

        public ConfirmationToken()
        {
        }

        public ConfirmationToken(int id, string token, DateTime createdAt, DateTime expiresAt, DateTime confirmedAt, User user)
        {
            Id = id;
            Token = token;
            CreatedAt = createdAt;
            ExpiresAt = expiresAt;
            ConfirmedAt = confirmedAt;
            User = user;
        }
    }
}