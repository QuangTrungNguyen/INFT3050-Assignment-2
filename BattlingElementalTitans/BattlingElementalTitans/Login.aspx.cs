using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Timestamp to solve back-button problems
            // Source: Lecture slides 7a
            if (IsExpired())
                Response.Redirect("Expired.aspx");
            else
                this.SaveTimeStamps();
        }

        // check whether the timestamp is expired
        // Source: Lecture slides 7a
        private bool IsExpired()
        {
            if (Session["Login_TimeStamp"] == null)
                return false;
            else if (ViewState["TimeStamp"] == null)
                return false;
            else if (ViewState["TimeStamp"].ToString() ==
                     Session["Login_TimeStamp"].ToString())
                return false;
            else
                return true;
        }

        // Source: Lecture slides 7a
        private void SaveTimeStamps()
        {
            DateTime dtm = DateTime.Now;
            ViewState.Add("TimeStamp", dtm);
            Session.Add("Login_TimeStamp", dtm);
        }

        protected void btnSend_Click (object sender, EventArgs e)
        {
            string username = tbxForgotUsername.Text.Trim();
            string script = "alert(\"\");"; // Error message
            // Validate email format
            string emailStr = @"([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,5})+";
            Regex emailReg = new Regex(emailStr);
            if (emailReg.IsMatch(username))
            {
                // Send emails with password
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                // setup Smtp authentication
                System.Net.NetworkCredential credentials =
                    new System.Net.NetworkCredential("czxbnb@gmail.com", "cheng2277980");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("czxbnb@gmail.com", "B.E.T.T.E.R Account Center");
                msg.To.Add(new MailAddress(username));

                msg.Subject = "B.E.T.T.E.R Forgot password";
                msg.IsBodyHtml = true;
                msg.Body = string.Format("<html><head></head><body><b>Your password is: password</b></body>");

                try
                {
                    client.Send(msg);
                    script = "alert(\"Success, Please check your email inbox\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);

                }
                catch (Exception ex)
                {
                    script = "alert(" + ex.Message + ");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    Response.Redirect("Error.aspx",false);
                }
            }
            else
            {
                script = "alert(\"Incorrect email format\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnLogIn_Click1(object sender, ImageClickEventArgs e)
        {
            string script = "alert(\"\");";
            bool isValid = false;
            if (tbxUsername.Text.Trim() == "")
                script = "alert(\"username cannot be blank.\");";
            else if (tbxPassword.Text == "")
                script = "alert(\"password cannot be blank.\");";
            else if (tbxUsername.Text.Trim() != "user@example.com")
                script = "alert(\"we cannot found this user, please try again\");";
            else if (tbxPassword.Text != "password")
                script = "alert(\"incorrect password, please try again\");";
            else if (tbxUsername.Text.Trim() == "user@example.com" && tbxPassword.Text == "password")
            {
                script = "alert(\"login successful\");";
                isValid = true;
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            if (isValid == true)
            {
                Response.Redirect("main.aspx", false);
            }
        }
    }
}