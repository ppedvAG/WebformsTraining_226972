Public Class Kundenliste1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Function Repeater1_GetData() As IEnumerable(Of Customers)

        Dim db = New NorthwindContext
        Return db.Customers.Where(Function(x) x.CompanyName.Contains(txtSuche.Text))

    End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs)


        Repeater1.DataBind()
    End Sub
End Class