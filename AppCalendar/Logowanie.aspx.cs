using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;

namespace AppCalendar
{
    public partial class Logowanie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ZalogujButton_Click(object sender, EventArgs e)
        { 
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asiak\Documents\DataBase.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Tabela_RL WHERE Email='" + EmailBoxL.Text + "' AND Haslo='" + HasloBoxL.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                             string email = EmailBoxL.Text;
                             string haslo = HasloBoxL.Text;
                             Response.Redirect("PomyslneLog.aspx?email=" + email + "&haslo=" + haslo);
                        }
                        else
                        {
                            MessageBox.Show("Niezalogowano, spróbuj ponownie!");
                        }
                        reader.Close();
            }

        }
    }
}