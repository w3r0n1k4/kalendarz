using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppCalendar
{
    public partial class WidokKalendarza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Kalendarz.SelectedDate = DateTime.Today;
                Kalendarz.SelectedDayStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            }
        }

        protected void Kalendarz_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}