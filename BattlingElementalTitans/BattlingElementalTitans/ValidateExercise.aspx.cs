using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class ValidateExercise : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Query String
             * Source: http://www.dotnetperls.com/querystring
             **/
            string pid = Request.QueryString["pid"];
            if (pid!= null)
            {
                lblMsg.Text = "Your child's exercise record id is : " + pid;
            }
            string validateCode = Request.QueryString["validateCode"];
            if (validateCode != null) // We need to get activation code from the database
            {
                lblMsg.Text += "<br />Your validate code is: " + validateCode + ".<br /> Validate success";
            }
            else
                lblMsg.Text += "Failed to validate this exercise record.";
        }
    }
}