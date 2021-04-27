using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Publication
    {
        public int Idpub { get; set; }
        public string Topic { get; set; }
        public DateTime DateTimeOfPublication { get; set; }
        public string ImageUrl { get; set; }
        public int RatingPoints { get; set; }


        public int Evaluation { get; set; }

        public virtual List<Commentaire> Commentaire { get; set; }

        public virtual List<Rating> Ratings{ get; set; }
        public virtual UserConsomi PublicationUser { get; set; }
         public virtual List<Commentaire> CommentList { get; set; }

        public Publication()
        {
        }

        public Publication(int idpub, string topic, DateTime dateTimeOfPublication, string imageUrl, int ratingPoints, int evaluation, List<Commentaire> commentaire, List<Rating> ratings, UserConsomi publicationUser, List<Commentaire> commentList)
        {
            Idpub = idpub;
            Topic = topic;
            DateTimeOfPublication = dateTimeOfPublication;
            ImageUrl = imageUrl;
            RatingPoints = ratingPoints;
            Evaluation = evaluation;
            Commentaire = commentaire;
            Ratings = ratings;
            PublicationUser = publicationUser;
            CommentList = commentList;
        }
    }
}