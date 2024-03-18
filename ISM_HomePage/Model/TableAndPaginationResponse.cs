using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISM_HomePage.Model
{
    public class TableAndPaginationResponse
    {
        public string Message { get; set; }
        public string TableData { get; set; }
        public string Pagination { get; set; }
        public bool Status { get; set; }
    }
}