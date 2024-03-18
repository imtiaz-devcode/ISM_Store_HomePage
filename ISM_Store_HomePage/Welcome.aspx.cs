using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISM_Store_HomePage
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DataTable dtUserAndDefaultPage =  (DataTable)Session["UserAndDefaultPage"];
            DataTable dtUserRelatedMenu = (DataTable)Session["UserRelatedMenu"];

            if (dtUserAndDefaultPage != null && dtUserRelatedMenu != null)
            {
                if (dtUserAndDefaultPage.Rows.Count > 0)
                {
                    if (dtUserAndDefaultPage.Rows[0]["MenuURL"] != "")
                    {
                        Response.Redirect(dtUserAndDefaultPage.Rows[0]["MenuURL"].ToString());
                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        public void ErrorAlert(string Message)
        {
            string script = "ShowAlert('Oops...', " + Message + ", 'error');";
            ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", script, true);
        }
    }
}