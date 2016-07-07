using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

//includes need sending an email from the server 
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Web.Mail;

using gpclass;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    }


            

    protected void SendConfirmMail()
    {
        try
        {
            string body = "We are extremely excited that you registered with us. Now that you have registered its time to play some games. And new games and features are coming soon from GameParadox.com. <BR>";
            body += "Your username is " + username.Text + " and password is <B> " + password.Text + "</B>";
            body += "<BR> <BR> To cancel your account send an email to suppport@gameparadox.com .";
            string message = "Welcome to GameParadox.com";
            const string SERVER = "relay-hosting.secureserver.net";
            MailMessage oMail = new System.Web.Mail.MailMessage();
            oMail.From = "registration@gameparadox.com";
            oMail.To = email.Text;
            oMail.Bcc = "sgaston01@yahoo.com";
            oMail.Subject = message;
            oMail.BodyFormat = MailFormat.Html; // enumeration
            oMail.Priority = MailPriority.High; // System.Net.Mail.MailPriority;// MailPriority.High; // enumeration
            //oMail.Body = "Sent at: " + DateTime.Now;
            oMail.Body = body;
            SmtpMail.SmtpServer = SERVER;
            SmtpMail.Send(oMail);
            oMail = null; // free up resources
        }

        catch (Exception ex)
        {
            // string error = ex.Message;
            // Label1.Text = error;
            string mess = ex.Message;

            Session.Add("message", mess);

            Response.Redirect("http://www.gameparadox.com/Error.aspx");
        }

    }


    void createNewUser(String username, String password)
    {

        DataSet ds = null;

        try
        {
            ds = new DataSet();
            string connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();

            //string connectionString = ConfigurationManager.AppSettings["connectionStringLocal"].ToString();
            string createuser = ConfigurationManager.AppSettings["createuser"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            //SqlParameter parameter = new SqlParameter("@username", username.Text);
            //SqlParameter parameter = new SqlParameter("@u", username.Text);
            command.Parameters.Add("@username", username);
            command.Parameters.Add("@password", password);


            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = createuser;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(ds);
        }

        catch (Exception ex)
        {
            string mess = ex.Message;

            Session.Add("message", mess);

            Response.Redirect("http://www.gameparadox.com/Error.aspx");
        }

        Label2.Text = "YOU ACCOUNT HAS BEEN CREATED "; // +username + " " + password;
        HyperLink1.Visible = true;
        HyperLink1.Text = "<< Home Page";
        //send an alert email 

        //Alert_Message("New User Added !!! ", " Created new user account for " + username);


    }


    protected void addRegisterUser(string username, string password, string country,
                                   int zip, string age, string email, bool newgroup,
                                    string favorite_genre, DateTime time)
    {


        DataSet ds = null;

        try
        {
            ds = new DataSet();
            string connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();

            //string connectionString = ConfigurationManager.AppSettings["connectionStringLocal"].ToString();
            string createuser = ConfigurationManager.AppSettings["addregistereduser"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            //SqlParameter parameter = new SqlParameter("@username", username.Text);
            //SqlParameter parameter = new SqlParameter("@u", username.Text);
            command.Parameters.Add("@username", username);
            command.Parameters.Add("@password", password);
            command.Parameters.Add("@country", country);
            command.Parameters.Add("@zip", zip);
            command.Parameters.Add("@age", age);
            command.Parameters.Add("@email", email);
            command.Parameters.Add("@newgroup", newgroup);
            command.Parameters.Add("@favorite_genre", favorite_genre);
            command.Parameters.Add("@date", time);

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = createuser;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(ds);
        }

        catch (Exception ex)
        {

            string mess = ex.Message;

            Session.Add("message", mess);

            Response.Redirect("http://www.gameparadox.com/Error.aspx");

        }




    }



    protected void Button1_Click(object sender, EventArgs e) //this submit button
    {



        //check to see if the user is in the database 
        //if the new user in not in the database then at the new user 
        //if not prompt them that the user name is taken 

        //


     
            string tracking = ConfigurationManager.AppSettings["tracking"].ToString();
            if (tracking == "true")
            {
                String remote_address = Request.ServerVariables["REMOTE_ADDR"];
                String path = Request.Path;
                GPMainClass main = new GPMainClass();
                Button button = sender as Button;
                main.gp_StoreTrackerEvent(remote_address, button.Text , path, DateTime.Now);
            }
  
        DataSet ds = null;
        String result = "";
        userexistLabel.Visible = false;

        try
        {
            ds = new DataSet();
            string connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();

            //string connectionString = ConfigurationManager.AppSettings["connectionStringLocal"].ToString();
            string userexistproc = ConfigurationManager.AppSettings["userexistproc"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.Parameters.Add("@username", username.Text);


            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = userexistproc;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(ds);
        }

        catch (Exception ex)
        {

            string mess = ex.Message;
        }

        int tables = ds.Tables.Count;

        int rowcount = ds.Tables[0].Rows.Count;

        if (rowcount == 0)
        {
            bool join = false;
              if(joincheckbox.Checked == true)
              {
                     join = true;
              }

              DateTime time = DateTime.Now;

           
             //time.GetDateTimeFormats[0];

              createNewUser(username.Text, password.Text);
              addRegisterUser(username.Text, password.Text, countrylist.SelectedValue, 0, agelist.SelectedValue, email.Text, join,
                              genrelist.SelectedValue,time);

            
              //also add the user information to the registration table 
              //send out an email for welcoming the new user 
              SendConfirmMail();
              //redirect them to logging into their profile page

          }//we will create a new user 
          else if (rowcount == 1)
          {
              String message = "Sorry this user exist";
              userexistLabel.Text = message;
              userexistLabel.Visible = true;
              /* try
               {
                   int table_counter = ds.Tables.Count;

                   for (int i = 0; i < table_counter; i++)
                   {
                       int index = ds.Tables[i].Rows.Count;
                       int column_index = ds.Tables[i].Columns.Count;

                       for (int counter = 0; counter < index; counter++)
                       {
                           DataRow row = ds.Tables[i].Rows[counter];

                           for (int cols = 0; cols < column_index; cols++)
                           {
                               DataColumn column = ds.Tables[i].Columns[cols];
                               if (cols == 0)
                                   result += row[column] as string; //data from [row][column]
                               else if (cols == 1)
                               {
                                   result += " ";
                                   result += row[column] as string;
                               }
                               //ListItem item = new ListItem(gameTitle);
                               //GameList.Items.Add(item);
                           }//loop through each of the colums  
                       } // loops through the rows
                   }// loops through the tables
            
               }
               catch (Exception ex)
               {
                   string message = ex.Message;
               }
               */
            // Label2.Text = result;





            //then if this is correct send an email to the users email adddress

            //code the send out an email 


        }

    }

}
