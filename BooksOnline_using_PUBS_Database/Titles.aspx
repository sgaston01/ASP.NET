<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Titles.aspx.vb" Inherits="Titles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Titles Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
     
        <asp:BulletedList  BulletStyle="Numbered"  DisplayMode="LinkButton" DataTextField="Title" DataValueField="title_id" ID="BulletedList1" runat="server" Width="109px">
              
        </asp:BulletedList>
        
        
    </div>
    </form>
</body>
</html>
