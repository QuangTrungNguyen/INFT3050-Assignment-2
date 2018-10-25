using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class Activate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Query String
             * Source: http://www.dotnetperls.com/querystring
             **/
            string username = Request.QueryString["username"];
            if (username != null)
            {
                lblMsg.Text = "Your username is: " + username;
            }
            string activateCode = Request.QueryString["activateCode"];
            if (activateCode != null) // We need to get activation code from the database
            {
                lblMsg.Text += "<br />Your activate code is: " + activateCode + ".<br /> Activate success";
            }
            else
                lblMsg.Text += "Failed to activate your account.";
        }   
    }
}