﻿<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeBehind="ListaToDo.aspx.cs" Inherits="AppCalendar.ListaToDo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Twoja ListaToDo</title>
    <link href="Styl.css" rel="stylesheet" type="text/css" />
</head>
<body>
   <p style="font-size: 16px; font-family: sans-serif; font-weight: bold;">TWOJA LISTA TO DO:</p>
<form id="form1" runat="server">
<asp:ListView ID="ListView" runat="server" DataKeyNames="Id">
    <ItemTemplate>
    <ul>
        <li <%# Convert.ToDateTime(Eval("Data")).Date < DateTime.Now.Date ? "style=\"text-decoration: line-through\"" : "" %>>
            <strong>Nazwa: </strong> <%# Eval("Nazwa") %> <br />
            <strong>Data: </strong> <%# Eval("Data", "{0:d}") %> <br />
            <strong>Godzina: </strong> <%# Eval("Godzina", "{0:t}") %> <br />
            <strong>Opis: </strong> <%# Eval("Opis") %> <br />
            <strong>Miejsce: </strong> <%# Eval("Miejsce") %> <br />
            <strong>Goście: </strong> <%# Eval("Goscie") %> <br />
            <strong>Notatka: </strong> <%# Eval("Notatka") %> <br />
            <strong>Kolor: </strong><span style="color:<%# Eval("Kolor").ToString() %>"><%# Eval("Kolor") %></span> <br />
            <strong>Priorytet: </strong> <span style="font-weight:bold; color:red"><%# Eval("Priorytet") %></span><br/>
            <asp:Panel runat="server" Visible='<%# Convert.ToDateTime(Eval("Data")).Date < DateTime.Now.Date %>'>
                <asp:Button ID="UsunButtonWM" runat="server" Text="Usuń" OnClick="UsunButtonW_Click" CommandArgument='<%# Eval("Id") %>' />
            </asp:Panel>
            <asp:Panel runat="server" Visible='<%# Convert.ToDateTime(Eval("Data")).Date >= DateTime.Now.Date %>'>
                <asp:Button ID="EdytujButtonW" runat="server" Text="Edytuj" OnClick="EdytujButtonW_Click" CommandArgument='<%# Eval("Id") %>' />
                <asp:Button ID="UsunButtonW" runat="server" Text="Usuń" OnClick="UsunButtonW_Click" CommandArgument='<%# Eval("Id") %>' />
                <asp:TextBox ID="WpisznNoweDaneBox" runat="server" Visible="false" Text='<%# Eval("Nazwa") %>' />
                <asp:Button  ID="ZapiszEdycjeButtonW" runat="server" Text="Zapisz" Visible="false" OnClick="ZapiszEdycjeButtonW_Click" CommandArgument='<%# Eval("Id") %>' />
            </asp:Panel>
        </li>
    </ul>
</ItemTemplate>
</asp:ListView>
</form>
</body>
</html>
