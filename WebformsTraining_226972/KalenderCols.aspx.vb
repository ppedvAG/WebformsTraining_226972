Public Class KalenderCols
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Function Repeater1_GetData() As IEnumerable(Of Customers)
        Dim i = 1
        Dim db = New NorthwindContext
        Return db.Customers
    End Function
End Class