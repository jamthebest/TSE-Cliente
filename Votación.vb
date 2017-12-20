Public Class Votación
    Private log As Login
    Private user As User
    Dim WithEvents WinSockCliente As New Cliente

    Public Sub Inicio(ByVal user As User, ByVal socket As Cliente, ByVal login As Login)
        Me.user = user
        Me.WinSockCliente = socket
        Me.log = login
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdPresidente_Click(sender As Object, e As EventArgs) Handles cmdPresidente.Click
        Dim nuevo As New PlanillaPresidencial
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.Show()
    End Sub

    Private Sub cmdAlcalde_Click(sender As Object, e As EventArgs) Handles cmdAlcalde.Click
        Dim nuevo As New PlanillaAlcaldes
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.Show()
    End Sub

    Private Sub cmdDiputado_Click(sender As Object, e As EventArgs) Handles cmdDiputado.Click
        Dim nuevo As New PlanillaDiputados
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.Show()
    End Sub
End Class