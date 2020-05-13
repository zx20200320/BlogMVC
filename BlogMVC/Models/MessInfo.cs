using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class MessInfo
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public int MessState { get; set; }
        public string UserName { get; set; }
    }
}