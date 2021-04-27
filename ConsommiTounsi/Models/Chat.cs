using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Chat
    {
        public  int Id { get; set; }
        public virtual UserConsomi UserRecipient { get; set; }
        public virtual UserConsomi UserSender { get; set; }
        public  string Msg { get; set; }
        public virtual DateTime MsgDate { get; set; }

        public Chat()
        {
        }

        public Chat(int id, UserConsomi userRecipient, string msg, DateTime msgDate)
        {
            Id = id;
            UserRecipient = userRecipient;
            Msg = msg;
            MsgDate = msgDate;
        }
    }
}