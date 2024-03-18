using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ISM_HomePage
{
    public class clsPagination
    {
        public static string MakePagination(DataTable dtPaginationCount,int PageNum = 1)
        {
            string result = string.Empty;

            try
            {
                string strPagination = string.Empty;
                
                string clsNextDisabled = "";
                string clsPreviousDisabled = "";

                int NumOfPages = Convert.ToInt32(dtPaginationCount.Rows[0]["Pages"]);

                if (PageNum == 1)
                {
                    clsPreviousDisabled = "disabled";
                }
                strPagination += "<li class='page-item " + clsPreviousDisabled + "'><a class='page-link' aria-label='Previous' href='javascript:void(0);' onclick='GetAll_Announcement_Event_Data("+ (PageNum - 1)+ ")'><span aria-hidden='true'>«</span></a></li>";

                for (int i = 1; i <= NumOfPages; i++)
                {
                    string clsActive = "";

                    if (i == PageNum)
                    {
                        clsActive = "active";
                    }

                    strPagination += "<li class='page-item " + clsActive + "'><a class='page-link' href='javascript:void(0);' onclick='GetAll_Announcement_Event_Data(" + i + ")'>" + i + "</a></li>";
                }

                if (PageNum == NumOfPages)
                {
                    clsNextDisabled = "disabled";
                }
                strPagination += "<li class='page-item " + clsNextDisabled + "'><a class='page-link' href='javascript:void(0);' aria-label='Next' onclick='GetAll_Announcement_Event_Data(" + (PageNum + 1) + ")'><span aria-hidden='true'>»</span></a></li>";

                result = strPagination;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}