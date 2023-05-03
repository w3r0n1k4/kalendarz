<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaToDo.aspx.cs" Inherits="AppCalendar.ListaToDo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Twoja ListaToDo</title>
    <link href="Styl.css" rel="stylesheet" type="text/css" />
</head>
<body>
   <p style="font-size: 16px; font-family: sans-serif; font-weight: bold;">TWOJA LISTA TO DO:</p>
<asp:ListView ID="ListView" runat="server">
    <ItemTemplate>
        <ul>
            <li <%# Convert.ToDateTime(Eval("Data")).Date < DateTime.Now.Date ? "style=\"text-decoration: line-through\"" : "" %>>
                <strong>Nazwa:</strong> <%# Eval("Nazwa") %> <br />
                <strong>Data:</strong> <%# Eval("Data", "{0:d}") %> <br />
                <strong>Godzina:</strong> <%# Eval("Godzina", "{0:t}") %> <br />
                <strong>Opis:</strong> <%# Eval("Opis") %> <br />
                <strong>Miejsce:</strong> <%# Eval("Miejsce") %> <br />
                <strong>Kategoria:</strong> <%# Eval("Kategoria") %> <br />
                <strong>Goście:</strong> <%# Eval("Goscie") %> <br />
                <strong>Notatka:</strong> <%# Eval("Notatka") %> <br />
                <strong>Kolor:</strong> <%# Eval("Kolor") %> <br />
                <strong>Priorytet:</strong> <span style="font-weight:bold; color:red"><%# Eval("Priorytet") %></span><br/>
            </li>
        </ul>
    </ItemTemplate>
</asp:ListView>

</body>
</html>
