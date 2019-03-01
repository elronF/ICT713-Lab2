using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ICT713_Lab2_LoganFidler
{
    public partial class Default : System.Web.UI.Page
    {
        // form level variable declarations
        DateTime today = DateTime.Today; // Today's date
        DayOfWeek saturday = DayOfWeek.Saturday;

        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime nextSaturday = GetNextSaturday(saturday);
            calVote.VisibleDate = nextSaturday.Date.AddDays(7); // make sure mid-range of dates is always visible
        }

        protected DateTime GetNextSaturday(DayOfWeek day) // returns the days until next saturday
        {
            DateTime result = DateTime.Now;
            while (result.DayOfWeek != day)
            {
                result = result.AddDays(1);
            }
            return result;
        }

        protected void calVote_DayRender(object sender, DayRenderEventArgs e) // formats calendar to only show closest saturday and next two saturdays thereafter
        {
            DateTime sat = GetNextSaturday(saturday);
            DateTime satTwo = sat.Date.AddDays(7);
            DateTime satThree = sat.Date.AddDays(14);

            if (e.Day.Date != sat.Date && e.Day.Date != satTwo.Date && e.Day.Date != satThree.Date)
            {
                e.Day.IsSelectable = false;
                e.Cell.Enabled = false;
                e.Cell.BackColor = System.Drawing.Color.LightGray;
                e.Cell.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        protected void calVote_SelectionChanged(object sender, EventArgs e)
        {
            string currentDate = calVote.SelectedDate.Date.ToShortDateString();
            calVote.SelectedDayStyle.BackColor = System.Drawing.Color.Orange;
            lblCurrentSelection.Text = "You've selected " + currentDate;

        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            int result = GetVoteResult(); // get the vote
            string errorMessage = "You forgot to vote";
            Application.Lock();
            switch (result) // increment counter based on vote result and store in appropriate application state variable.
            {
                case 0:
                    Application["ErrorMessage"] = errorMessage;
                    break;
                case 1:
                    int dayOneCount = Convert.ToInt32(Application["dayOneCounter"]);
                    dayOneCount++;
                    Application["dayOneCounter"] = dayOneCount;
                    break;
                case 2:
                    int dayTwoCount = Convert.ToInt32(Application["dayTwoCounter"]);
                    dayTwoCount++;
                    Application["dayTwoCounter"] = dayTwoCount;
                    break;
                case 3:
                    int dayThreeCount = Convert.ToInt32(Application["dayThreeCounter"]);
                    dayThreeCount++;
                    Application["dayThreeCounter"] = dayThreeCount;
                    break;
            }

            //if (Application["dayOneCounter"] != null)
            //    lblCurrentSelection.Text = Application["dayOneCounter"].ToString();

            Application.UnLock();
            Response.Redirect("~/votes.aspx");

        }

        // get the voting result and return a corresponding integer
        private int GetVoteResult() 
        {
            DateTime satOne = GetNextSaturday(saturday);
            DateTime satTwo = satOne.Date.AddDays(7);
            DateTime satThree = satOne.Date.AddDays(14);
            DateTime currentSelection = calVote.SelectedDate;
            int result;
            
            if (currentSelection.Date == satOne.Date) // day 1 result
            {
                result = 1;
            }
            else if (currentSelection.Date > satOne.Date && currentSelection < satThree.Date) // day 2 result
            {
                result = 2;
            }
            else if (currentSelection.Date > satTwo.Date) // day 3 result
            {
                result = 3;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
} 