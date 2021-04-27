using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Commentaire
    {
        public int Idcomment { get; set; }
        public string Description { get; set; }
        public int Nblike { get; set; }
        public virtual Publication Publication { get; set; }
        public virtual UserConsomi User { get; set; }

        public DateTime DateTimeOfComment { get; set; }

        public Commentaire()
        {
        }

        public Commentaire(int idcomment, string description, int nblike, Publication publication, UserConsomi user, DateTime dateTimeOfComment)
        {
            Idcomment = idcomment;
            Description = description;
            Nblike = nblike;
            Publication = publication;
            User = user;
            DateTimeOfComment = dateTimeOfComment;
        }
    }
}