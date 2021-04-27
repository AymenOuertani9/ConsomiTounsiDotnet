using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Rating
    {
		public int Idrating { get; set; }
		public int Nbretoile { get; set; }
		//priva
		//te int like;

		public virtual UserConsomi User { get; set; }
		public virtual Publication Publication { get; set; }

        public Rating()
        {
        }

        public Rating(int idrating, int nbretoile, UserConsomi user, Publication publication)
        {
            Idrating = idrating;
            Nbretoile = nbretoile;
            User = user;
            Publication = publication;
        }
    }
}