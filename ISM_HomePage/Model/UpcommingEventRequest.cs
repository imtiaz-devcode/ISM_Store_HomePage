using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISM_HomePage.Model
{
    public class UpcommingEventRequest
    {
        public string EventTitle { get; set; }
        public string EventDate { get; set; }
        public string EventLocation { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
    }
}