using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using gpclass; 

public partial class AllGames : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {   



        //save user event to the datebase 
        if (Page.IsPostBack == false)
        {
            string tracking = ConfigurationManager.AppSettings["tracking"].ToString();
            if (tracking == "true")
            {
                String remote_address = Request.ServerVariables["REMOTE_ADDR"];
                String path = Request.Path;
                GPMainClass main = new GPMainClass();
                main.gp_StoreTrackerEvent(remote_address, "", path, DateTime.Now);
            }
        } 

        //Url url = Request.Url;
     




     string login = Session["login"] as string;
         //Session.Add("login", "

    /*
       if (login == null)
        {
            string raw = Request.RawUrl;

            string click = Request.QueryString["click"];

            if (click == "mdownload")
            {
                //Response.Write("Not logged in ");
                Response.Redirect("Login.aspx?click="+click, true);
               

            }//means the user clicked on more download hyperlink 
            //so when indicate to the user to login to download more games 
            //string res = Response.RedirectLocation.ToString();
            else
            {
              Response.Redirect("Login.aspx");
            }
        }
      */ 
        // a call to the server needs to be about to fetch the locations for the images 
        // and the hyperlinks that will be displayed on the screen  
        // also i need some type of script that will read in the the locations into the 
        // database 


       //  Response.Redirect("http://localhost:2747/gethint.aspx
       //  this.RegisterStartupScript(
       //  this.R


       // this.Load += new System.EventHandler(this.Page_Load);
      //  SendScript(sender, e);
       string var = Session["firstview"] as string;

        if (var == null)
        {
            Session.Add("firstview", "false");
        }

        var =  Session["firstview"] as string;
        if (!IsPostBack && var == "false" )
        {

             //the call the script code now 
      
            SendScript(sender, e);

            Session.Add("firstview", "true");
        }
        else if (var == "true")
        {

            SendScript1(sender, e);

        }
       
      
    }

    public void SendScript(object sender, System.EventArgs e)
    {


        /*
        <script Language="C#" runat="server">
private void Page_Load(object sender, System.EventArgs e)
{
if (!IsPostBack)
{


String scriptString = "<script language=JavaScript> " + Environment.NewLine;
scriptString += "alert('Hello!');" + Environment.NewLine;
scriptString += "function Page_Load()";
scriptString += "{window.open('http://www.csharpcorner.com/','mywindow','width=400,height=200')}";
scriptString += "<";
scriptString += "/";
scriptString += "script>";
if(!this.IsStartupScriptRegistered("Startup"))
this.RegisterStartupScript("Startup", scriptString);

scriptString = "<script language=JavaScript> function ShowMsg() {";
scriptString += "Form1.show.value='.NET Client Side Script'}<";
scriptString += "/";
scriptString += "script>";

if(!this.IsClientScriptBlockRegistered("clientScript"))
this.RegisterClientScriptBlock("clientScript", scriptString);
}
}
</script>
 */


        String scriptString = "<script language=JavaScript> " + Environment.NewLine;
       // scriptString += "alert('this sucks alot !');" + Environment.NewLine;
        scriptString += "function Page_Load()";
        //scriptString += "{window.open('http://www.csharpcorner.com/','mywindow','width=400,height=200')}";
        scriptString += "{allgames(0)}";
        scriptString += "<";
        scriptString += "/";
        scriptString += "script>";
        if (!this.IsStartupScriptRegistered("Startup"))
            this.RegisterStartupScript("Startup", scriptString);

        /*scriptString = "<script language=JavaScript> function ShowMsg() {";
        scriptString += "Form1.show.value='.NET Client Side Script'}<";
        scriptString += "/";
        scriptString += "script>";
 
        this.RegisterStartupScript("SendScript", scriptString);

        if (this.IsStartupScriptRegistered("SendScript"))
        {
            bool x = this.IsStartupScriptRegistered("SendScript"); 
        }*/
        



     
 /*       this.RegisterStartupScript("SendScript",Script))
        {
            this.RegisterStartupScript("SendScript",Script);
        }
        */

    }







    public void SendScript1(object sender, System.EventArgs e)
    {


        String scriptString = "<script language=JavaScript> " + Environment.NewLine;
       // scriptString += "alert('this sucks alot !');" + Environment.NewLine;
        scriptString += "function Page_Load()";



        string index = Session["index"] as string;

        string c = Cache["ajaxResult"] as string;
       // cacheItems(c)
 
       //  scriptString += "{cacheItems("  + c + ")}";
      //scriptString += "{document.getElementById(ajaxout).innerHTML=" + c + ")}";;
      scriptString += "{allgames(" + index  + ")}";
      //  scriptString += "{window.open('http://www.csharpcorner.com/','mywindow','width=400,height=200')}";
        scriptString += "";
        scriptString += "<";
        scriptString += "/";
        scriptString += "script>";
        if (!this.IsStartupScriptRegistered("Startup"))
            this.RegisterStartupScript("Startup", scriptString);

        /*scriptString = "<script language=JavaScript> function ShowMsg() {";
        scriptString += "Form1.show.value='.NET Client Side Script'}<";
        scriptString += "/";
        scriptString += "script>";
 
        this.RegisterStartupScript("SendScript", scriptString);

        if (this.IsStartupScriptRegistered("SendScript"))
        {
            bool x = this.IsStartupScriptRegistered("SendScript"); 
        }*/





        /*       this.RegisterStartupScript("SendScript",Script))
               {
                   this.RegisterStartupScript("SendScript",Script);
               }
               */

    }



    
}
