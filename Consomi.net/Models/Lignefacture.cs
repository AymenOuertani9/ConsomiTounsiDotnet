using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Lignefacture
    {
        [JsonProperty("idlig")]
        public int Idlig { get; set; }
        [JsonProperty("idcommand")]
        public int Idcommand { get; set; }
        [JsonProperty("commande")]
        public Command Commande { get; set; }

    }
}