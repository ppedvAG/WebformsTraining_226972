Imports Microsoft.AspNet.SignalR

Public Class MyHub
    Inherits Hub

    Public Sub Hello()
        Clients.All.Hello()
    End Sub
End Class
