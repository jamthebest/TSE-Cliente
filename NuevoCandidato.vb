Public Class NuevoCandidato
    Private tipo As String
    Public Sub Inicio(tipo As String)
        Me.tipo = tipo
        Me.Text = "Datos de Inscripciones " + tipo
        Me.lblTitulo.Text = "CANDIDATO " + tipo.ToUpper()
    End Sub
End Class