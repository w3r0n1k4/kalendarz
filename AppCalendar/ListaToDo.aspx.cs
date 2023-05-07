using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;
using System.Windows;

namespace AppCalendar
{
    public partial class ListaToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = Int32.Parse(Session["user_id"].ToString());
            //int user_id = 43;

            var dc = new DataClasses2DataContext();
            var wydarzenia = dc.Tabela_Wydarzenia.Where(w => w.Id_Uzytkownika == user_id).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
            ListView.DataSource = wydarzenia;
            ListView.DataBind();
        }

        protected void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }
        protected void ListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                MessageBox.Show("Działa edytuj!");  //tylko żeby sprawdzić, czy działa przycisk, ze względu na to, że nie działa
            }
            else if (e.CommandName == "Delete")
            {
                MessageBox.Show("Działa usuń!");
            }
        }
    }
}