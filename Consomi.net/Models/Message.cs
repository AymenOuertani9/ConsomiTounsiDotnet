﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consomi.net.Models
{
    public class Message
    {
        public string MessageContent { get; set; }

        public Message()
        {

        }

        public Message(string MessageContent)
        {
            this.MessageContent  = MessageContent;
        }

    }
}