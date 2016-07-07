<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gamesearch.aspx.cs" Inherits="gamesearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Game Search </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
     <%
         Response.Write("Game Search Result : ");
        //  String Title = Request.QueryString["Title"];
        //  String TDownload = Request.QueryString["Download"];
        //  String TOnline   = Request.QueryString["Online"];
        //  String TImg      = Request.QueryString["Img"];
        // Response.Write("<table>" + "<tr>" + "<td>" + Title + "</td> </tr>" + "<tr> <td> " + "<a href=" + "'" + TOnline + "'" + ">" + "Online" +"</a> </td> </tr>" + "<tr> <td>" + "<a href=" + TDownload + "/>" + "Download" + "</a> </td> </tr>" + "<tr><td> <img src=" + TImg + " </img> </td>" + "</tr> </table>");
        //Response.Redirect("http://localhost:2747/gameparadox/gamesearch.aspx?Game="+game + "&Online=" + htmlOnline + "&Download=" + htmlDownload + "&Img=" + image );
        //Response.Redirect("http://localhost:2747/gameparadox/gamesearch.aspx?Game=" + game + "&Online=" + htmlOnline + "&Download=" + htmlDownload);

         
     %>
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="535px" Height="70px" BackColor="ActiveCaptionText" BorderColor="ActiveCaption">
            <Columns>
               
                <asp:BoundField DataField="GameName" HeaderText="Game" />
                <asp:HyperLinkField  DataNavigateUrlFields="HtmlName" HeaderText="Download" Text="Download"/>
                <asp:HyperLinkField HeaderText="Online"  DataNavigateUrlFields="HtmlOnline" Text="Online" />
                <asp:ImageField DataImageUrlField="SmallImage">
                </asp:ImageField>
            </Columns>
            <AlternatingRowStyle BackColor="#FF8000" BorderColor="DodgerBlue" />
        </asp:GridView>
        
        
        <% 
            Response.Write("Return to Home Page <br>");
            Response.Write("<a href=http://www.gameparadox.com> Home Page </a>");        
        %>
    
    
    
    </form>
</body>
</html>
