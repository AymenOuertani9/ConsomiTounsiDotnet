using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Remarque
    {
		public int Idnote { get; set; }
		public string Content { get; set; }
		public virtual Command Comande { get; set; }
		
		public Remarque()
        {

        }

        public Remarque(int idnote, string content, Command comande)
        {
            Idnote = idnote;
            Content = content;
            Comande = comande;
        }
    }
}