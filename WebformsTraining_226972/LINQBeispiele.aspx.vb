Imports Microsoft.Ajax.Utilities

Public Class LINQBeispiele
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim db = New NorthwindContext

        Dim kunden = db.Customers.Where(Function(x) x.Orders.Count > 3 AndAlso x.CompanyName.Contains("tt")).OrderBy(Function(x) x.City).ToList()
        Dim kunden2 = kunden.Take(2)


    End Sub

End Class