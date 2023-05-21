using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace AppCalendar
{
    public partial class EdycjaDanych : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int user_id = Int32.Parse(Session["user_id"].ToString());
            int user_id = 42;


            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);

                    // Wykonaj logikę związana z edycją danych o podanym identyfikatorze
                    using (var context = new DataClasses2DataContext())
                    {
                        var wydarzenie = context.Tabela_Wydarzenia.FirstOrDefault(x => x.Id == id);
                        if (wydarzenie != null)
                        {
                            // Przypisz dane do textboxów
                            NazwaBox.Text = wydarzenie.Nazwa;
                            DataBox.Text = wydarzenie.Data.ToShortDateString();
                            GodzinaBox.Text = wydarzenie.Godzina.ToString();
                            OpisBox.Text = wydarzenie.Opis;
                            MiejsceBox.Text = wydarzenie.Miejsce;
                            GoscieBox.Text = wydarzenie.Goscie;
                            NotatkaBox.Text = wydarzenie.Notatka;
                            KolorBox.Text = wydarzenie.Kolor;
                            PriorytetBox.Text = wydarzenie.Priorytet.ToString();
                            // Przykład uzupełniania DropDownList
                            KategoriaList.DataSource = context.Tabela_Kategorie.ToList();
                            KategoriaList.DataTextField = "Nazwa";
                            KategoriaList.DataValueField = "Id";
                            KategoriaList.DataBind();

                            // Ustaw wybraną wartość dla DropDownList na podstawie danych z wydarzenia
                            KategoriaList.SelectedValue = wydarzenie.Id_Kategorii.ToString();
                        }                     
                    }
                }
            }
        }

        protected void ZapiszEdit_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);

                // Pobierz dane z textboxów
                string nazwa = NazwaBox.Text;
                DateTime data = DateTime.Parse(DataBox.Text);
                TimeSpan godzina = TimeSpan.Parse(GodzinaBox.Text);
                string opis = OpisBox.Text;
                string miejsce = MiejsceBox.Text;
                int kategoriaId = int.Parse(KategoriaList.SelectedValue);
                // Pobierz wartości z pozostałych textboxów itd.

                // Zaktualizuj rekord w bazie danych
                var dc = DataContextSingleton.GetInstance();
                
                    var wydarzenie = dc.Tabela_Wydarzenia.FirstOrDefault(x => x.Id == id);
                    if (wydarzenie != null)
                    {
                        // Zaktualizuj pola rekordu
                        wydarzenie.Nazwa = nazwa;
                        wydarzenie.Data = data;
                        wydarzenie.Godzina = godzina;
                        wydarzenie.Opis = opis;
                        wydarzenie.Miejsce = miejsce;
                        wydarzenie.Id_Kategorii = kategoriaId;
                        
                    

                    // Zapisz zmiany w bazie danych
                    dc.SubmitChanges();

                    Response.Redirect("ListaToDo.aspx");
                    }              
            }
        }
    }
}