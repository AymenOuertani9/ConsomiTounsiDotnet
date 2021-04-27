using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Chat
    {
        public  int Id { get; set; }
        public virtual User UserRecipient { get; set; }
        public virtual User UserSender { get; set; }
        public  string Msg { get; set; }
        public virtual DateTime MsgDate { get; set; }

        public Chat()
        {
        }

        public Chat(int id, User userRecipient, string msg, DateTime msgDate)
        {
            Id = id;
            UserRecipient = userRecipient;
            Msg = msg;
            MsgDate = msgDate;
        }
    }
}