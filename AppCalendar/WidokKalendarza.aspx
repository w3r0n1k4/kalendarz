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
        <div>
            <asp:Calendar ID="Kalendarz" runat="server" OnSelectionChanged="Kalendarz_SelectionChanged"></asp:Calendar>
        </div>
    </form>
</body>
</html>

