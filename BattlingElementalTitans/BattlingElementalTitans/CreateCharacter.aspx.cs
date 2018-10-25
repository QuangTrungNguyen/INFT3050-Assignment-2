using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{

    public partial class CreateCharacter : System.Web.UI.Page
    {
        /* 
         * Static variable belongs to class CreateCharacter only.
         * without static I cannot assign a value to these variables.
         */
        static string element;
        static string titan;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAir_Click(object sender, ImageClickEventArgs e)
        {
            // Make label and images visible and load titan images for air
            visualizeStepTwo();
            btnTitanOne.ImageUrl = "images/character/air1.jpg";
            btnTitanTwo.ImageUrl = "images/character/air2.jpg";
            btnTitanThree.ImageUrl = "images/character/air3.jpg";
            lblCharacterNameOne.Text = "Thunder Striker";
            lblCharacterNameTwo.Text = "Wind Cutter";
            lblCharacterNameThree.Text = "Air Ghost";
            element = "Air";
        }

        // Let labels and images visible
        private void visualizeStepTwo()
        {
            lblStepTwo.Visible = true;
            btnTitanOne.Visible = true;
            btnTitanTwo.Visible = true;
            btnTitanThree.Visible = true;
        }

        protected void btnEarth_Click(object sender, ImageClickEventArgs e)
        {
            visualizeStepTwo();
            btnTitanOne.ImageUrl = "images/character/earth1.jpg";
            btnTitanTwo.ImageUrl = "images/character/earth2.jpg";
            btnTitanThree.ImageUrl = "images/character/earth3.jpg";
            element = "Earth";
            lblCharacterNameOne.Text = "Moving Mountains";
            lblCharacterNameTwo.Text = "God of Trees";
            lblCharacterNameThree.Text = "Earth Giant";
        }

        protected void btnFire_Click(object sender, ImageClickEventArgs e)
        {
            visualizeStepTwo();
            btnTitanOne.ImageUrl = "images/character/fire1.jpg";
            btnTitanTwo.ImageUrl = "images/character/fire2.jpg";
            btnTitanThree.ImageUrl = "images/character/fire3.jpg";
            element = "Fire";
            lblCharacterNameOne.Text = "Fireballs Knight";
            lblCharacterNameTwo.Text = "Lava Destoryer";
            lblCharacterNameThree.Text = "Soul Burner";
        }

        protected void btnWater_Click(object sender, ImageClickEventArgs e)
        {
            visualizeStepTwo();
            btnTitanOne.ImageUrl = "images/character/water1.jpg";
            btnTitanTwo.ImageUrl = "images/character/water2.jpg";
            btnTitanThree.ImageUrl = "images/character/water3.jpg";
            element = "Water";
            lblCharacterNameOne.Text = "8-Tail Beast";
            lblCharacterNameTwo.Text = "Tsunami Monster";
            lblCharacterNameThree.Text = "King of Seas";
        }

        protected void btnTitanOne_Click(object sender, ImageClickEventArgs e)
        {
            visualizeStepThree();
            if (element == "Fire")
                titan = "Fireballs Knight";
            else if (element == "Water")
                titan = "8-Tall Beast";
            else if (element == "Earth")
                titan = "Moving Mountains";
            else if (element == "Air")
                titan = "Thunder Striker";
            lblChoice.Text = "Your choice is: " + element + ", " + titan;
        }

        private void visualizeStepThree()
        {
            lblChoice.Visible = true;
            lblStepThree.Visible = true;
            tbxName.Visible = true;
            btnCreate.Visible = true;
        }

        protected void btnTitanTwo_Click(object sender, ImageClickEventArgs e)
        {
            visualizeStepThree();
            if (element == "Fire")
                titan = "Lava Destoryer";
            else if (element == "Water")
                titan = "Tsunami Monster";
            else if (element == "Earth")
                titan = "God of Trees";
            else if (element == "Air")
                titan = "Wind Cutter";
            lblChoice.Text = "Your choice is: " + element + ", " + titan;
        }

        protected void btnTitanThree_Click(object sender, ImageClickEventArgs e)
        {
            visualizeStepThree();
            if (element == "Fire")
                titan = "Soul Burner";
            else if (element == "Water")
                titan = "King of Seas";
            else if (element == "Earth")
                titan = "Earth Giant";
            else if (element == "Air")
                titan = "Air Ghost";
            lblChoice.Text = "Your choice is: " + element + ", " + titan;
        }

        protected void btnCreate_Click(object sender, ImageClickEventArgs e)
        {
            if (tbxName.Text.Trim() != "")
            {
                // Need to store these data into database in assignment 3
                string script = "alert(\"Create successful\");window.location.href=\"Main.aspx\" ";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                string script = "alert(\"Please enter a valid name.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
    }
}