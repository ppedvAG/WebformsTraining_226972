Public Class BuchTech
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim db As New NorthwindContext

        Dim q = db.BUCH_Technik_Auswahls.Include("Buch_techniks").ToList


    End Sub

End Class