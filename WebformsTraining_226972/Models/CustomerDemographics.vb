Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class CustomerDemographics
    Public Sub New()
        Customers = New HashSet(Of Customers)()
    End Sub

    <Key>
    <StringLength(10)>
    Public Property CustomerTypeID As String

    <Column(TypeName:="ntext")>
    Public Property CustomerDesc As String

    Public Overridable Property Customers As ICollection(Of Customers)
End Class
