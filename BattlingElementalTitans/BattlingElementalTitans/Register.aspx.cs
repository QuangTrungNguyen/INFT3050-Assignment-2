﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class Register : System.Web.UI.Page
    {
        Random r = new Random(); // Generate vertification code and activate link
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
            if (Session["Register_TimeStamp"] == null)
                return false;
            else if (ViewState["TimeStamp"] == null)
                return false;
            else if (ViewState["TimeStamp"].ToString() ==
                     Session["Register_TimeStamp"].ToString())
                return false;
            else
                return true;
        }

        // Source: Lecture slides 7a
        private void SaveTimeStamps()
        {
            DateTime dtm = DateTime.Now;
            ViewState.Add("TimeStamp", dtm);
            Session.Add("Register_TimeStamp", dtm);
        }
    

    /* 
     * Send activate link to user
     * Source:http://stackoverflow.com/questions/32260/sending-email-in-net-through-gmail
     */

        private void sendEmail()
        {
            string username;
            username = tbxUsername.Text.Trim();

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
       
                string activateAddress = "http://localhost:50655/Activate.aspx?username=" + username + "&activateCode=" + r.Next(10000000, 99999999).ToString();
                msg.Subject = "Activate your B.E.T.T.E.R account";
                msg.IsBodyHtml = true;
                msg.Body = string.Format("<html><head></head><body><b>Please click the link below to activate your account: </br>" + activateAddress +" </b></body>");

               
                try
                {
                    client.Send(msg);
                    script = "alert(\"Almost success! One last step: go to your email inbox to activate your account!\");";
                    script += "window.close();";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                catch (Exception ex)
                {
                    script = "alert(" + ex.Message + ");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    Response.Redirect("Error.aspx", false); //Jump to error page
                }
            }
            else
            {
                script = "alert(\"Incorrect email format for username\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string script = "";
            if (tbxUsername.Text.Trim() == "" || tbxPassword.Text == "" || tbxRepeatPassword.Text == "" || tbxParentsEmail.Text.Trim() == "")
            {
                script = "alert(\"Please fulfill all details.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (tbxPassword.Text != tbxRepeatPassword.Text)
            {
                script = "alert(\"The two passwords you typed do not match.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (tbxUsername.Text.Trim() == tbxParentsEmail.Text.Trim())
            {
                script = "alert(\"Parents' email address should not be same as yours.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                sendEmail();
            }
        }
    }
}
