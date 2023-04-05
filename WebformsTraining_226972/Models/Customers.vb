Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Runtime.Serialization
Imports Newtonsoft.Json

Partial Public Class Customers
    Public Sub New()
        Orders = New HashSet(Of Orders)()
        CustomerDemographics = New HashSet(Of CustomerDemographics)()
    End Sub

    <Key>
    <StringLength(5)>
    Public Property CustomerID As String

    <Required(ErrorMessage:="da muss was rein")>
    <StringLength(40, ErrorMessage:="Max 40 Zeichen")>
    Public Property CompanyName As String

    <StringLength(30, ErrorMessage:="max 30 Zeichen")>
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
    <JsonIgnore>
    <IgnoreDataMember>
    Public Overridable Property Orders As ICollection(Of Orders)
    <JsonIgnore>
    <IgnoreDataMember>
    Public Overridable Property CustomerDemographics As ICollection(Of CustomerDemographics)
End Class
