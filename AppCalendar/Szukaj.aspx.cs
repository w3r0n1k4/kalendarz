using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppCalendar
{
    public partial class Szukaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int user_id = Int32.Parse(Session["user_id"].ToString());
            int user_id = 1;

            var dc = DataContextSingleton.GetInstance();
            var wydarzenia = dc.Tabela_Wydarzenia.Where(w => w.Id_Uzytkownika == user_id).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
            var znalezione = wydarzenia.Where(w => w.Nazwa == TextBox1.Text).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();

            if (znalezione.Count == 0)
            {
                this.Label1.Text = "Nie ma wydarzenia o takiej nazwie.";
                ListView.DataSource = znalezione;
                ListView.DataBind();
            }
            else
            {
                this.Label1.Text = " ";
                ListView.DataSource = znalezione;
                ListView.DataBind();
            }
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

                // int user_id = Int32.Parse(Session["user_id"].ToString());
                int user_id = 1;
               
                var wydarzenia = dc.Tabela_Wydarzenia.Where(w => w.Id_Uzytkownika == user_id).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
                var znalezione = wydarzenia.Where(w => w.Nazwa == TextBox1.Text).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();
                ListView.DataSource = znalezione;
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