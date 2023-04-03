Imports System.Data.SqlClient

Public Class KundenListeSQL
    Inherits System.Web.UI.Page

    Public kunden As New List(Of CustomerView)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim conn = New SqlConnection(ConfigurationManager.ConnectionStrings("NorthwindContext").ConnectionString)
        '        Dim cmd = New SqlCommand("SELECT   dbo.Customers.CompanyName, dbo.Orders.OrderDate, dbo.Customers.CustomerID, dbo.Orders.Freight
        'FROM         dbo.Customers INNER JOIN
        '                         dbo.Orders ON dbo.Customers.CustomerID = dbo.Orders.CustomerID where companyname like '%'+@suche+'%'")
        '        cmd.Parameters.AddWithValue("@suche", "tt")

        Dim cmd = New SqlCommand("SELECT   dbo.Customers.CompanyName, dbo.Orders.OrderDate, dbo.Customers.CustomerID, dbo.Orders.Freight
FROM         dbo.Customers INNER JOIN
                         dbo.Orders ON dbo.Customers.CustomerID = dbo.Orders.CustomerID order by CustomerID", conn)
        conn.Open()
        Dim dr = cmd.ExecuteReader

        While dr.Read
            Dim cv = New CustomerView() With
                {.CustomerID = dr("CustomerId"),
                .CompanyName = dr("CompanyName"),
                .Freight = dr("Freight"),
                .OrderDate = dr("OrderDate")
                }

            kunden.Add(cv)
        End While

    End Sub

End Class