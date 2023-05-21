﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows;

namespace AppCalendar
{
    public partial class WidokKalendarza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Kalendarz.SelectedDate = DateTime.Today;
                DataBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                Kalendarz.SelectedDayStyle.BackColor = System.Drawing.Color.CornflowerBlue;

            }
        }

        protected void Kalendarz_SelectionChanged(object sender, EventArgs e)
        {
           // int user_id = Int32.Parse(Session["user_id"].ToString());
            int user_id = 42;

            var dc = DataContextSingleton.GetInstance();
            var wydarzenia = dc.Tabela_Wydarzenia.Where(w => w.Id_Uzytkownika == user_id && w.Data == Kalendarz.SelectedDate.Date).OrderBy(w => w.Data).ThenBy(w => w.Godzina).ToList();

            foreach (var wydarzenie in wydarzenia)
            {
                var div = new HtmlGenericControl("div");
                if (wydarzenie.Data < DateTime.Now)
                {
                    var s = new HtmlGenericControl("s");
                    s.InnerHtml = ("• ") + wydarzenie.Nazwa;
                    div.Controls.Add(s);
                }
                else
                {
                    div.InnerHtml = ("• ") + wydarzenie.Nazwa;
                }
                Controls.Add(div);
            }


            DodajWydarzenieButton.Visible = true;
            NazwaLabel.Visible = false;
            NazwaBox.Visible = false;
            DataLabel.Visible = false;
            DataBox.Visible = false;
            GodzinaLabel.Visible = false;
            GodzinaBox.Visible = false;
            OpisLabel.Visible = false;
            OpisBox.Visible = false;
            MiejsceLabel.Visible = false;
            MiejsceBox.Visible = false;
            KategoriaLabel.Visible = false;
            KategoriaList.Visible = false;
            GoscieLabel.Visible = false;
            GoscieBox.Visible = false;
            NotatkaLabel.Visible = false;
            NotatkaBox.Visible = false;
            KolorLabel.Visible = false;
            KolorBox.Visible = false;
            PriorytetLabel.Visible = false;
            PriorytetBox.Visible = false;
            ZapiszButton.Visible = false;
        }

        protected void DodajWydarzenieButton_Click(object sender, EventArgs e)
        {
            DodajWydarzenieButton.Visible = false;
            NazwaLabel.Visible = true;
            NazwaBox.Visible = true;
            DataLabel.Visible = true;
            DataBox.Visible = true;
            GodzinaLabel.Visible = true;
            GodzinaBox.Visible = true;
            OpisLabel.Visible = true;
            OpisBox.Visible = true;
            MiejsceLabel.Visible = true;
            MiejsceBox.Visible = true;
            KategoriaLabel.Visible = true;
            KategoriaList.Visible = true;
            GoscieLabel.Visible = true;
            GoscieBox.Visible = true;
            NotatkaLabel.Visible = true;
            NotatkaBox.Visible = true;
            KolorLabel.Visible = true;
            KolorBox.Visible = true;
            PriorytetLabel.Visible = true;
            PriorytetBox.Visible = true;
            ZapiszButton.Visible = true;

            var dc = new DataClasses2DataContext();
            var kategorie = dc.Tabela_Kategorie.ToList();
            KategoriaList.DataSource = kategorie;
            KategoriaList.DataTextField = "Nazwa";
            KategoriaList.DataValueField = "Id";
            KategoriaList.DataBind();

        }

        protected void ZapiszButton_Click(object sender, EventArgs e)
        {
            //int user_id = Int32.Parse(Session["user_id"].ToString());
            int user_id = 42;

            var dc = DataContextSingleton.GetInstance();
            var noweWydarzenie = new Tabela_Wydarzenia
            {
                Nazwa = NazwaBox.Text,
                Data = Convert.ToDateTime(DataBox.Text),
                Godzina = TimeSpan.Parse(GodzinaBox.Text),
                Opis = OpisBox.Text,
                Miejsce = MiejsceBox.Text,
                Goscie = GoscieBox.Text,
                Notatka = NotatkaBox.Text,
                Kolor = KolorBox.Text,
                Priorytet = Convert.ToInt32(PriorytetBox.Text),
                Id_Uzytkownika = user_id,
                Id_Kategorii = Convert.ToInt32(KategoriaList.SelectedValue)
            };

            dc.Tabela_Wydarzenia.InsertOnSubmit(noweWydarzenie);
            dc.SubmitChanges();

            DodajWydarzenieButton.Visible = true;
            NazwaLabel.Visible = false;
            NazwaBox.Visible = false;
            DataLabel.Visible = false;
            DataBox.Visible = false;
            GodzinaLabel.Visible = false;
            GodzinaBox.Visible = false;
            OpisLabel.Visible = false;
            OpisBox.Visible = false;
            MiejsceLabel.Visible = false;
            MiejsceBox.Visible = false;
            KategoriaLabel.Visible = false;
            KategoriaList.Visible = false;
            GoscieLabel.Visible = false;
            GoscieBox.Visible = false;
            NotatkaLabel.Visible = false;
            NotatkaBox.Visible = false;
            KolorLabel.Visible = false;
            KolorBox.Visible = false;
            PriorytetLabel.Visible = false;
            PriorytetBox.Visible = false;
            ZapiszButton.Visible = false;

        }
    }
}