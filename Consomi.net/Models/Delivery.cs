using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Delivery
    {
        [JsonProperty("idDelivery")]
        public int IdDelivery { get; set; }

        [JsonProperty("shippingCoast")]
        public double ShippingCoast { get; set; }

        [JsonProperty("etat")]
        public object Etat { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("region")]
        public DeliveryRegion Region { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("deliveryman")]
        public object Deliveryman { get; set; }
       
    }
}