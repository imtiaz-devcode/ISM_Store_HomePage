using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISM_Store_HomePage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllServices();
                LoadAnnouncement_UpComingEvent();
                CurrentPromotional_Video();

            }
        }

        public void LoadAllServices()
        {
            SqlParameter parameter = new SqlParameter();
            DataSet ds = DB.GetDS("exec usp_AllServices_Get", false, 2000);
            DataTable dt_ESite = ds.Tables[0];
            DataTable dt_HRService = ds.Tables[1];
            DataTable dt_ITService = ds.Tables[2];
            DataTable dt_ITService2 = ds.Tables[3];

            #region ESite Condition for Generating HTML

            if (dt_ESite.Rows.Count > 0)
            {
                string ESiteHTML = "";
                foreach (DataRow dr in dt_ESite.Rows)
                {
                    if (DB.RowField(dr, "ESiteURL") == "#")
                    {
                        ESiteHTML += "<a class='dropdown-item' href='javascript:void(0)' title='External " + DB.RowField(dr, "ESiteDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "ESiteName") + "</a>";
                    }
                    else
                    {
                        ESiteHTML += "<a class='dropdown-item' href='" + DB.RowField(dr, "ESiteURL") + "' target='_blank' title='External " + DB.RowField(dr, "ESiteDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "ESiteName") + "</a>";
                    }
                }

                dvESite.InnerHtml = ESiteHTML;
            }

            #endregion

            #region HRService Condition for Generating HTML

            if (dt_HRService.Rows.Count > 0)
            {
                string HRServiceHTML = "";
                foreach (DataRow dr in dt_HRService.Rows)
                {
                    if (DB.RowField(dr, "HRServiceURL") == "#")
                    {
                        HRServiceHTML += "<a class='dropdown-item' href='javascript:void(0)' title='Internal " + DB.RowField(dr, "HRServiceDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "HRServiceName") + "</a>";
                    }
                    else
                    {
                        HRServiceHTML += "<a class='dropdown-item' href='" + DB.RowField(dr, "HRServiceURL") + "' target='_blank' title='Internal " + DB.RowField(dr, "HRServiceDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "HRServiceName") + "</a>";
                    }
                }

                dvHRService.InnerHtml = HRServiceHTML;
            }

            #endregion

            #region ITService for Workflow Form Condition for Generating HTML

            if (dt_ITService.Rows.Count > 0)
            {
                string ITServiceHTML = "";
                foreach (DataRow dr in dt_ITService.Rows)
                {
                    if (DB.RowField(dr, "ITServiceURL") == "#")
                    {
                        ITServiceHTML += "<a class='dropdown-item' href='javascript:void(0)' title='Internal " + DB.RowField(dr, "ITServiceDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "ITServiceName") + "</a>";
                    }
                    else
                    {
                        ITServiceHTML += "<a class='dropdown-item' href='" + DB.RowField(dr, "ITServiceURL") + "' target='_blank' title='Internal " + DB.RowField(dr, "ITServiceDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "ITServiceName") + "</a>";
                    }
                }

                dvITService.InnerHtml = ITServiceHTML;
            }

            #endregion

            #region ITService for Workflow Reports Condition for Generating HTML

            if (dt_ITService2.Rows.Count > 0)
            {
                string ITServiceHTML2 = "";
                foreach (DataRow dr in dt_ITService2.Rows)
                {
                    if (DB.RowField(dr, "ITServiceURL") == "#")
                    {
                        ITServiceHTML2 += "<a class='dropdown-item' href='javascript:void(0)' title='Internal " + DB.RowField(dr, "ITServiceDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "ITServiceName") + "</a>";
                    }
                    else
                    {
                        ITServiceHTML2 += "<a class='dropdown-item' href='" + DB.RowField(dr, "ITServiceURL") + "' target='_blank' title='Internal " + DB.RowField(dr, "ITServiceDescription") + "' style='font-family: poppins;border-bottom-width: 1px;'>" + DB.RowField(dr, "ITServiceName") + "</a>";
                    }
                }

                dvITService2.InnerHtml = ITServiceHTML2;
            }

            #endregion
        }

        public void LoadAnnouncement_UpComingEvent()
        {
            SqlParameter parameter = new SqlParameter();
            DataSet ds = DB.GetDS("exec usp_Announcement_UpComingEvent_Get", false, 2000);
            DataTable dt_Announcement = ds.Tables[0];
            DataTable dt_UpComingEvent = ds.Tables[1];

            if (dt_Announcement.Rows.Count > 0)
            {
                string AnnouncementHTML = "";
                foreach (DataRow dr in dt_Announcement.Rows)
                {
                    AnnouncementHTML += "<h2 class='ps -2 pt-2 pb-2' style='color: var(--bs-yellow);background: var(--bs-link-hover-color);border-radius: 1px;text-align: center;font-size: 24px;'>&nbsp;Announcement</h2>";
                    AnnouncementHTML += "<div class='row' style='position: relative;'>";
                    AnnouncementHTML += "<div class='col float-end mt-1'><label class='form-label' style='color: var(--bs-white);padding: 11px;background: var(--bs-link-hover-color);border-radius: 37px;height: 45px;padding-right: 18px;padding-left: 18px;font-weight: bold;transform: scale(0.85);'>From: HR</label><label class='form-label float-end' style='color: var(--bs-white);padding: 11px;background: rgba(108,117,125,0.34);border-radius: 37px;height: 45px;padding-right: 18px;padding-left: 18px;font-weight: bold;font-size: 14px;transform: scale(0.80);width: 145.422px;text-align: center;'><i class='far fa-calendar-alt' style='font-size: 16px;'></i>&nbsp; " + Convert.ToDateTime(DB.RowField(dr, "AnnouncementDate")).ToString("MM/dd/yyyy") + "</label></div>";
                    AnnouncementHTML += "</div>";
                    AnnouncementHTML += "<div class='row mt-3'>";
                    AnnouncementHTML += "<div class='col'>";
                    AnnouncementHTML += "<h2 class='mt-1 ms-2' style='color: var(--bs-white);font-size: 24px;font-weight: bold;'>" + DB.RowField(dr, "Subject") + "</h2>";
                    AnnouncementHTML += "<p class='mt-2 ms-2' style='color: var(--bs-white);font-size: 14px;'>" + DB.RowField(dr, "Body") + "</p>";
                    AnnouncementHTML += "</div>";
                    AnnouncementHTML += "</div>";
                }

                dvAnnouncement.InnerHtml = AnnouncementHTML;
            }

            if (dt_UpComingEvent.Rows.Count > 0)
            {
                int i = 1;
                string UpComingEventHTML = "";
                foreach (DataRow dr in dt_UpComingEvent.Rows)
                {
                    UpComingEventHTML += "<div class='accordion-item' style='background: var(--bs-accordion-bg);'>";
                    UpComingEventHTML += "<h2 class='accordion-header' role='tab' style='background: var(--bs-accordion-active-color);'><button class='accordion-button collapsed' type='button' data-bs-toggle='collapse' data-bs-target='#accordion_1 .item-" + i + "' aria-expanded='false' aria-controls='accordion_1 .item-" + i + "' style='text-align: center;font-weight: bold;'>" + DB.RowField(dr, "EventTitle") + " - " + DB.RowFieldDateTime(dr, "EventDate").ToString("MM/dd/yyyy") + "&nbsp;&nbsp;</button></h2>";
                    UpComingEventHTML += "<div class='accordion-collapse collapse item-" + i + "' role='tabpanel' data-bs-parent='#accordion_1'>";
                    UpComingEventHTML += "<div class='accordion-body'>";
                    UpComingEventHTML += "<p class='mb-0' style='text-align: left;'>" + DB.RowField(dr, "EventLocation") + "</p>";
                    UpComingEventHTML += "</div>";
                    UpComingEventHTML += "</div>";
                    UpComingEventHTML += "</div>";

                    i = i + 1;
                }

                accordion_1.InnerHtml = UpComingEventHTML;
            }
        }

        public void CurrentPromotional_Video()
        {
            try
            {
                string VideoTag = string.Empty;
                SqlParameter parameter = new SqlParameter();
                DataTable dt = DB.GetDS("exec usp_Current_PromotionalVideo_Get", false, 2000).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    VideoTag += "<video style=\"width:100%\" autoplay loop muted>";
                    VideoTag += "	<source src=\"Video/Promotional/" + DB.RowField(dt.Rows[0], "FileName") + "\" type=\"video/mp4\" />";
                    VideoTag += "</video>";

                    dv_VideoContainer.InnerHtml = VideoTag;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}