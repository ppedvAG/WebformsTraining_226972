Imports Microsoft.AspNet.FriendlyUrls.ModelBinding

Public Class Bestellungen
    Inherits System.Web.UI.Page
    Dim db As NorthwindContext = New NorthwindContext
    Dim OrderID As Integer = 10248
    Dim orders As Orders
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ' Der ID-Parameter sollte dem DataKeyNames-Wert entsprechen, der für das Steuerelement
    ' festgelegt wurde, oder mit einem Wertanbieterattribut versehen werden, z. B. <QueryString>ByVal id as Integer 10248
    Public Function FormView1_GetItem(<FriendlyUrlSegments(0)> id As Integer?) As WebformsTraining_226972.Orders
        orders = db.Orders.Find(OrderID)
        Return orders
    End Function

    Public Function Repeater1_GetData() As IEnumerable(Of WebformsTraining_226972.Order_Details)
        Return db.Order_Details.Where(Function(x) x.OrderID = OrderID)
        ' Return orders.Order_Details.Where(Function(x) x.OrderID = OrderID)
    End Function
    Public Function ladeProdukte() As IEnumerable(Of WebformsTraining_226972.Products)
        Return db.Products
    End Function

    Protected Sub Insert_Click(sender As Object, e As EventArgs)
        Dim op = New Order_Details
        op.ProductID = txtProduktDownList1.SelectedValue
        op.Discount = txtDiscount.Text
        op.UnitPrice = txtPreis.Text
        op.Quantity = txtAnzahl.Text
        op.OrderID = OrderID
        db.Order_Details.Add(op)
        db.SaveChanges()

        Repeater1.DataBind()

    End Sub

    Protected Sub UpdatePanel1_Load(sender As Object, e As EventArgs)

    End Sub
End Class