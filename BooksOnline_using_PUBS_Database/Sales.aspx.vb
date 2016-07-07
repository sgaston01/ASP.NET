Imports System.Data
Imports System.Data.SqlClient

Partial Class Sales
    Inherits System.Web.UI.Page



    Sub Page_Load()




        Dim squery As String = "select top 30 sales.qty , titles.title , stores.stor_name , stores.state " & _
        " from Sales inner join stores on sales.stor_id = stores.stor_id " & _
 " inner join titles on sales.title_id = titles.title_id " & _
" group by sales.qty , titles.title , stores.stor_name , stores.state " & _
" order by sales.qty desc "

        'squery = "select * from sales"

        Dim ds2 As DataSet = New DataSet()
        Dim adaptor As SqlDataAdapter

        Dim con2 As New SqlConnection(ConfigurationManager.ConnectionStrings("PubsConnectionString").ToString())

        Dim cmd2 As New SqlCommand(squery, con2)
 
        con2.Open()

        adaptor = New SqlDataAdapter(cmd2)

        adaptor.Fill(ds2)

        squery = ds2.GetXml()

        GridView1.DataSource = ds2
        GridView1.DataBind()


    End Sub


    Sub gridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs)

        Dim squery As String = "select top 30 sales.qty , titles.title , stores.stor_name , stores.state " & _
        " from Sales inner join stores on sales.stor_id = stores.stor_id " & _
 " inner join titles on sales.title_id = titles.title_id " & _
" group by sales.qty , titles.title , stores.stor_name , stores.state " & _
" order by sales.qty desc "

        'squery = "select * from sales"

        Dim ds2 As DataSet = New DataSet()
        Dim adaptor As SqlDataAdapter

        Dim con2 As New SqlConnection(ConfigurationManager.ConnectionStrings("PubsConnectionString").ToString())

        Dim cmd2 As New SqlCommand(squery, con2)

        con2.Open()

        adaptor = New SqlDataAdapter(cmd2)

        adaptor.Fill(ds2)

        squery = ds2.GetXml()


        ' GridView1.DataSource = ds2.Tables




        Dim dataTable As DataTable = CType(ds2.Tables(0), DataTable)

        Dim view As DataView = dataTable.DefaultView

        Dim m As String = e.SortExpression & "  " & "DESC"

        Dim x As String

        x = m

        view.Sort = x


        ' view.Sort = "ASC"

        GridView1.DataSource = view
        GridView1.DataBind()



        'DataTable dataTable = gridView.DataSource as DataTable


        '    DataView(DataView = New DataView(DataTable))
        '   DataView.Sort = e.SortExpression + " " + ConvertSortDirectionToSql(e.SortDirection)

        '  GridView.DataSource = DataView
        ' GridView.DataBind()


    End Sub


End Class
