Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class BUCH_Technik
    <Key>
    Public Property TECH_ID As Integer
    Public Property TECH_Datum As Date?
    Public Property TECH_Zeitcode As Integer?
    Public Property TECH_TE_ID As Integer
    Public Property TECH_SI_ID As Integer?
    <StringLength(50)>
    Public Property TECH_Verantwortlich As String
    Public Property TECH_Bemerkung As String
    <Column(TypeName:="timestamp")>
    <MaxLength(8)>
    <Timestamp>
    Public Property TECH_Timestamp As Byte()
End Class
Public Class BUCH_Technik_Auswahl
    Public Sub New()
        BUCH_Techniks = New HashSet(Of BUCH_Technik)()
    End Sub
    <Key>
    Public Property TECHAW_ID As Integer
    Public Property TECHAW_TIN As Integer?
    <StringLength(50)>
    Public Property TECHAW_Kategorie As String
    <StringLength(75)>
    Public Property TECHAW_Bezeichnung As String
    Public Property TECHAW_Aktiv As Boolean?
    Public Property TECHAW_Dauerleihe_ab As Date?
    Public Property TECHAW_Dauerleihe_bis As Date?
    <StringLength(50)>
    Public Property TECHAW_Dauerleihe As String

    Public Property TECHAW_Bemerkung As String
    <Column(TypeName:="timestamp")>
    <MaxLength(8)>
    <Timestamp>
    Public Property TECHAW_Timestamp As Byte()



    <ForeignKey("TECH_TE_ID")>
    Public Overridable Property BUCH_Techniks As ICollection(Of BUCH_Technik)
End Class