using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppCalendar
{
    public partial class Udostepnianie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["DarkMode"] == null)
            {
                Session["DarkMode"] = true;
            }

            int user_id = Int32.Parse(Session["user_id"].ToString());
            //int user_id = 43;

            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);

                    using (var context = new DataClassesDataContext())
                    {
                        var wydarzenie = context.Tabela_Wydarzenia.FirstOrDefault(x => x.Id == id);
                        if (wydarzenie != null)
                        {
                            NazwaLabelDane.Text = wydarzenie.Nazwa;
                            DataLabelDane.Text = wydarzenie.Data.ToString("dd-MM-yyyy");
                            GodzinaLabelDane.Text = wydarzenie.Godzina.ToString();
                            OpisLabelDane.Text = wydarzenie.Opis;
                            MiejsceLabelDane.Text = wydarzenie.Miejsce;
                            GoscieLabelDane.Text = wydarzenie.Goscie;
                            NotatkaLabelDane.Text = wydarzenie.Notatka;
                            KolorLabelDane.Text = wydarzenie.Kolor;
                            PriorytetLabelDane.Text = wydarzenie.Priorytet.ToString();
                            KategoriaLabelDane.Text = wydarzenie.Tabela_Kategorie.Nazwa.ToString();
                        }

                        var osoby = context.Tabela_RL.Select(x => x.Email).ToList();
                        CheckBoxListOsoby.DataSource = osoby;
                        CheckBoxListOsoby.DataBind();


                    }
                }
            }

        }
    }
}