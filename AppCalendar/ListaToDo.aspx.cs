using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            //int user_id = Int32.Parse(Session["user_id"].ToString());
            int user_id = 42;

            var dc = DataContextSingleton.GetInstance();
            var wydarzenia = dc.Tabela_Wydarzenia.Where(w => w.Id_Uzytkownika == user_id).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
            ListView.DataSource = wydarzenia;
            ListView.DataBind();
            /*
            if (IsPostBack)
            {
                if (Request.Form["operacja"] == "Edit")
                {
                    Response.Redirect("www.wp.pl");
                }

            }
            */
        }

        protected void UsunButtonW_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);

            var dc = DataContextSingleton.GetInstance();
            var wydarzenie = dc.Tabela_Wydarzenia.FirstOrDefault(w => w.Id == id);

            if (wydarzenie != null)
            {
                dc.Tabela_Wydarzenia.DeleteOnSubmit(wydarzenie);
                dc.SubmitChanges();

                //int user_id = Int32.Parse(Session["user_id"].ToString());
                int user_id = 42;

                var wydarzenia = dc.Tabela_Wydarzenia.Where(w => w.Id_Uzytkownika == user_id).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
                ListView.DataSource = wydarzenia;
                ListView.DataBind();
            }
        }

        protected void EdytujButtonW_Click(object sender, EventArgs e)
        {
            // Pobierz identyfikator elementu do edycji
            Button edytujButton = (Button)sender;
            string id = edytujButton.CommandArgument;

            // Przekieruj na stronę edycji z przekazanym identyfikatorem jako parametrem w adresie URL
            Response.Redirect("EdycjaDanych.aspx?id=" + id);
        }

        protected void ZapiszEdycjeButtonW_Click(object sender, EventArgs e)
        {
           
        }

    }
}