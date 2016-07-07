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
using System.Data.Sql;
using System.Data.SqlClient;
using gpclass;



public partial class gamesearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         
        string tracking = ConfigurationManager.AppSettings["tracking"].ToString();
        if (tracking == "true")
        {
            String remote_address = Request.ServerVariables["REMOTE_ADDR"];
            String path = Request.Path;
            GPMainClass main = new GPMainClass();
            //main.gp_StoreTrackerEvent( 
            main.gp_StoreTrackerEvent(remote_address, "Page Search" , path, DateTime.Now);
        }



        if ( Page.IsPostBack == false)
        {
            //means were are going to load the page for the first time 
            try
            {
                String Title = Request.QueryString["Game"];
                //String TDownload = Request.QueryString["Download"];
                //String TOnline = Request.QueryString["Online"];
                //String TImg = Request.QueryString["Img"];

                String query = "select * from gamelocation where gamename like " + "'" + Title + "%'";

                String con = ConfigurationManager.AppSettings["connectionString"].ToString();


                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds);

                String value;
                value = ds.GetXml();

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }

            catch (Exception ex)
            {
                string mess;
                mess = ex.Message;

            }

        }
         







    }
}
