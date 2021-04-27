using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Role
    {

        public int IdRole { get; set; }
        public string Roles { get; set; }
        public  Roletype Type { get; set; }

        public Role()
        {

        }

        public Role(int idRole, string roles, Roletype type)
        {
            IdRole = idRole;
            Roles = roles;
            Type = type;
        }
    }
}