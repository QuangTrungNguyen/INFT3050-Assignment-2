using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BattlingElementalTitans
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Need to obtain data from databse in assignment 3
            lblUsername.Text = "user@example.com";
            lblNickname.Text = "SamplePlayer";
            imgProfilePicture.ImageUrl = "/ProfilePicture/sampleUser.jpg";

            
        }
    }
}