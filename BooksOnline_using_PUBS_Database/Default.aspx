<%@ Page Language="VB"  EnableViewState="true" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> BOOKS ONLINE </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      
      <H1 align="center"> WELCOME TO PUBS BOOKS ONLINE </H1>
        <p>
            &nbsp;</p>
        <p> 
            <table border="0">
            <tr>
            
              <td>
              <img src="NavImage.gif" />
             
             </td>
             
          
             
             
             
            </tr>
            
            
            <tr>
            
               <td align="left" style="height: 74px">
               
            <asp:BulletedList DataTextField="pub_name" DataValueField="pub_id" DisplayMode="LinkButton" DataSourceID="SqlDataSource1" ID="BulletedList1" runat="server" Height="54px" Width="186px"  BorderColor="Lime">
            
            </asp:BulletedList>
                   &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                   <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="DodgerBlue">HyperLink</asp:HyperLink></td>
            </tr>
            
            </table>

        </p>
        <p>
            
         
            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PubsConnectionString %>"
                SelectCommand="SELECT * FROM [publishers]"></asp:SqlDataSource>
            &nbsp;
        </p>
    </div>
    
    
    
    
    
    </form>
</body>
</html>
