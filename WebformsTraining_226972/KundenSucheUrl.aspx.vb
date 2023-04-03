Imports Microsoft.AspNet.FriendlyUrls

Public Class KundenSucheUrl
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack And Request.GetFriendlyUrlSegments().Count > 0 Then
            txtSuche.Text = FriendlyUrl.Segments()(0)
        End If

    End Sub

    Public Function Repeater1_GetData() As IEnumerable(Of Customers)

        Dim db = New NorthwindContext

        If Request.GetFriendlyUrlSegments().Count > 0 Then
            Dim search = Request.GetFriendlyUrlSegments()(0)

            Return db.Customers.Where(Function(x) x.CompanyName.Contains(search))


        Else
            Return db.Customers
        End If


    End Function

End Class