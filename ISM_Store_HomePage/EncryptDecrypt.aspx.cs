using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISM_Store_HomePage
{
    public partial class EncryptDecrypt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtEncrypt_TextChanged(object sender, EventArgs e)
        {
            EncryptDecryptTextShow.InnerText = Secure.EncryptData(txtEncrypt.Text);
            txtEncrypt.Text = "";
        }

        protected void txtDecrypt_TextChanged(object sender, EventArgs e)
        {
            EncryptDecryptTextShow.InnerText = Secure.DecryptData(txtDecrypt.Text);

            txtDecrypt.Text = "";
        }
    }
}