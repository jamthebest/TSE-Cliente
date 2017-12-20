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
        Dim nuevo As New Identidad
        nuevo.MdiParent = Me
        nuevo.Show()
        nuevo.Inicio(Me.user, tipo, Me.WinSockCliente)
    End Sub

    Private Sub menuPresidente_Click(sender As Object, e As EventArgs) Handles menuPresidente.Click
        Me.AbrirInscripcion("Presidente")
    End Sub

    Private Sub menuAlcalde_Click(sender As Object, e As EventArgs) Handles menuAlcalde.Click
        Me.AbrirInscripcion("Alcalde")
    End Sub

    Private Sub menuDiputado_Click(sender As Object, e As EventArgs) Handles menuDiputado.Click
        Me.AbrirInscripcion("Diputado")
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

    Private Sub menuMunicipio_Click(sender As Object, e As EventArgs) Handles menuMunicipio.Click
        Dim nuevo As New NuevoMunicipio
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.MdiParent = Me
        nuevo.Show()
    End Sub

    Private Sub menuPartido_Click(sender As Object, e As EventArgs) Handles menuPartido.Click
        Dim nuevo As New NuevoPartido
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.MdiParent = Me
        nuevo.Show()
    End Sub

    Private Sub menuVotante_Click(sender As Object, e As EventArgs) Handles menuVotante.Click
        Dim nuevo As New NuevoUsuario
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.MdiParent = Me
        nuevo.Show()
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        Dim nuevo As New Resultados
        nuevo.Inicio(Me.user, Me.WinSockCliente)
        nuevo.MdiParent = Me
        nuevo.Show()
    End Sub
End Class