using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class AdsView
    {
	public float Total_Num { get; set; }
	public float Total_man { get; set; }
	public float Total_Woman { get; set; }
	public List<int> age { get; set; }
	public virtual Ads ads { get; set; }
	}
}