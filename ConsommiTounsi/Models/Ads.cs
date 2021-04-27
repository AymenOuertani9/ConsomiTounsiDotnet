using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Ads
    {
		public int idAds { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
		public DateTime dateCreation { get; set; }
		public String mediaType { get; set; }
		public String madia { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
		public DateTime startDate { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
		public DateTime finishDate { get; set; }
		public String target { get; set; }
		public int targetView_tot { get; set; }
		public virtual Product product { get; set; }
	}
}