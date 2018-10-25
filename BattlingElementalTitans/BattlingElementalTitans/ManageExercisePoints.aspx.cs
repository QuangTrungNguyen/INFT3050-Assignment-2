using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattlingElementalTitans
{
    public partial class ManageExercisePoints : System.Web.UI.Page
    {
        static int balance;
        static int addExercisePoints;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Need to obtain data from databse in assignment 3
            balance = 500;
            lblExercisePoints.Text = balance.ToString();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxAdd.Text.Trim() != "")
            {
                addExercisePoints = Convert.ToInt32(tbxAdd.Text);
                balance = balance - addExercisePoints;
                lblExercisePoints.Text = balance.ToString();
                string script = "alert(\"Experience points have been added successfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                string script = "alert(\"Please enter a valid number.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

    }
}