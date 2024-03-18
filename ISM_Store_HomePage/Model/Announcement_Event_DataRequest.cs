using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISM_Store_HomePage.Model
{
    public class Announcement_Event_DataRequest
    {
        public string IsActive { get; set; }
        public int pagenum { get; set; }
        public int pagesize { get; set; }
    }
}