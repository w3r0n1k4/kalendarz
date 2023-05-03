<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WidokKalendarza.aspx.cs" Inherits="AppCalendar.WidokKalendarza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Twój kalendarz</title>
    <link href="Styl.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" runat="server">
         <div draggable="auto">
            <asp:Calendar ID="Kalendarz" runat="server" OnSelectionChanged="Kalendarz_SelectionChanged"  DayRender="Kalendarz_DayRender" Height="238px" Width="1160px"></asp:Calendar>
            <p style="font-size: 12px; font-family: sans-serif;"><a href="https://localhost:44360/ListaToDo.aspx">LISTA TO DO</a></p>
            <asp:Button ID="DodajWydarzenieButton" runat="server" Text="Dodaj wydarzenie" Visible="false" OnClick="DodajWydarzenieButton_Click" />
            <asp:Label ID="NazwaLabel" runat="server" Text="Nazwa:      " Visible="false" ></asp:Label><asp:TextBox ID="NazwaBox" runat="server" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="DataLabel" runat="server" Text="Data:     " Visible="false" ></asp:Label><asp:TextBox ID="DataBox" runat="server" TextMode="Date" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="GodzinaLabel" runat="server" Text="Godzina:     " Visible="false" ></asp:Label><asp:TextBox ID="GodzinaBox" runat="server" TextMode="Time" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="OpisLabel" runat="server" Text="Opis:     " Visible="false"></asp:Label><asp:TextBox ID="OpisBox" runat="server" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="MiejsceLabel" runat="server" Text="Miejsce:     " Visible="false"></asp:Label><asp:TextBox ID="MiejsceBox" runat="server" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="KategoriaLabel" runat="server" Text="Kategoria:     " Visible="false"></asp:Label><asp:TextBox ID="KategoriaBox" runat="server" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="GoscieLabel" runat="server" Text="Goście:     " Visible="false"></asp:Label><asp:TextBox ID="GoscieBox" runat="server" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="NotatkaLabel" runat="server" Text="Notatka:     " Visible="false"></asp:Label><asp:TextBox ID="NotatkaBox" runat="server" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="KolorLabel" runat="server" Text="Kolor:     " Visible="false"></asp:Label><asp:TextBox ID="KolorBox" runat="server" TextMode="Color" Visible="false"></asp:TextBox><br/>
            <asp:Label ID="PriorytetLabel" runat="server" Text="Prioryet:     " Visible="false"></asp:Label><asp:TextBox ID="PriorytetBox" runat="server" TextMode="Number" Visible="false" Min="1" Max="10"></asp:TextBox><br />
            <asp:Button ID="ZapiszButton" runat="server" Text="Zapisz" Visible="false" OnClick="ZapiszButton_Click" />
            <asp:Label ID="InfoLabelDW" runat="server" Text=""></asp:Label>
        </div>
        <!--       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
             <Columns>
                 <asp:BoundField DataField="Nazwa" HeaderText="Nazwa" ReadOnly="True" SortExpression="Nazwa" />
                 <asp:BoundField DataField="Data" HeaderText="Data" ReadOnly="True" SortExpression="Data" />
                 <asp:BoundField DataField="Opis" HeaderText="Opis" ReadOnly="True" SortExpression="Opis" />
                 <asp:BoundField DataField="Godzina" HeaderText="Godzina" ReadOnly="True" SortExpression="Godzina" />
                 <asp:BoundField DataField="Miejsce" HeaderText="Miejsce" ReadOnly="True" SortExpression="Miejsce" />
                 <asp:BoundField DataField="Kategoria" HeaderText="Kategoria" ReadOnly="True" SortExpression="Kategoria" />
                 <asp:BoundField DataField="Priorytet" HeaderText="Priorytet" ReadOnly="True" SortExpression="Priorytet" />
                 <asp:BoundField DataField="Notatka" HeaderText="Notatka" ReadOnly="True" SortExpression="Notatka" />
                 <asp:BoundField DataField="Goscie" HeaderText="Goscie" ReadOnly="True" SortExpression="Goscie" />
             </Columns>
         </asp:GridView>
         <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="AppCalendar.DataClasses2DataContext" EntityTypeName="" Select="new (Nazwa, Data, Opis, Godzina, Miejsce, Kategoria, Priorytet, Notatka, Goscie)" TableName="Tabela_Wydarzenia" Where="Data == @Data">
             <WhereParameters>
                 <asp:ControlParameter ControlID="Kalendarz" Name="Data" PropertyName="SelectedDate" Type="DateTime" />
             </WhereParameters>
         </asp:LinqDataSource> -->
    </form>
</body>
</html>

