using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            KategoriaBox.Visible = false;
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
            KategoriaBox.Visible = true;
            GoscieLabel.Visible = true;
            GoscieBox.Visible = true;
            NotatkaLabel.Visible = true;
            NotatkaBox.Visible = true;
            KolorLabel.Visible = true;
            KolorBox.Visible = true;
            PriorytetLabel.Visible = true;
            PriorytetBox.Visible = true;
            ZapiszButton.Visible = true;
        }

        protected void ZapiszButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";

            string nazwa = NazwaBox.Text;

            DateTime data = DateTime.Parse(DataBox.Text);

            string timeString = GodzinaBox.Text;
            TimeSpan godzina = TimeSpan.Parse(timeString);

            string opis = OpisBox.Text;
            string miejsce = MiejsceBox.Text;
            string kategoria = KategoriaBox.Text;
            string goscie = GoscieBox.Text;
            string notatka = NotatkaBox.Text;
            string kolor = KolorBox.Text;
            int  priorytet = int.Parse(PriorytetBox.Text); 
      
            //int user_id = Int32.Parse(Session["user_id"].ToString());
            int user_id = 42;

            string insertQuery = "INSERT INTO Tabela_Wydarzenia (Id, Nazwa, Data, Godzina, Opis, Miejsce, Kategoria, Goscie, Notatka, Kolor, Priorytet) VALUES (@Id, @Nazwa, @Data, @Godzina, @Opis, @Miejsce, @Kategoria, @Goscie, @Notatka, @Kolor, @Priorytet)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Id", user_id);
                    insertCommand.Parameters.AddWithValue("@Nazwa", nazwa);
                    insertCommand.Parameters.AddWithValue("@Data", data);
                    insertCommand.Parameters.AddWithValue("@Godzina", godzina);
                    insertCommand.Parameters.AddWithValue("@Opis", opis);
                    insertCommand.Parameters.AddWithValue("@Miejsce", miejsce);
                    insertCommand.Parameters.AddWithValue("@Kategoria", kategoria);
                    insertCommand.Parameters.AddWithValue("@Goscie", goscie);
                    insertCommand.Parameters.AddWithValue("@Notatka", notatka);
                    insertCommand.Parameters.AddWithValue("@Kolor", kolor);
                    insertCommand.Parameters.AddWithValue("@Priorytet", priorytet);

                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //InfoLabelDW.Text = "Dodano wydarzenie!";
                    }
                }
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
            KategoriaBox.Visible = false;
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