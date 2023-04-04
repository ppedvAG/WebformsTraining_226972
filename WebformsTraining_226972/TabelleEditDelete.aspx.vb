Public Class TabelleEditDelete
    Inherits System.Web.UI.Page
    Dim db As NorthwindContext = New NorthwindContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Repeater1_ItemCommand(sender As Object, e As RepeaterCommandEventArgs)
        Dim c = db.Customers.Find(e.CommandArgument)
        db.Customers.Remove(c)
        Try
            db.SaveChanges()
        Catch ex As Exception
            pnlAlert.Visible = True
        End Try




    End Sub
    Public Function Repeater1_GetData() As IEnumerable(Of Customers)


        Return db.Customers
    End Function
End Class