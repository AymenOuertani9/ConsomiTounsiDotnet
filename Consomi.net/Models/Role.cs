using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Role
    {
        [JsonProperty("idRole")]
        public int IdRole { get; set; }
        public string Description { get; set; }
        [JsonProperty("type")]
        public  Roletype Type { get; set; }

        public Role()
        {

        }

       
    }
}