using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISM_HomePage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string UserEmail = txtUserEmail.Value;
                string UserPassword = txtUserPassword.Value;

                if (FormValidate())
                {
                    string LoginQuery = "exec usp_LoginUser @UserEmail='"+ UserEmail + "',@UserPassword='"+ UserPassword + "'";
                    DataSet ds = DB.GetDS(LoginQuery, false, 2000);

                    if (ds.Tables.Count > 1)
                    {
                        DataTable dtUserAndDefaultPage = ds.Tables[0];
                        DataTable dtUserRelatedMenu = ds.Tables[1];

                        if (dtUserAndDefaultPage.Rows.Count > 0)
                        {
                            Session["UserAndDefaultPage"] = dtUserAndDefaultPage;
                        }

                        if (dtUserRelatedMenu.Rows.Count > 0)
                        {
                            Session["UserRelatedMenu"] = dtUserRelatedMenu;
                        }

                        Response.Redirect("Welcome.aspx");
                    }
                    else
                    {
                        ErrorAlert("Login unsuccessful. Please double-check your username and password and ensure that you have a valid account. If the issue persists, contact IT support 1205 for assistance.");
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }  
        }


        public bool FormValidate()
        {
            string UserEmail = txtUserEmail.Value;
            string UserPassword = txtUserPassword.Value;
            int Error = 0;
            string Msg = "";

            if (UserEmail == "")
            {
                Error = 1;
                Msg = "Please enter your Email address.";
            }
            if (UserPassword == "")
            {
                Error = 1;
                Msg = "Please enter your Password.";
            }

            if (Error > 0)
            {
                ErrorAlert(Msg);

                return false;
            }
            else
            {
                return true;
            }
        }

        public void ErrorAlert(string Message)
        {
            string script = "ShowAlert('Oops...', '" + Message + "', 'error');";
            ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", script, true);
        }
    }
}