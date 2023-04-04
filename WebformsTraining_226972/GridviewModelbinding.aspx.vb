Public Class GridviewModelbinding
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ' Der Rückgabetyp kann in 'IEnumerable' geändert werden. Damit Paginierung und Sortierung für
    ' unterstützt werden, müssen jedoch die folgenden Parameter hinzugefügt werden:
    '     ByVal maximumRows as Integer
    '     ByVal startRowIndex as Integer
    '     ByRef totalRowCount as Integer
    '     ByVal sortByExpression as String
    Public Function GridView1_GetData() As IQueryable(Of WebformsTraining_226972.Customers)
        Return Nothing
    End Function

    ' Der Name des ID-Parameters sollte dem für das Steuerelement festgelegten DataKeyNames-Wert entsprechen.
    Public Sub GridView1_UpdateItem(ByVal id As Integer)
        Dim item As WebformsTraining_226972.Customers = Nothing
        ' Element hier laden, z. B. item = MyDataLayer.Find(id)
        If item Is Nothing Then
            ' Das Element wurde nicht gefunden.
            ModelState.AddModelError("", String.Format("Das Element mit der ID {0} wurde nicht gefunden.", id))
            Return
        End If
        TryUpdateModel(item)
        If ModelState.IsValid Then
            ' Änderungen hier speichern, z. B. MyDataLayer.SaveChanges()

        End If
    End Sub

    ' Der Name des ID-Parameters sollte dem für das Steuerelement festgelegten DataKeyNames-Wert entsprechen.
    Public Sub GridView1_DeleteItem(ByVal id As Integer)

    End Sub
End Class