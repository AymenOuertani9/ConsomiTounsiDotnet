using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class ProgrammeFidelite
    {
        public int IdFidilite { get; set; }
        public Etatfidelite Etat { get; set; }
        public Typefidelite Type { get; set; }

        public virtual Command Command { get; set; }

        public ProgrammeFidelite()
        {

        }

        public ProgrammeFidelite(int idFidilite, Etatfidelite etat, Typefidelite type, Command command)
        {
            IdFidilite = idFidilite;
            Etat = etat;
            Type = type;
            Command = command;
        }
    }
}