using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace ISM_HomePage
{
    public partial class SiteMaster : MasterPage
    {
        DataTable dtUserAndDefaultPage;
        DataTable dtrRelatedMenu;

        protected void Page_Load(object sender, EventArgs e)
        {
            baseURL.Value = ConfigurationManager.AppSettings["baseURL"].ToString();

            if (Session["UserAndDefaultPage"] == null || Session["UserRelatedMenu"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                dtUserAndDefaultPage = (DataTable)Session["UserAndDefaultPage"];
                dtrRelatedMenu = (DataTable)Session["UserRelatedMenu"];
                ShowUserName(dtUserAndDefaultPage);
                ShowUserMenu(dtrRelatedMenu);
            }
        }

        public void ShowUserName(DataTable dtUserAndDefaultPage)
        {
            try
            {
                if (dtUserAndDefaultPage.Rows.Count > 0)
                {
                    UserName.InnerText = dtUserAndDefaultPage.Rows[0]["UserName"].ToString();
                    hdnUserLoginID.Value = dtUserAndDefaultPage.Rows[0]["UserID"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ShowUserMenu(DataTable dtUserRelatedMenu)
        {
            try
            {
                if (dtUserRelatedMenu.Rows.Count > 0)
                {
                    string htmlMenu = string.Empty;
                    int i = 0;
                    int RowsCount = dtUserRelatedMenu.Rows.Count;

                    foreach (DataRow dr in dtUserRelatedMenu.Rows)
                    {
                        i = i + 1;
                        string ActiveMenu = "";
                        string BorderStyle = "";

                        if (DB.RowField(dr, "MenuURL").Replace(".aspx","") == CurrentOpenPageName())
                        {
                            ActiveMenu = "active";
                        }

                        if (i < RowsCount)
                        {
                            BorderStyle = "border-top: 1px solid rgb(140,164,237);";
                        }

                        htmlMenu +="<li class='nav-item' style='"+ BorderStyle + "'>";
                        htmlMenu +="<a class='nav-link stretched-link "+ ActiveMenu + "' href='"+ DB.RowField(dr, "MenuURL") + "'>";
                        htmlMenu += "<i class='fas fa-tachometer-alt'></i><span>&nbsp;" + DB.RowField(dr, "MenuName") + "</span>";
                        htmlMenu += "</a>";
                        htmlMenu += "</li>";

                        //htmlMenu +="<li class='nav-item'>";
                        //htmlMenu +="<a class='nav-link stretched-link' href='table-Marketing.html'>";
                        //htmlMenu +="<i class='fas fa-table'></i>";
                        //htmlMenu += "<span>&nbsp; Reports</span>";
                        //htmlMenu += "</a>";
                        //htmlMenu += "</li>";
                    }

                    accordionSidebar.InnerHtml = htmlMenu;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public string CurrentOpenPageName()
        { 
        return Request.Url.Segments[1].ToString();
        }
    }
}