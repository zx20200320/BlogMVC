using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class ReplyInfo
    {
        public int Id { get; set; }
        public int MId { get; set; }
        public string ReplyContent { get; set; }
        public DateTime ReplyTime { get; set; }
        public int UId { get; set; }
    }
}