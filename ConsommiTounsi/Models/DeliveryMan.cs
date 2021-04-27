using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class DeliveryMan
    {
        public int Iddeliveryman { get; set; }
        public string Workzone { get; set; }
        public bool Availability { get; set; }
        public int Totnbdelivery { get; set; }
        public float Premium { get; set; }

        public virtual List<RequestLeave> Requestleave { get; set; }
        public virtual List<ExtraTime> Extratimes { get; set; }


        public DeliveryMan()
        {

        }
        public DeliveryMan(int iddeliveryman, string workzone, bool availability, int totnbdelivery, float premium, List<RequestLeave> requestleave, List<ExtraTime> extratimes)
        {
            Iddeliveryman = iddeliveryman;
            Workzone = workzone;
            Availability = availability;
            Totnbdelivery = totnbdelivery;
            Premium = premium;
            Requestleave = requestleave;
            Extratimes = extratimes;
        }
    }
}