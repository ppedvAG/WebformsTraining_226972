Imports Microsoft.AspNet.FriendlyUrls.ModelBinding

Public Class kundenedit
    Inherits System.Web.UI.Page
    Dim db As NorthwindContext = New NorthwindContext
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ' Der ID-Parameter sollte dem DataKeyNames-Wert entsprechen, der für das Steuerelement
    ' festgelegt wurde, oder mit einem Wertanbieterattribut versehen werden, z. B. <QueryString>ByVal id as Integer
    Public Function FormView1_GetItem(<FriendlyUrlSegments(0)> id As String) As WebformsTraining_226972.Customers
        Return db.Customers.Find(id)
    End Function

    ' Der Name des ID-Parameters sollte dem für das Steuerelement festgelegten DataKeyNames-Wert entsprechen.
    Public Sub FormView1_UpdateItem(ByVal CustomerID As String)
        Dim item As WebformsTraining_226972.Customers = Nothing
        ' Element hier laden, z. B. item = MyDataLayer.Find(id)
        item = db.Customers.Find(CustomerID)
        If item Is Nothing Then
            ' Das Element wurde nicht gefunden.
            ModelState.AddModelError("", String.Format("Das Element mit der ID {0} wurde nicht gefunden.", CustomerID))
            Return
        End If
        TryUpdateModel(item)
        If ModelState.IsValid Then
            ' Änderungen hier speichern, z. B. MyDataLayer.SaveChanges()
            item.City = DateTime.Now.ToShortDateString
            db.SaveChanges()
        End If
    End Sub

    ' Der Name des ID-Parameters sollte dem für das Steuerelement festgelegten DataKeyNames-Wert entsprechen.
    Public Sub FormView1_DeleteItem(ByVal id As String)

    End Sub

    Public Sub FormView1_InsertItem()
        Dim item = New WebformsTraining_226972.Customers()
        TryUpdateModel(item)
        If ModelState.IsValid Then
            ' Save changes here

        End If
    End Sub
End Class