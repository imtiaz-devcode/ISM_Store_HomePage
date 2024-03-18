using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISM_HomePage.Model
{
    public class AnnouncementRequest
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AnnouncementDate { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
    }
}