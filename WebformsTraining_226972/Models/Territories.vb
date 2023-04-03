Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Territories
    Public Sub New()
        Employees = New HashSet(Of Employees)()
    End Sub

    <Key>
    <StringLength(20)>
    Public Property TerritoryID As String

    <Required>
    <StringLength(50)>
    Public Property TerritoryDescription As String

    Public Property RegionID As Integer

    Public Overridable Property Region As Region

    Public Overridable Property Employees As ICollection(Of Employees)
End Class
