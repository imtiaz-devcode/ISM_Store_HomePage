using ISM_HomePage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace ISM_HomePage
{
    /// <summary>
    /// Summary description for ISM_HomePage_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ISM_HomePage_WebService : System.Web.Services.WebService
    {
        [System.Web.Services.WebMethod]
        public void Page_Load()
        {
            // Your logic for the method

            // Rewrite the path to another page
            HttpContext.Current.RewritePath("Default.aspx", false);

            // Process the request as if it was originally for YourRedirectPage.aspx
            IHttpHandler handler = new System.Web.UI.Page();
            handler.ProcessRequest(HttpContext.Current);

            // You may need to call CompleteRequest to end the request processing
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        #region HR Related Work Start

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Responses SaveAnnouncement(AnnouncementRequest announcementRequest)
        {
            Responses responses = new Responses();
            try
            {
                string Query = "exec usp_Announcement_Add @Subject = '"+ announcementRequest.Subject+ "',@Body = '"+ announcementRequest.Body+ "',@AnnouncementDate = '"+ announcementRequest.AnnouncementDate + "',@IsActive = "+ announcementRequest.IsActive+ ",@CreatedBy = "+ announcementRequest.CreatedBy;
                
                DataSet ds = DB.GetDS(Query, false, 2000);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    responses.Status = true;
                    responses.Message = "Your Announcement # "+dt.Rows[0]["LastIdentity"].ToString() + " is successfully submitted !";
                }
            }
            catch (Exception ex)
            {
                responses.Message = ex.Message;
                responses.Status = false;
            }

            return new Responses { Status = responses.Status, Message = responses.Message };
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Responses SaveUpcomingEvent(UpcommingEventRequest upcommingEventRequest)
        {
            Responses responses = new Responses();
            try
            {
                string Query = "exec usp_UpcomingEvent_Add @EventTitle = '"+ upcommingEventRequest.EventTitle+ "',@EventDate = '"+ upcommingEventRequest.EventDate+ "',@EventLocation = '"+ upcommingEventRequest.EventLocation+ "',@IsActive = "+ upcommingEventRequest.IsActive+ ",@CreatedBy = "+ upcommingEventRequest.CreatedBy;

                DataSet ds = DB.GetDS(Query, false, 2000);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    responses.Status = true;
                    responses.Message = "Your Upcoming Event # " + dt.Rows[0]["LastIdentity"].ToString() + " is successfully submitted !";
                }
            }
            catch (Exception ex)
            {
                responses.Message = ex.Message;
                responses.Status = false;
            }

            return new Responses { Status = responses.Status, Message = responses.Message };
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public TableAndPaginationResponse GetAll_Announcement_Event_Data(Announcement_Event_DataRequest Announcement_Event_DataRequest)
        {
            TableAndPaginationResponse tableAndPaginationResponse = new TableAndPaginationResponse();
            try
            {
                string FilterParam = string.Empty;
                string Comma = ",";
                string TableData = string.Empty;
                int FirstRowNumber = 0;
                int LastRowNumber = 0;

                if (Announcement_Event_DataRequest.IsActive != "" && Announcement_Event_DataRequest.IsActive != null)
                {
                    FilterParam += "@IsActive="+ Announcement_Event_DataRequest.IsActive+""+ Comma;
                }
                if (Announcement_Event_DataRequest.pagesize != 0)
                {
                    FilterParam += "@pagesize=" + Announcement_Event_DataRequest.pagesize + "" + Comma;
                }
                if (Announcement_Event_DataRequest.pagenum != 0)
                {
                    FilterParam += "@pagenum=" + Announcement_Event_DataRequest.pagenum + "" + Comma;
                }

                string Query = "Exec usp_Announcemnt_UpComingEvent_GetAll "+ FilterParam.TrimEnd(',');

                DataSet ds = DB.GetDS(Query, false, 2000);
                DataTable dt_Record = ds.Tables[0];
                DataTable dt_Count = ds.Tables[1];

                if (dt_Record.Rows.Count > 0)
                {
                    int i = 0;
                    foreach (DataRow dr in dt_Record.Rows)
                    {
                        i += 1;

                        if (i == 1)
                        {
                            FirstRowNumber = DB.RowFieldInt(dr, "SNo");
                        }
                        TableData += "<tr>";
                        TableData += "<td>" + DB.RowFieldInt(dr, "SNo") + "</td>";
                        TableData += "<td title='"+ DB.RowField(dr, "AEName") + "'>"+ ShortForm_Announcemnt_Event_Set(DB.RowField(dr, "AEName")) + "</td>";
                        TableData += "<td>" + DB.RowField(dr, "Title") + "</td>";
                        TableData += "<td title='"+ DB.RowField(dr, "Message") + "'>" + Set_Announcement_EventMessageLength(DB.RowField(dr, "Message")) + "</td>";
                        TableData += "<td>";
                        TableData += "<img class='rounded-circle me-2' width='30' height='30' src='assets/img/Material/profile.png'>";
                        TableData += DB.RowField(dr, "UserName");
                        TableData += "</td>";
                        TableData += "<td>" + DB.RowFieldDateTime(dr, "CreatedAt").ToString("MMM dd yyyy HH:mm")+ "</td>";
                        TableData += "<td>" +  Set_Announcement_Event_Status(DB.RowField(dr, "AEName"), DB.RowFieldInt(dr, "IsActive")) + "</td>";
                        TableData += "<td>" + DB.RowFieldInt(dr, "OrderNumber") + "</td>";
                        TableData += "</tr>";

                        if (i == dt_Record.Rows.Count)
                        {
                            LastRowNumber = DB.RowFieldInt(dr, "SNo");
                        }
                    }

                    tableAndPaginationResponse.Status = true;
                    tableAndPaginationResponse.TableData = TableData;

                    if (dt_Count.Rows.Count > 0)
                    {
                        tableAndPaginationResponse.Message = "Showing " + FirstRowNumber + " to " + LastRowNumber + " of " + dt_Count.Rows[0]["ItemsCount"].ToString();
                        tableAndPaginationResponse.Pagination = clsPagination.MakePagination(dt_Count, Announcement_Event_DataRequest.pagenum);
                    }
                }
            }
            catch (Exception ex)
            {
                tableAndPaginationResponse.Message = ex.Message;
                tableAndPaginationResponse.Status = false;
            }

            return new TableAndPaginationResponse { Status = tableAndPaginationResponse.Status, Message = tableAndPaginationResponse.Message,TableData = tableAndPaginationResponse.TableData,Pagination = tableAndPaginationResponse.Pagination };
        }

        public string Set_Announcement_Event_Status(string EventName,int IsActive)
        {
            string Status = "Active";
            if (EventName == "Event")
            {
                if (IsActive == 0)
                {
                    Status = "In-Active";
                }
            }

            return Status;
        }

        public string Set_Announcement_EventMessageLength(string strMessage)
        {
            string result = string.Empty;

            // Check if the input string has at least 30 characters
            if (strMessage.Length >= 30)
            {
                // Use Substring to get the first 30 characters
                result = strMessage.Substring(0, 30)+" ... <u>read more</u>";
            }
            else
            {
                result = strMessage;
            }

            return result;
        }

        public string ShortForm_Announcemnt_Event_Set(string AnnouncementEventName)
        {
            string result = string.Empty;
            if (AnnouncementEventName == "Announcement")
            {
                result = "Ann.";
            }
            else
            {
                result = "Evt";
            }

            return result;
        }

        #endregion

        #region Marketing Related Work Start

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Responses SavePromotionalVideo()
        {
            Responses responses = new Responses();
            try
            {
                string VideoTitle = HttpContext.Current.Request.Form["VideoTitle"];
                string VideoDate = HttpContext.Current.Request.Form["VideoDate"];
                int CreatedBy = Convert.ToInt32(HttpContext.Current.Request.Form["CreatedBy"]);
                HttpPostedFile VideoFile = HttpContext.Current.Request.Files[0];

                bool IsFileUploaded = VideoFileUploadToDirectory(VideoFile);

                if (IsFileUploaded)
                {
                    string Query = "exec usp_LatestPromotion_Add @Title = '"+ VideoTitle + "',@FileName = 'Promotional" + Path.GetExtension(VideoFile.FileName) + "',@IsVideo = 1,@IsActive = 1,@CreatedBy = " + CreatedBy;

                    DataSet ds = DB.GetDS(Query, false, 2000);
                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        responses.Status = true;
                        responses.Message = "Your Promotional Video # " + dt.Rows[0]["LastIdentity"].ToString() + " is successfully uploaded !";
                    }
                }
                else
                {
                    responses.Status = false;
                    responses.Message = "Your Promotional Video is not Uploaded !";
                } 
            }
            catch (Exception ex)
            {
                responses.Message = ex.Message;
                responses.Status = false;
            }

            return new Responses { Status = responses.Status, Message = responses.Message };
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Responses SavePromotionalPDF()
        {
            Responses responses = new Responses();
            try
            {
                string PDFTitle = HttpContext.Current.Request.Form["PDFTitle"];
                string PDFDate = HttpContext.Current.Request.Form["PDFDate"];
                int CreatedBy = Convert.ToInt32(HttpContext.Current.Request.Form["CreatedBy"]);
                HttpPostedFile PDFFile = HttpContext.Current.Request.Files[0];

                bool IsFileUploaded = VideoFileUploadToDirectory(PDFFile);

                if (IsFileUploaded)
                {
                    string Query = "exec usp_LatestPromotion_Add @Title = '" + PDFTitle + "',@FileName = 'Promotional" + Path.GetExtension(PDFFile.FileName) + "',@IsVideo = 0,@IsActive = 1,@CreatedBy = " + CreatedBy;

                    DataSet ds = DB.GetDS(Query, false, 2000);
                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        responses.Status = true;
                        responses.Message = "Your Promotional PDF File # " + dt.Rows[0]["LastIdentity"].ToString() + " is successfully uploaded !";
                    }
                }
                else
                {
                    responses.Status = false;
                    responses.Message = "Your Promotional PDF File is not Uploaded !";
                }
            }

            catch (Exception ex)
            {
                responses.Message = ex.Message;
                responses.Status = false;
            }

            return new Responses { Status = responses.Status, Message = responses.Message };
        }



        public bool VideoFileUploadToDirectory(HttpPostedFile file)
        {
            try
            {
                bool result = false;

                // Specify the directory where you want to save the file
                string uploadDirectory = Server.MapPath("~/Video/Promotional/"); // Adjust the path as needed

                // Ensure the directory exists; create it if not
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }

                // Get the filename
                string fileName = Path.GetFileName("Promotional" + Path.GetExtension(file.FileName));

                // Combine the directory and filename to get the full path
                string filePath = Path.Combine(uploadDirectory, fileName);

                // Save the file
                file.SaveAs(filePath);

                // Display a success message
                result = true;

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
