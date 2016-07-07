<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title> Sign Up ! </title>
     <link  href="gamestyle_old_version1.css" type="text/css" rel="stylesheet" />
     <script src="stevejs.js"> </script>


<link href="gamestyle_old_version1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="bodydivision" style="width: 706px"> 
    
     <table cellpadding="0" cellspacing="0" style="width: 586px">
     <tr>  <!-- left section -->
     <td style="width: 143px">
             <div id="idTG" style="width: 147px; height: 808px">
     
                                                     <font face="Verdana" size="1">
                Top Games
                                                     </font><font color="yellow" face="Verdana" size="1">
                                                         <table>
                                                             <tr>
                                                                 <td style="width: 33px; height: 35px">
                                                                     <img id="Img2" src="Images/GoldenStar.gif" />
                                                                 </td>
                                                                 <td style="height: 35px" valign="bottom">
                                                                     Bejewled 
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td style="width: 33px; height: 25px">
                                                                     <img id="Img1" src="Images/GoldenStar_blue .gif" />
                                                                 </td>
                                                                 <td style="height: 25px" valign="bottom">
                                                                      <a href="games/cube_buster.html"> Cube Buster </a> 
                                                                  
                                                                  </td>
                                                             </tr>
                                                             <tr>
                                                                 <td style="width: 33px">
                                                                     <img id="Img3" src="Images/GoldenStar_blue .gif" />
                                                                 </td>
                                                                 <td valign="bottom">
                                                                   <a href="games/reelgold.html"> Gold Reel </a> 
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td style="width: 33px">
                                                                     <img id="Img4" src="Images/GoldenStar_blue .gif" />
                                                                 </td>
                                                                 <td valign="bottom">
                                                                      <a href="games/minicliprally.html"> MiniClipRally </a>  
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td style="width: 33px">
                                                                     <img id="Img5" src="Images/GoldenStar_blue .gif" />
                                                                 </td>
                                                                 <td valign="bottom">
                                                                     
                                                                      <a href="games/kingofthehill.html"> King of the Hill </a> 
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                                 <td style="width: 33px">
                                                                     <img id="Img6" src="Images/GoldenStar_blue .gif" />
                                                                 </td>
                                                                 <td valign="bottom">
                                                                   <a href="games/flashman.html"> Flash Man </a> 
                                                                 </td>
                                                             </tr>
                                                             <tr>
                                                             </tr>
                                                         </table>
                                                     </font>
                                                  
                                                     <table>
                                                         <tr>
                                                             <td style="width: 144px">
                    &nbsp;&nbsp; Game List&nbsp;<br />
                                                                 <asp:DropDownList ID="DropDownList2" runat="server" Width="132px">
                                                                     <asp:ListItem>Find All Games</asp:ListItem>
                                                                 </asp:DropDownList></td>
                                                         </tr>
                                                     </table>
                                                     
                                  
                                                 </div> <!-- end of the listing of the top ten games -->
               </td> <!-- end of left bar -->
                
               <td style="width: 419px"> 
               
                        <div id="Div1" style="width: 381px; height: 808px">
                            <table id="TABLE1" align="left" cellpadding="0" cellspacing="0" style="width: 368px">
                                <tbody>
                                    <tr>
                                        <td style="width: 447px; height: 7px">
                                            <div>
                                                <img align="absBottom" src="Images/newMemberLabel.gif" style="width: 170px" />
                                            </div>
                                            <div>
                                                Becoming a member with us is quick and easy.
                                                <br />
                                                Just fill out the information below and you will be about<br />
                                                to download games , create a personal profile and get<br />
                                                access to new game and features when they become<br />
                                                available.&nbsp;</div>
                                            <table cellpadding="0" cellspacing="0" style="width: 326px">
                                                
                                                <tr>
                                                    <td style="width: 170px">
                                                        username
                                                    </td>
                                                    <td style="width: 160px">
                                                        <asp:TextBox ID="username" runat="server" Height="14px" MaxLength="20" Width="132px"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 170px; height: 22px;">
                                                        password
                                                    </td>
                                                    <td style="width: 160px; height: 22px;">
                                                        <asp:TextBox ID="password" runat="server" Height="14px" MaxLength="20" TextMode="Password"
                                                            Width="132px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            
                                                <tr>
                                                    <td style="width: 170px">
                                                        <div>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username"
                                                                Display="Dynamic" ErrorMessage="*username is required" Width="151px"></asp:RequiredFieldValidator>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 170px">
                                                        <div>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password"
                                                                Display="Dynamic" ErrorMessage="* password is required" Width="151px"></asp:RequiredFieldValidator>
                                                        </div>
                                                    </td>
                                                </tr>
                                        
                                                <tr>
                                                    <td style="width: 170px">
                                                        <div>
                                                            <asp:Label ID="userexistLabel" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                                                        </div>
                                                    </td>
                                                </tr>
                                          
                                                <tr>
                                                    <td style="width: 170px">
                                                        <div>
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="username"
                                                                Display="Dynamic" ErrorMessage="* Invalid username length" ValidationExpression="^[A-Za-z]+[A-Z|a-z|0-9]*[^!%]{3,20}$"></asp:RegularExpressionValidator></div>
                                                    </td>
                                                </tr>
                                                <tr style="color: #000000">
                                                    <td style="width: 170px">
                                                        <div>
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="password"
                                                                Display="Dynamic" ErrorMessage="* Invalid password length" ValidationExpression="^[A-Za-z]+[A-Z|a-z|0-9]*[^!%]{3,20}$"></asp:RegularExpressionValidator></div>
                                                    </td>
                                                </tr>
                                            </table>
                                            <table style="width: 310px; color: #0000ff; height: 24px;">
                                                <tr>
                                                    <td>
                                                        Country :
                                                    </td>
                                                    <td style="width: 336px; height: 10px">
                                                        <asp:DropDownList ID="countrylist" runat="server" Width="136px">
                                                            <asp:ListItem>USA</asp:ListItem>
                                                            <asp:ListItem>Canada</asp:ListItem>
                                                            <asp:ListItem>United Kingdom</asp:ListItem>
                                                            <asp:ListItem>Mexico</asp:ListItem>
                                                            <asp:ListItem>Nigeria</asp:ListItem>
                                                            <asp:ListItem>Pakistan</asp:ListItem>
                                                            <asp:ListItem>South Africa</asp:ListItem>
                                                            <asp:ListItem>Japan</asp:ListItem>
                                                            <asp:ListItem>Other</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                </tr>
                                            
                                                <tr>
                                                    <td style="width: 109671px; height: 2px">
                                                        Age :
                                                    </td>
                                                    <td style="width: 336px; height: 2px">
                                                        <asp:DropDownList ID="agelist" runat="server" Height="18px" Width="137px">
                                                            <asp:ListItem>8-12</asp:ListItem>
                                                            <asp:ListItem>13-18</asp:ListItem>
                                                            <asp:ListItem>19-25</asp:ListItem>
                                                            <asp:ListItem>26-35</asp:ListItem>
                                                            <asp:ListItem>36-55</asp:ListItem>
                                                            <asp:ListItem>56 or greater</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                </tr>
                                           
                                            </table>
                                       
                                            
                                              <table>
                                                <tr>
                                                    <td>
                                                        send gameparadox news</td>
                                                    <td>
                                                        &nbsp;&nbsp;&nbsp;
                                                        <asp:CheckBox ID="joincheckbox" runat="server" Text="Join" /></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        favorite game genre
                                                    </td>
                                                    <td>
                                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:DropDownList ID="genrelist" runat="server" Width="150px">
                                                            <asp:ListItem>Advenuture</asp:ListItem>
                                                            <asp:ListItem>Puzzle</asp:ListItem>
                                                            <asp:ListItem>Retro</asp:ListItem>
                                                            <asp:ListItem>Action</asp:ListItem>
                                                            <asp:ListItem>Sports</asp:ListItem>
                                                            <asp:ListItem>None</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                </tr>
                                            </table>
                                            
                                            <table style="width: 90px">
                                            
                                            <tr>
                                            
                                            <td style="width: 50px">
                                            
                                            email 
                                            </td>
                                            
                                            <td style="width: 8px">
                                                <asp:TextBox ID="email" runat="server" Width="100px" ></asp:TextBox>
                                            </td>
                                            
                                           
                                            
                                            </tr>
                                            
                                      
                                           
                                           
                                             <tr>
    
    <td style="width: 80px">
    <div>
     <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator5" runat="server" ErrorMessage="* Email is required "
     Width="127px" ControlToValidate="email"></asp:RequiredFieldValidator>
    </div>
    </td>
    
    </tr>
  
    
     <tr>
    <td style="width: 80px">
    <div>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Invalid email" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Width="169px"></asp:RegularExpressionValidator>
    </div>
    </td>
    </tr>

    
    <tr>
<td style="width: 80px">
 <div>
   <asp:RegularExpressionValidator  ValidationExpression="^[A-Za-z]+[A-Z|a-z|0-9]*[^!%]{3,50}$" ID="RegularExpressionValidator4" runat="server"
         ErrorMessage="* Invalid email  length" ControlToValidate="email" Display="Dynamic" Width="160px"></asp:RegularExpressionValidator></div>
</td>

</tr>
                                            </table>
                                            
                                            <br />
                                            <table>
                                                <tr>
                                                    <td style="width: 284px; height: 13px">
                                                        By clicking "Register" you agree to the terms and condition at Gamepardox.com
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 284px">
                                                        <a href="terms.aspx">View Terms &amp; Condition </a>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 284px">
                                                        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" /></td>
                                                </tr>
                                            </table>
                                            <asp:Label ID="Label2" runat="server"></asp:Label><br />
                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">HyperLink</asp:HyperLink></td>
                                    </tr>
                                </tbody>
                            </table>
     
                          
                                                     
                                  
                       </div>
               </td>
                  
               </tr> 
              
              
             
               </table>    
               
                          
                                                 
 </div> <!-- end of the body division right here -->
    
    
    </form>
</body>
</html>
