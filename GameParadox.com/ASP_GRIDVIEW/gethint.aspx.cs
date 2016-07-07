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


//includes for the ajax
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using gpclass;


public partial class gethint : System.Web.UI.Page
{

    string m;
    string mylinks;

    public string connectionString = "";
    public string serverString = "";

    protected void Page_Load(object sender, EventArgs e)
    {

     

       string value = Request.QueryString["sid"];

       mylinks = "";

       string valuex = Request.Form.Get("a");

       serverString = ConfigurationManager.AppSettings["server"].ToString();

       if (serverString == "true")
           connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();

       else
       {
          connectionString = ConfigurationManager.AppSettings["connectionStringLocal"].ToString();

       }

       //allgames?index=0
        char [] delimiter  = {'?'};
        
        string [] values = value.Split(delimiter);



        string cmd = values[0];

        

      switch(cmd)
      {

          case "yo":
              {
                  Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
                  DataSet ds = null;

                  try
                  {
                      ds = new DataSet();
                      //string connectionString = ConfigurationManager.AppSettings["connectionString"].toString();

                      connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();
                      // <add key="getgamelist" value="gp_getGameList"/>
                      string getgamelist = ConfigurationManager.AppSettings["getgamelist"].ToString();

                      SqlConnection connection = new SqlConnection(connectionString);
                      SqlCommand command = new SqlCommand();
                      command.Connection = connection;
                      command.CommandType = CommandType.StoredProcedure;
                      command.CommandText = getgamelist;
                      connection.Open();

                      SqlDataAdapter adapter = new SqlDataAdapter(command);

                      adapter.Fill(ds);

                  }

                  catch (Exception ex)
                  {

                      string mess = ex.Message;

                      Session.Add("error", mess);
                      Response.Redirect("Error.aspx");

                  }



                  string xml = ds.GetXml();

                  // Response.Write(xml);

                  tranform("GameList.xsl", xml);
                  break;
              }

          case "getRate":
          {



              break;
          }

          case "allgames":
          {

              //return;

             Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);

              GPMainClass mainclass = new GPMainClass();
              // string xml = mainclass.gp_GetAllGames();
              
              string [] d = {"index="};
              string [] current_index  =   values[1].Split(d, StringSplitOptions.RemoveEmptyEntries);
              //string[] current_index = values[1].Split(d); // get the current index or clicked index
              int index = Convert.ToInt32(current_index[0]);



              int number_of_games = 163;

              int pages = number_of_games / 10;


              if (index + 10 >= number_of_games)
              {

                  index = number_of_games - 10;
              }









              string xml = mainclass.gp_ShowAllGamesByPaging(index);

             xml = xml.Replace("\r\n", "");


              Response.Clear();
             
             
              // call the stored procedure to get the start and ending index for the games
              // that will be displayed on the page 


             string table = "<table  align=center> <tbody> <tr> ";
              
              //"<tr> <td>" +
              //"<div class=item>";
              //  <a  onclick ="allgames(1)" href="" >1 &nbsp;</a></div>

              string link_space ="&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;";

            //  string link = "<a class='noline' <INNERTEXT>   <page> &nbsp;</a>";

         //  string link = "<td> <div <class> > <a class='noline' <INNERTEXT> &nbsp;  <page> &nbsp;</a>  </div></td>";

           //  <input  id="Button1" type="button" value="1" class="item" size="10"/>
           string link = "<td> <div> <input type=button value=<page> class=<class> size=20 <INNERTEXT> /> </div> </td>"; 
              
              string intags = "</tr></tbody></table>";


              string delimiterToken = "<;>";

              /*
               * 
               * /

               string delimiterToken = "<;>";
              /*<table  align=center cellpadding=0 cellspacing =0 style="width: 22px"> 
              <tbody>
              <tr>
              <td bordercolor ="blue" style="width: 12px">
              <div style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid">
              <a href="www.test.com">1 &nbsp;</a></div>
              </td>
              </tr>
              </tbody>
              </table>   
               */

               Session.Add("index", index.ToString());

               /*jubkasldjf
                        string divTag = "<div class=item>";

                       divTag += temp_link;
                       //temp_link += "</div>";
                       divTag += "</div>";
                       temp_link += links;

                       divTag += delimiterToken;

                       temp_link = divTag;
                       //temp_link += delimite 
                * 
                * */

               string links = "";
             // if (index == 0)
             // {
                  //string temp_table = table;
                  //links += temp_table;

                  int end = index + 10;
                  int temp_index = (index);
                  string temp_link = link;

                if (temp_index != 0)
                  {
                     temp_link = link;

                      int page = index - 10;

                      if (page < 0)
                          page = 0;
 //string link = "<td> <div <class> > <input type=button value=<VALUE> class=<class> size=10 <INNERTEXT> />"; 
              
                      string innerText = "onclick=allgames1(" + page.ToString() + ")";
                      //innerText += " href=' '>";
                      temp_link = temp_link.Replace("<INNERTEXT>", innerText);
                      temp_link = temp_link.Replace("<page>", "<<&nbsp;back");

                      temp_link = temp_link.Replace("<class>", "itemBack");
                      temp_link += links;
                    //  temp_link += delimiterToken;
                      mylinks += temp_link;
                      temp_link = link;
                     
                  }
            
               
                  for (; temp_index < end; temp_index++)
                  {

                          int page = temp_index + 1;
                         /* string innerText = "onclick=allgames1(" + page.ToString() + ")";
                            innerText += " href=''>";
                            temp_link = temp_link.Replace("<INNERTEXT>", innerText);
                            temp_link = temp_link.Replace("<page>", page.ToString());
                          */
                          if (temp_index == index)
                          {

                              string innerText = "onclick=allgames1(" + index.ToString() + ")";
                             // innerText += " href='?'>";
                              temp_link = temp_link.Replace("<INNERTEXT>", innerText);
                              temp_link = temp_link.Replace("<page>", page.ToString() );

                           temp_link = temp_link.Replace("<class>", "hitem");

                           

                          }
                          else
                          {
                           
                              string innerText = "onclick=allgames1(" + temp_index.ToString() + ")";
                             // innerText += " href='?'>";
                              temp_link = temp_link.Replace("<INNERTEXT>", innerText);
                              temp_link = temp_link.Replace("<page>", page.ToString());

                              //temp_link = temp_link.Replace("<class>", "class=hitem");
                             temp_link = temp_link.Replace("<class>", "item");

                          }

                      temp_link += links;
                     // temp_link += delimiterToken; 

                      //links += temp_link;
                      //links += delimiterToken;
                      //links += intags;
                      //links += delimiterToken;

                      mylinks += temp_link;

                      temp_link = link;

               //   }
                   


              }// means you are on the first page or end 



              //test end button functionality 
           /*   temp_link = link;
             string innerTexts = "onclick=allgames1(" + index.ToString() + ")";
              // innerText += " href='?'>";
              temp_link = temp_link.Replace("<INNERTEXT>", innerTexts);
              temp_link = temp_link.Replace("<page>", "next&gt;&gt;");

              temp_link = temp_link.Replace("<class>", "hitem");

              temp_link += links;
              // temp_link += delimiterToken;
              mylinks += temp_link;
              temp_link = link;
              */
              // if we have not reached the end of the number of games show next 

             if (index != 124 )
                 {
                     temp_link = link;

                     int page = index + 10;

                     if (page > number_of_games)
                         page = number_of_games - 10;

                     string innerText = "onclick=allgames1(" + page.ToString() + ")";
                     //innerText += " href=''>";
                     temp_link = temp_link.Replace("<INNERTEXT>", innerText);
                     temp_link = temp_link.Replace("<page>", "next&gt;&gt;");
                     temp_link = temp_link.Replace("<class>", "itemNext");

                     temp_link += links;
                    // temp_link += delimiterToken;
                     mylinks += temp_link;
                     temp_link = link;
                 
                 }
             


              if (mylinks != "")
              {
                  table += mylinks;
                  table += intags;

                 // mylinks; // += intags;
                  mylinks = table;

                  Response.Write(mylinks);
             Cache["ajaxResult"] = mylinks;

              }
              tranform("AllGamesByPaging.xsl", xml);
            
              
              //generator the other pages based on the current index 
            
              break;


          }
    }




    }


    void tranform(string filename, string xml)
    {
        //HttpServerUtility util = Server.CreateObject("Microsoft.XMLDOM");

        try
        {
            XslTransform xslt = new XslTransform();

            StringReader stringReader = new StringReader(xml);
            // the server
           XPathDocument doc  = null;

           if (serverString == "true")
               doc = new XPathDocument("http://www.gameparadox.com/AllGamesByPaging.xsl");
           else
           {   
               doc = new XPathDocument("C:\\Documents and Settings\\steve\\My Documents\\Visual Studio 2005\\WebSites\\gameparadox\\"+filename);
           }
           //StreamReader reader = new StreamReader(stringReader);



           // XPathDocument doc = new XPathDocument("AllGamesByPaging.xsl" + filename);
         

         
        
            //xslt.Load("http://server/" + filename);
            xslt.Load(doc);

            // XmlReader reader = XmlReader();

            XPathDocument mydata = new XPathDocument(stringReader);
            StringReader stringread = new StringReader("");
            //TextWriter writter = new TextWriter();
            StringWriter write = new StringWriter();

            xslt.Transform(mydata, null, write, null);

            string data = write.ToString();

            /*
              <table  align=center cellpadding=0 cellspacing =0 style="width: 22px"> 
              <tbody>
              <tr>
              <td bordercolor ="blue" style="width: 12px">
              <div style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid">
              <a href="www.test.com">1 &nbsp;</a></div>
              </td>
              </tr>
              </tbody>
              </table>   
             */

            //so what will the server do for us 
            //create the links pages
            //create the table for the link and maybe create a previous link and next link 
            //find out where to place the table based on the style sheets




            //Response.Write(" &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <a href=www.google.com> My Link </a><;>"); 
            string d = Cache["ajaxResult"] as string;

            if (d != null)
            {
                d += data;
                Cache["ajaxResult"] = d;

            }
            else if (d == null)
            {
                Cache["ajaxResult"] = d; 
              
            }

            Response.Write(data);
        }

        catch (Exception ex)
        {

            string mess = ex.Message;

            Session.Add("error", mess);
            Response.Redirect("Error.aspx");
        }
    }

}
