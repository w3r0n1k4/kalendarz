using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace AppCalendar
{
    public partial class Rejestracja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ZarejestrujButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "INSERT INTO Tabela_RL (Email, Haslo) VALUES ('" + EmailBoxR.Text + "', '" + HasloBoxR.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Zarejestrowano!");
                    Response.Redirect("Logowanie.aspx");
                }
                else
                {
                    MessageBox.Show("Nie zarejestrowano!");

                }

            }
        }
    }
}