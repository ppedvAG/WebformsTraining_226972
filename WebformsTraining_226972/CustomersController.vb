Imports System.Net
Imports System.Web.Http

Public Class CustomersController
    Inherits ApiController

    ' GET api/<controller>
    'Public Function GetValues() As IEnumerable(Of String)
    '    Return New String() {"value1", "value2"}
    'End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As List(Of Autocomplete)

        Dim db = New NorthwindContext


        Dim o = db.Customers.Where(Function(x) x.CompanyName.Contains(id))


        Dim liste As New List(Of Autocomplete)
        For Each x In o
            liste.Add(New Autocomplete With {.value = x.CustomerID, .data = x.CompanyName})
        Next

        Return liste
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
Public Class Autocomplete
    Public Property value As String
    Public Property data As String
End Class