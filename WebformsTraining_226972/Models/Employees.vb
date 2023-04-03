Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Employees
    Public Sub New()
        Employees1 = New HashSet(Of Employees)()
        Orders = New HashSet(Of Orders)()
        Territories = New HashSet(Of Territories)()
    End Sub

    <Key>
    Public Property EmployeeID As Integer

    <Required>
    <StringLength(20)>
    Public Property LastName As String

    <Required>
    <StringLength(10)>
    Public Property FirstName As String

    <StringLength(30)>
    Public Property Title As String

    <StringLength(25)>
    Public Property TitleOfCourtesy As String

    Public Property BirthDate As Date?

    Public Property HireDate As Date?

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
    Public Property HomePhone As String

    <StringLength(4)>
    Public Property Extension As String

    <Column(TypeName:="image")>
    Public Property Photo As Byte()

    <Column(TypeName:="ntext")>
    Public Property Notes As String

    Public Property ReportsTo As Integer?

    <StringLength(255)>
    Public Property PhotoPath As String

    Public Overridable Property Employees1 As ICollection(Of Employees)

    Public Overridable Property Employees2 As Employees

    Public Overridable Property Orders As ICollection(Of Orders)

    Public Overridable Property Territories As ICollection(Of Territories)
End Class
