using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class Fight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sample data only, need to obtain data from database in assignment 3
            lblPlayer.Text = "user@example.com";
            lblTitan.Text = "SampleTitan";
            lblLevel.Text = 4.ToString();
            lblSteps.Text = 1.ToString();
            lblExp.Text = 1000001.ToString();
            lblWins.Text = 1358.ToString();
            lblLoses.Text = 1097.ToString();
            lblCharacter.Text = "King of Seas";

            lblPlayerEnemy.Text = "enemy@example.com";
            lblTitanEnemy.Text = "SampleTitan";
            lblLevelEnemy.Text = 3.ToString();
            lblStepsEnemy.Text = 4.ToString();
            lblExpEnemy.Text = 930265.ToString();
            lblWinsEnemy.Text = 913.ToString();
            lblLosesEnemy.Text = 857.ToString();
            lblCharacterEnemy.Text = "The Lava Knight";

            // Load titan's picture
            imgTitan.ImageUrl = "images/character/water1.jpg";
            imgElement.ImageUrl = "images/element//water.jpg";
            imgTitanEnemy.ImageUrl = "images/character/fire2.jpg";
            imgElementEnemy.ImageUrl = "images/element/fire.jpg";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FightOutcome.aspx",false);
        }
    }
}