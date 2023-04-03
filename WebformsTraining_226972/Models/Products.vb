Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Products
    Public Sub New()
        Order_Details = New HashSet(Of Order_Details)()
    End Sub

    <Key>
    Public Property ProductID As Integer

    <Required>
    <StringLength(40)>
    Public Property ProductName As String

    Public Property SupplierID As Integer?

    Public Property CategoryID As Integer?

    <StringLength(20)>
    Public Property QuantityPerUnit As String

    <Column(TypeName:="money")>
    Public Property UnitPrice As Decimal?

    Public Property UnitsInStock As Short?

    Public Property UnitsOnOrder As Short?

    Public Property ReorderLevel As Short?

    Public Property Discontinued As Boolean

    Public Overridable Property Categories As Categories

    Public Overridable Property Order_Details As ICollection(Of Order_Details)

    Public Overridable Property Suppliers As Suppliers
End Class
