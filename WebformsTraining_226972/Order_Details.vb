Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Order Details")>
Partial Public Class Order_Details
    <Key>
    <Column(Order:=0)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property OrderID As Integer

    <Key>
    <Column(Order:=1)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property ProductID As Integer

    <Column(TypeName:="money")>
    Public Property UnitPrice As Decimal

    Public Property Quantity As Short

    Public Property Discount As Single

    Public Overridable Property Orders As Orders
End Class
