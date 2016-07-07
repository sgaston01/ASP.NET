
Imports System.Data
Imports System.Data.SqlClient

Partial Class BookDetails
    Inherits System.Web.UI.Page


    Sub Page_Load()

        Dim titleid As String = Request.QueryString("book")

        Dim ds As DataSet = New DataSet()
        Dim query As String
        Dim pubid As Integer
        Dim publisher As String

        Dim adaptor As SqlDataAdapter
        pubid = Convert.ToInt32(Request.QueryString("pubid"))
        publisher = Request.QueryString("publisher")

        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("PubsConnectionString").ToString())

        query = "select * , titleauthor.au_id from titles inner join publishers on publishers.pub_id = titles.pub_id" & _
        " inner join titleauthor on titleauthor.title_id = titles.title_id" & _
        " inner join authors on authors.au_id = titleauthor.au_id" & _
        " where titles.title_id = @title"


        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@title", SqlDbType.VarChar)
        cmd.Parameters("@title").Value = titleid
        con.Open()

        adaptor = New SqlDataAdapter(cmd)

        adaptor.Fill(ds)

        query = ds.GetXml()


        Label1.Text = titleid

        GridView1.DataSource = ds
        GridView1.DataBind()


        Dim value As String = ds.Tables(0).Rows(0).Item("au_id").ToString()

        con.Close()



        Dim ds2 As DataSet = New DataSet()

        Dim con2 As New SqlConnection(ConfigurationManager.ConnectionStrings("PubsConnectionString").ToString())

        'Dim squery = " select title from titleauthor inner join titles on titleauthor.title_id = titles.title_id where titleauthor.au_id = @au"

        Dim squery As String = "select * from titleauthor " & _
" inner join authors on titleauthor.au_id = authors.au_id " & _
" inner join titles on titleauthor.title_id = titles.title_id " & _
" where titleauthor.au_id in " & _
" (SELECT au_id FROM authors" & _
" WHERE au_id IN  (SELECT au_id FROM titleauthor WHERE title_id = @title) )"

        Dim cmd2 As New SqlCommand(squery, con)
        cmd2.Parameters.Add("@title", SqlDbType.VarChar)
        cmd2.Parameters("@title").Value = titleid
        con2.Open()

        adaptor = New SqlDataAdapter(cmd2)

        adaptor.Fill(ds2)

        query = ds.GetXml()


        Label1.Text = titleid

        GridView2.DataSource = ds2
        GridView2.DataBind()






        'get a datagrid 


        'create a repeater 



    End Sub


    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
