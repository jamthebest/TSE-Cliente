Public Class Inscripcion

    Private log As Login
    Private user As User
    Dim WithEvents WinSockCliente As New Cliente

    Public Sub Inicio(ByVal user As User, ByVal socket As Cliente, ByVal login As Login)
        Me.user = user
        WinSockCliente = socket
        Me.log = login
    End Sub

    Private Sub AbrirInscripcion(tipo As String)
        Dim nuevo As NuevoCandidato = New NuevoCandidato
        nuevo.MdiParent = Me
        nuevo.Show()
        nuevo.Inicio(tipo)
    End Sub

    Private Sub menuPresidente_Click(sender As Object, e As EventArgs) Handles menuPresidente.Click
        Me.AbrirInscripcion("Presidencial")
    End Sub

    Private Sub menuAlcalde_Click(sender As Object, e As EventArgs) Handles menuAlcalde.Click
        Me.AbrirInscripcion("a la Alcaldía")
    End Sub

    Private Sub menuDiputado_Click(sender As Object, e As EventArgs) Handles menuDiputado.Click
        Me.AbrirInscripcion("a Diputación")
    End Sub

    Private Sub menuPais_Click(sender As Object, e As EventArgs) Handles menuPais.Click
        Dim nuevo As New NuevoPais
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.MdiParent = Me
        nuevo.Show()
    End Sub

    Private Sub menuDepartamento_Click(sender As Object, e As EventArgs) Handles menuDepartamento.Click
        Dim nuevo As New NuevoDepartamento
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.MdiParent = Me
        nuevo.Show()
    End Sub
End Class