Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Customers
    Public Sub New()
        Orders = New HashSet(Of Orders)()
    End Sub

    <Key>
    <StringLength(5)>
    Public Property CustomerID As String

    <Required>
    <StringLength(40)>
    Public Property CompanyName As String

    <StringLength(30)>
    Public Property ContactName As String

    <StringLength(30)>
    Public Property ContactTitle As String

    <StringLength(60)>
    Public Property Address As String

    <StringLength(15)>
    Public Property City As String

    <StringLength(15)>
    Public Property Region As String

    <StringLength(10)>
    Public Property PostalCode As String

    <StringLength(15)>
    Public Property Country As String

    <StringLength(24)>
    Public Property Phone As String

    <StringLength(24)>
    Public Property Fax As String

    Public Overridable Property Orders As ICollection(Of Orders)
End Class
