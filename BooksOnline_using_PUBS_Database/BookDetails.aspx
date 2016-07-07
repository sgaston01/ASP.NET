<%@ Page Language="VB" AutoEventWireup="true" CodeFile="BookDetails.aspx.vb" Inherits="BookDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> Book Details </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label" Width="221px"></asp:Label></div>
       
        <asp:GridView  AlternatingRowStyle-BackColor=Coral ID="GridView1" runat="server" Height="300px" width="1411px" AutoGenerateColumns="False">
     
         <Columns>
         
         <asp:BoundField DataField="Title" HeaderText="Title" >
             <ItemStyle Height="80px" Width="200px" />
             <HeaderStyle Width="160px" />
         </asp:BoundField>
         <asp:BoundField DataField="type" HeaderText="Type" >
             <ItemStyle Height="80px" Width="200px" />
         </asp:BoundField>
         <asp:BoundField DataField="pub_id" HeaderText="ID" >
             <ItemStyle Height="80px" Width="200px" />
         </asp:BoundField>
         <asp:BoundField DataField="price" HeaderText="Price" >
             <ItemStyle Height="80px" Width="200px" />
         </asp:BoundField>
         <asp:BoundField DataField="advance" HeaderText="Advance" >
             <ItemStyle Height="80px" Width="200px" />
         </asp:BoundField>
         <asp:BoundField DataField="royalty" HeaderText="Royalty" >
             <ItemStyle Height="80px" Width="200px" />
         </asp:BoundField>
         <asp:BoundField DataField="ytd_sales" HeaderText="YieldSales" >
             <ItemStyle Height="80px" Width="200px" />
         </asp:BoundField>
         <asp:BoundField DataField="notes"  HeaderText="Notes" >
             <ItemStyle Height="80px" Width="200px" />
             <HeaderStyle Width="90px" />
         </asp:BoundField>
         <asp:BoundField DataField="pubdate" HeaderText="PubDate" >
             <ItemStyle Height="80px" Width="160px" />
             <HeaderStyle Width="160px" />
         </asp:BoundField>
         <asp:BoundField DataField="pub_name"  HeaderText="PublisherName" >
            
              <ItemStyle Width="260px" HorizontalAlign="Center" />
             <HeaderStyle HorizontalAlign="Center" Width="350px" />
             
         </asp:BoundField>
         <asp:BoundField DataField="city" HeaderText="City" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         <asp:BoundField DataField="state" HeaderText="State" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         <asp:BoundField DataField="country" HeaderText="Country" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         <asp:BoundField DataField="au_id" HeaderText="AuthorID" >
             <ItemStyle Height="160px" Width="380px" />
             <HeaderStyle Width="380px" />
            
         </asp:BoundField>
         <asp:BoundField DataField="title_id" HeaderText="title_id" >
             <ItemStyle Height="80px" Width="200px" />
             <HeaderStyle Width="160px" />
         </asp:BoundField>
         <asp:BoundField DataField="au_ord" HeaderText="AuthorOrd" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
       
         <asp:BoundField DataField="au_id" HeaderText="AuthorID" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="au_lname" HeaderText="AuthorLast" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="au_fname" HeaderText="AuthorFirst" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="phone" HeaderText="Phone" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="address" HeaderText="Address" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="city" HeaderText="City" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="state" HeaderText="State" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="zip" HeaderText="Zip" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
          <asp:BoundField DataField="contract" HeaderText="contract" >
             <ItemStyle Height="80px" Width="100px" />
         </asp:BoundField>
         
         </Columns>
            <AlternatingRowStyle BackColor="Coral" />
         
       
        </asp:GridView>
        &nbsp;<%
         
       
       %> 
        <asp:GridView ID="GridView2" runat="server" Width="825px" Height="182px">
        </asp:GridView>
        
    
    </form>
</body>
</html>
