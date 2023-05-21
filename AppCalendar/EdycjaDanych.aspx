﻿<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeBehind="EdycjaDanych.aspx.cs" Inherits="AppCalendar.EdycjaDanych" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Edycja Danych</title>
    <link href="Styl.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div draggable="auto">
             <asp:Label ID="NazwaLabel" runat="server" Text="Nazwa:      " Visible="true" ></asp:Label><asp:TextBox ID="NazwaBox" runat="server" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="DataLabel" runat="server" Text="Data:     " Visible="true" ></asp:Label><asp:TextBox ID="DataBox" runat="server" TextMode="Date" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="GodzinaLabel" runat="server" Text="Godzina:     " Visible="true" ></asp:Label><asp:TextBox ID="GodzinaBox" runat="server" TextMode="Time" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="OpisLabel" runat="server" Text="Opis:     " Visible="true"></asp:Label><asp:TextBox ID="OpisBox" runat="server" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="MiejsceLabel" runat="server" Text="Miejsce:     " Visible="true"></asp:Label><asp:TextBox ID="MiejsceBox" runat="server" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="KategoriaLabel" runat="server" Text="Kategoria:     " Visible="true"></asp:Label><asp:DropDownList ID="KategoriaList" runat="server"  Visible="true"></asp:DropDownList><br/>
            <asp:Label ID="GoscieLabel" runat="server" Text="Goście:     " Visible="true"></asp:Label><asp:TextBox ID="GoscieBox" runat="server" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="NotatkaLabel" runat="server" Text="Notatka:     " Visible="true"></asp:Label><asp:TextBox ID="NotatkaBox" runat="server" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="KolorLabel" runat="server" Text="Kolor:     " Visible="true"></asp:Label><asp:TextBox ID="KolorBox" runat="server" TextMode="Color" Visible="true"></asp:TextBox><br/>
            <asp:Label ID="PriorytetLabel" runat="server" Text="Prioryet:     " Visible="true"></asp:Label><asp:TextBox ID="PriorytetBox" runat="server" TextMode="Number" Visible="true" Min="1" Max="10"></asp:TextBox><br />
        </div>
        <asp:Button ID="ZapiszEdit" runat="server" OnClick="ZapiszEdit_Click" Text="Zapisz" />
    </form>
</body>
</html>
