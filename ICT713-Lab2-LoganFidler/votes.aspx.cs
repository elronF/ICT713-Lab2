using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ICT713_Lab2_LoganFidler
{
    public partial class votes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // day one result
            if (Application["dayOneCounter"] != null)
                txtDayOne.Text = Application["dayOneCounter"].ToString();
            else
                txtDayOne.Text = "No votes";

            // day two result
            if (Application["dayTwoCounter"] != null)
                txtDayTwo.Text = Application["dayTwoCounter"].ToString();
            else
                txtDayTwo.Text = "No votes";

            // day three result
            if (Application["dayThreeCounter"] != null)
                txtDayThree.Text = Application["dayThreeCounter"].ToString();
            else
                txtDayThree.Text = "No votes";

            if (Application["errorMessage"] != null)
            {
                lblForgot.Text = Application["errorMessage"].ToString();
                Application["errorMessage"] = null;
            }
            else
                lblForgot.Text = "";
        }
    }
}