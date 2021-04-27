using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class ResponseMessage
    {
        public string Content { get; set; }

        public ResponseMessage()
        {

        }

        public ResponseMessage(string content)
        {
            Content = content;
        }
    }
}