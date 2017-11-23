Public Class Inscripcion

    Private Sub AbrirInscripcion(tipo As String)
        Dim nuevo As NuevoCandidato = New NuevoCandidato
        nuevo.Show()
        nuevo.Inicio(tipo)
        Me.Hide()
    End Sub

    Private Sub btnPresidencial_Click(sender As Object, e As EventArgs) Handles btnPresidencial.Click
        AbrirInscripcion("Presidencial")
    End Sub

    Private Sub btnAlcaldia_Click(sender As Object, e As EventArgs) Handles btnAlcaldia.Click
        AbrirInscripcion("a la Alcaldía")
    End Sub

    Private Sub btnDiputacion_Click(sender As Object, e As EventArgs) Handles btnDiputacion.Click
        AbrirInscripcion("a Diputación")
    End Sub
End Class