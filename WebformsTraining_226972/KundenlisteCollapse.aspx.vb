Public Class KundenlisteCollapse
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Function Repeater1_GetData() As IEnumerable(Of Customers)

        Dim db = New NorthwindContext
        Return db.Customers

        ' Dim tmp = db.Customers.Include("Orders")
        'Lacy Loading


    End Function
End Class