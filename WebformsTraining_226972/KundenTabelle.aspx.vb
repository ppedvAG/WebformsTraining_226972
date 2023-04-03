Public Class KundenTabelle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Function Repeater1_GetData() As IEnumerable(Of Customers)

        Dim db = New NorthwindContext
        Return db.Customers
    End Function

End Class