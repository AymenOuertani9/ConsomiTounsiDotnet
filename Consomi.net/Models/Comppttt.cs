using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class User1
        {
            [JsonProperty("iduser")]
            public int Iduser { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }

            [JsonProperty("nbrpoint")]
            public int Nbrpoint { get; set; }

            [JsonProperty("pays")]
            public string Pays { get; set; }

            [JsonProperty("picture")]
            public string Picture { get; set; }

            [JsonProperty("pointconverti")]
            public double Pointconverti { get; set; }

            [JsonProperty("role")]
            public Role Role { get; set; }

            [JsonProperty("contrat")]
            public Contrat Contrat { get; set; }

            [JsonProperty("firstname")]
            public string Firstname { get; set; }

            [JsonProperty("dateCreation")]
            public string DateCreation { get; set; }

            [JsonProperty("lastname")]
            public string Lastname { get; set; }

            [JsonProperty("tel")]
            public int Tel { get; set; }

            [JsonProperty("login")]
            public string Login { get; set; }

            [JsonProperty("adress")]
            public string Adress { get; set; }
        }

        public class Comppttt
        {
            [JsonProperty("idcmpt")]
            public int Idcmpt { get; set; }

            [JsonProperty("codeCompte")]
            public string CodeCompte { get; set; }

            [JsonProperty("dateCreation")]
            public DateTime DateCreation { get; set; }

            [JsonProperty("solde")]
            public double Solde { get; set; }

            [JsonProperty("user")]
            public User User { get; set; }
        [JsonProperty("operations")]
        public List<Operation> Operations;
        }


    }
