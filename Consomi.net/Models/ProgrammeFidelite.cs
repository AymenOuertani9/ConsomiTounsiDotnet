using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class ProgrammeFidelite
    {
        [JsonProperty("idfidilite")]
        public int Idfidilite { get; set; }

        [JsonProperty("type")]
        public Typefidelite Type { get; set; }
        [JsonProperty("command")]
        public  Command Command { get; set; }
        [JsonProperty("idcommand")]
        public int Idcommand { get; set; }
        public ProgrammeFidelite()
        {

        }

        
    }
}