using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using AppCalendar;
using System.Windows;

namespace AppCalendar
{
    public partial class PomyslneLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["email"];
            string haslo = Request.QueryString["haslo"];

            if (email != null && haslo != null)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query1 = "SELECT Id FROM Tabela_RL WHERE Email = @Email AND Haslo = @Haslo";
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@Email", email);
                command1.Parameters.AddWithValue("@Haslo", haslo);
                using (connection)
                {
                    int userId = (int)command1.ExecuteScalar();

                    string query2 = "SELECT Id, Email, Haslo FROM Tabela_RL WHERE Id = @userId";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = command2.ExecuteReader();

                    if (reader.Read())
                    {
                        IdLabel.Text = reader["Id"].ToString();
                        EmailLabel.Text = reader["Email"].ToString();
                        HasloLabel.Text = reader["Haslo"].ToString();
                    }

                    reader.Close();
                }
                connection.Close();
            }
        }



        protected void WylogujButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Logowanie.aspx");
        }

        protected void EdytujEmailButton_Click(object sender, EventArgs e)
        {
            EdytujEmailButton.Visible = false;
            WpiszNowyEmailBox.Visible = true;
            ZapiszEdycjeEButton.Visible = true;
        }


        protected void EdytujHasloButton_Click(object sender, EventArgs e)
        {
            EdytujHasloButton.Visible = false;
            WpiszNoweHasloBox.Visible = true;
            ZapiszEdycjeHButton.Visible = true;
        }

        protected void UsunKontoButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Tabela_RL WHERE Email = @Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", EmailLabel.Text);
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Konto usunięte!");
                Response.Redirect("Logowanie.aspx");
            }
            else
            {
                
            }
        }

        protected void ZapiszEdycjeEButton_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(IdLabel.Text);
            string AktualnyEmail = EmailLabel.Text;

            string NowyEmail = WpiszNowyEmailBox.Text;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE Tabela_RL SET Email = @Email WHERE Id = @userId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", NowyEmail);
            command.Parameters.AddWithValue("@userId", userId);
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("E-mail został zmieniony na: " + NowyEmail + "\n\nZaloguj się ponownie!");
            /*EdytujHasloPrzycisk.Visible = false;
            WpiszNoweHaslo.Visible = false;
            ZapiszEdycjeHPrzycisk.Visible = false;*/
            Response.Redirect("Logowanie.aspx");
        }

        protected void ZapiszEdycjeHButton_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(IdLabel.Text);
            string AktualneHaslo = HasloLabel.Text;

            string NoweHaslo = WpiszNoweHasloBox.Text;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE Tabela_RL SET Haslo = @Haslo WHERE Id = @userId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Haslo", NoweHaslo);
            command.Parameters.AddWithValue("@userId", userId);
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Hasło zostało zmienione na: " + NoweHaslo + "\n\nZaloguj się ponownie!");
            /*EdytujHasloPrzycisk.Visible = true;
            WpiszNoweHaslo.Visible = false;
            ZapiszEdycjeHPrzycisk.Visible = false;*/
            Response.Redirect("Logowanie.aspx");
        }
    }
}