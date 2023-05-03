using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppCalendar
{
    public partial class ListaToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dc = new DataClasses2DataContext();
            var wydarzenia = dc.Tabela_Wydarzenia.OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
            ListView.DataSource = wydarzenia;
            ListView.DataBind();
        }
    }
}