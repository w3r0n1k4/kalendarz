<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="AppCalendar.Logowanie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Logowanie</title>
    <link href="Styl.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="STRONA">
        <div class="BOX">
        <p style="font-size: 43px;font-family: sans-serif; text-align: initial;">LOGOWANIE</p>
            <table style="width: 100%;">
            <tbody style="font-family: sans-serif;">
                <tr>
                    <td stle="padding: 18px; ">E-mail: </td>
                    <td>
                        <asp:TextBox ID="EmailBoxL" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td stle="padding: 18px; ">Hasło: </td>
                    <td><asp:TextBox ID="HasloBoxL" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="ZalogujButton" runat="server" class="BUTTON" Text="Zaloguj" OnClick="ZalogujButton_Click" /></td>
                </tr>
            </tbody>
            </table>
            <asp:Label ID="InfoLabelL" runat="server" Text=""></asp:Label>
        </div>
        </div>
    </form>
</body>

</html>
