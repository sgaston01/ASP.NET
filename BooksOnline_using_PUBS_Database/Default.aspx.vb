
Partial Class _Default
    Inherits System.Web.UI.Page


    Sub Page_Load()


        ' BulletedList1.

        If Page.IsPostBack Then


            Dim r As String
            r = BulletedList1.DataValueField
            r = BulletedList1.DataTextField
        Else

            Dim r2 As String
            r2 = BulletedList1.DataValueField
            r2 = BulletedList1.DataTextField

        End If






    End Sub

    Protected Sub BulletedList1_Click(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.BulletedListEventArgs) Handles BulletedList1.Click

        'Server.Transfer("Titles.aspx?pubid=")

        Dim Bulleted As BulletedList = CType(sender, BulletedList)

        Dim s As String = Bulleted.Items.Item(e.Index).Value


        Response.Redirect("Titles.aspx?pubid=" & Bulleted.Items(e.Index).Value.ToString() & "&publisher=" & Bulleted.Items.Item(e.Index).Text)

    End Sub
End Class
