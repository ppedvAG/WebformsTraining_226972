Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Region")>
Partial Public Class Region
    Public Sub New()
        Territories = New HashSet(Of Territories)()
    End Sub

    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property RegionID As Integer

    <Required>
    <StringLength(50)>
    Public Property RegionDescription As String

    Public Overridable Property Territories As ICollection(Of Territories)
End Class
