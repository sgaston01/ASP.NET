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

public partial class LoghtmlLink : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
         GPMainClass main = new GPMainClass(); 
         string link = Request.QueryString["link"].ToString();
         string junk =  Request.RawUrl.ToString();
         string address = Request.ServerVariables["REMOTE_ADDR"].ToString();
         main.gp_StoreTrackerEvent(address, "user clicked html link", link ,DateTime.Now);

    }
}
