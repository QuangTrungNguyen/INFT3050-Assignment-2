using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class UploadProfilePicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /* 
         * Reference: http://www.cnblogs.com/yc-755909659/archive/2013/04/17/3026409.html
         * Access date: 30 Apr 2016
         * Code to validate picture and upload to the server
         */

        protected void btn_upload_Click(object sender, EventArgs e)
        {
            
        }
        public bool IsImage(string str)
        {
            bool isimage = false;
            string thestr = str.ToLower();
            // Limitted picture format
            string[] allowExtension = { ".jpg", "jpeg"};
            // Validate picture's extension name
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (thestr == allowExtension[i])
                {
                    isimage = true;
                    break;
                }
            }
            return isimage;
        }

        protected void btnUpload_Click(object sender, ImageClickEventArgs e)
        {
            if (pic_upload.HasFile)//validate whether the picture is null
            {
                Boolean fileOk = false;
                //Get extension name
                string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
                //validate file extension
                fileOk = IsImage(fileExtension);
                if (fileOk)
                {
                    //Validate file size
                    if (pic_upload.PostedFile.ContentLength < 1024000)
                    {
                        string filepath = "/ProfilePicture/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)// create file path if not exist
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        // Sample here, need to get user id in assignment 3
                        string virpath = filepath + "sampleUser" + fileExtension;// Virtual path at server
                        string mappath = Server.MapPath(virpath);// Convert to physcial path
                        File.Delete(mappath); // Delete old picture
                        pic_upload.PostedFile.SaveAs(mappath);// Save picture
                        // Show picture
                        pic.ImageUrl = mappath;
                        lbl_pic.Text = "Upload successful! You may need to restart your browser.";
                    }
                    else
                    {
                        pic.ImageUrl = "";
                        lbl_pic.Text = "Picture alreadt exceed than 1 MB, please select a new picture.";
                    }
                }
                else
                {
                    pic.ImageUrl = "";
                    lbl_pic.Text = "Wrong picture format, please select a new picture.";
                }
            }
            else
            {
                pic.ImageUrl = "";
                lbl_pic.Text = "Picture cannot be blank.";
            }
        }


        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Main.aspx", false);
        }
    }
    
}
