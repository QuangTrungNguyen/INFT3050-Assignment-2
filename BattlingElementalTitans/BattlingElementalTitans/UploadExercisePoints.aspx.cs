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
    public partial class ExerciseUpload : System.Web.UI.Page
    {
        Random r = new Random();
        static int pid;
        static int validateCode;
        static bool isExceed = false;
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
            if (Session["UploadExercisePoints_TimeStamp"] == null)
                return false;
            else if (ViewState["TimeStamp"] == null)
                return false;
            else if (ViewState["TimeStamp"].ToString() ==
                     Session["UploadExercisePoints_TimeStamp"].ToString())
                return false;
            else
                return true;
        }

        // Source: Lecture slides 7a
        private void SaveTimeStamps()
        {
            DateTime dtm = DateTime.Now;
            ViewState.Add("TimeStamp", dtm);
            Session.Add("UploadExercisePoints_TimeStamp", dtm);
        }

        /* 
         * Send activate link to user
         * Source:http://stackoverflow.com/questions/32260/sending-email-in-net-through-gmail
         */
        private void sendEmail()
        {
            string username;
            username = "czxbnb@gmail.com"; // Sample parent's email

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

                string activateAddress = "http://localhost:50655/ValidateExercise.aspx?pid=" + pid + "&validateCode=" + validateCode.ToString();
                msg.Subject = "Validate your child's exercise point";
                msg.IsBodyHtml = true;
                msg.Body = string.Format("<html><head></head><body><b>Your child tried to upload " + tbxSteps.Text.ToString() + " steps exercise record just now. <br />Please check the authenticity of your child's exercise record. Once validated, click the link below to confirm : <br />" + activateAddress + " </b></body>");

                try
                {
                    client.Send(msg);
                    if (isExceed == false)
                        script = "alert(\"Upload successful! After your parents validate your record, exercise points will be added to your account.\");";
                    else
                        script = "alert(\"Upload successful! Only 50000 steps uploaded. After your parents validate your record, exercise points will be added to your account.\");";
                    script += "window.location.href=\"Main.aspx\";";
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
                script = "alert(\"Incorrect email format for your parent's email address, please contact customer service.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void btnSubmitRecord_Click(object sender, ImageClickEventArgs e)
        {
            string script = script = "alert(\"\");";
            // Check the steps and convert to experience points
            double experiencePoints = 0;
            try
            {
                experiencePoints = Convert.ToDouble(tbxSteps.Text) * 0.01;
            }
            catch (Exception ex)
            {
                script = "alert(\"" + ex.Message + "\");";
            }
            // Need to save validation code from database in assignment.
            if (experiencePoints < 150)
            {
                script = "alert(\"Minimun 150 points per day. If you cannot achieve it, you cannot upload experience points.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else if (experiencePoints >= 150)
            {
                // Generate pid and validation code
                pid = r.Next(100000000, 999999999);
                validateCode = r.Next(1000, 9999);
                if (experiencePoints > 500)
                {
                    // Upload 500 exercise points to database in assignment 3
                    isExceed = true;
                    sendEmail();
                }
                else if (experiencePoints <= 500)
                {

                    sendEmail();
                }
            }
        }
    }
}