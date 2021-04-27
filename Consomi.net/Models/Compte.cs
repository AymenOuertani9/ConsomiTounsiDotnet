using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Compte
    {
        [JsonProperty("idcmpt")]
        public int Idcmpt { get; set; }

        [JsonProperty("codeCompte")]
        public string CodeCompte { get; set; }
        [ DataType(DataType.Date)]
        [JsonProperty("dateCreation")]
        public DateTime DateCreation { get; set; }

        [JsonProperty("solde")]
        public double Solde { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("iduser")]
        public int Iduser { get; set; }
        [JsonProperty("operations")]
        public List<Operation> Operations;


    }
}