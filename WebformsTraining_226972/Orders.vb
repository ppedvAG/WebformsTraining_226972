Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Orders
    Public Sub New()
        Order_Details = New HashSet(Of Order_Details)()
    End Sub

    <Key>
    Public Property OrderID As Integer

    <StringLength(5)>
    Public Property CustomerID As String

    Public Property EmployeeID As Integer?

    Public Property OrderDate As Date?

    Public Property RequiredDate As Date?

    Public Property ShippedDate As Date?

    Public Property ShipVia As Integer?

    <Column(TypeName:="money")>
    Public Property Freight As Decimal?

    <StringLength(40)>
    Public Property ShipName As String

    <StringLength(60)>
    Public Property ShipAddress As String

    <StringLength(15)>
    Public Property ShipCity As String

    <StringLength(15)>
    Public Property ShipRegion As String

    <StringLength(10)>
    Public Property ShipPostalCode As String

    <StringLength(15)>
    Public Property ShipCountry As String

    Public Overridable Property Customers As Customers

    Public Overridable Property Order_Details As ICollection(Of Order_Details)
End Class
