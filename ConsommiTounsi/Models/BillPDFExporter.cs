using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class BillPDFExporter
    {
		public  virtual  List<Command> Listcommands { get; set; }
        public virtual List<LigneComand> lignes { get; set; }
        public virtual UserConsomi U { get; set; }
        public virtual List<Bill> Bills { get; set; }
        //private List<User> users; 
        public virtual  Bill Bill { get; set; }
        public virtual Command C { get; set; }


        public BillPDFExporter()
        {


        }

        public BillPDFExporter(List<Command> listcommands, List<LigneComand> lignes, UserConsomi u, List<Bill> bills, Bill bill, Command c)
        {
            Listcommands = listcommands;
            this.lignes = lignes;
            U = u;
            Bills = bills;
            Bill = bill;
            C = c;
        }
    }
}