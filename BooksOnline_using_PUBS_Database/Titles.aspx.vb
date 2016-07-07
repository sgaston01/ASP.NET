
Imports System.Data
Imports System.Data.SqlClient



Partial Class Titles
    Inherits System.Web.UI.Page



    Sub Page_Load()
        Dim author
        Dim ds As DataSet = New DataSet()
        Dim query As String
        Dim pubid As Integer
        Dim publisher As String

        Dim adaptor As SqlDataAdapter
        pubid = Convert.ToInt32(Request.QueryString("pubid"))
        publisher = Request.QueryString("publisher")

        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("PubsConnectionString").ToString())
        query = "Select * from Titles where pub_id = @pubid"

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.Add("@pubid", SqlDbType.Int)
        cmd.Parameters("@pubid").Value = pubid
        con.Open()

        adaptor = New SqlDataAdapter(cmd)

        adaptor.Fill(ds)

        query = ds.GetXml()


        Dim l As Label = CType(Form.FindControl("Label1"), Label)


        If ds.Tables(0).Rows.Count = 0 Then
            l.Text = "Sorry this Publisher does not have any available titles"
        ElseIf ds.Tables(0).Rows.Count > 0 Then
            l.Text = "<I>" & publisher & "</I>" & " has published the following titles : "

            BulletedList1.DataSource = ds
            BulletedList1.DataBind()

        End If










        'BulletedList1.DataSource


    End Sub

    Protected Sub BulletedList1_Click(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.BulletedListEventArgs) Handles BulletedList1.Click


        Dim Bulleted As BulletedList = CType(sender, BulletedList)

        Dim s As String = Bulleted.Items.Item(e.Index).Value

        Dim pubid As Integer = Convert.ToInt32(Request.QueryString("pubid"))

        Dim publisher As String = Request.QueryString("publisher")

        Response.Redirect("BookDetails.aspx?pubid=" & pubid & "&book=" & Bulleted.Items.Item(e.Index).Value)


    End Sub
End Class
