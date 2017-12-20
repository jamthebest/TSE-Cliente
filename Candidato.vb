Public Class Candidato
    Private idCandidato As Integer
    Private functiones As New Funciones
    Private voto As Boolean = False
    Private presidente As PlanillaPresidencial
    Private alcalde As PlanillaAlcaldes
    Private diputado As PlanillaDiputados
    Public Sub New(ByVal nombre As String, ByVal partido As String, ByVal idCandidato As Integer, Optional ByVal padre As PlanillaPresidencial = Nothing, Optional ByVal padreAlcalde As PlanillaAlcaldes = Nothing, Optional ByVal padreDiputado As PlanillaDiputados = Nothing, Optional ByVal foto() As Byte = Nothing, Optional ByVal logo() As Byte = Nothing)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idCandidato = idCandidato
        Me.lblCandidato.Text = nombre
        Me.lblPartido.Text = partido
        Me.presidente = padre
        Me.alcalde = padreAlcalde
        Me.diputado = padreDiputado
        Dim name As String = ""
        If Not IsNothing(foto) Then
            name = "Candidato_" & idCandidato.ToString()
            Me.functiones.BytesToFile(foto, name)
            Me.imgCandidato.ImageLocation = name
        End If
        If Not IsNothing(logo) Then
            name = "Partido_" & partido
            Me.functiones.BytesToFile(foto, name)
            Me.imgPartido.ImageLocation = name
        End If
    End Sub

    Private Sub cmdVotar_Click(sender As Object, e As EventArgs) Handles cmdVotar.Click
        If Me.voto = False Then
            If Not (Me.presidente Is Nothing) Then
                Me.presidente.validar()
            End If
            If Not (Me.alcalde Is Nothing) Then
                Me.alcalde.validar()
            End If
            If Not (Me.diputado Is Nothing) Then
                Me.diputado.validar()
            End If
        End If
        Me.voto = Not Me.voto
        Me.cmdVotar.Text = If(Me.voto, "X", "")
    End Sub

    Public Function estaActivo() As Boolean
        Return Me.voto
    End Function

    Public Function getCandidato() As Integer
        Return Me.idCandidato
    End Function

    Public Sub removerMarca()
        Me.voto = False
        Me.cmdVotar.Text = ""
    End Sub
End Class
