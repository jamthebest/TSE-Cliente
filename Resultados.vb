Public Class Resultados
    Private user As User
    Private demo As Threading.Thread = Nothing
    Private demoCandidatos As Threading.Thread = Nothing
    Private items As ArrayList
    Dim funciones As New Funciones
    Dim WithEvents WinSockCliente As New Cliente
    Delegate Sub FillCandidatosCallback(ByVal [text1] As String)

    Public Sub Inicio(ByVal user As User, ByVal socket As Cliente)
        Me.user = user
        Me.WinSockCliente = socket
    End Sub

    Private Sub ThreadProcSafeCandidatos()
        Me.FillCandidatos("")
    End Sub

    Private Sub FillCandidatos(ByVal [text] As String)
        If Me.InvokeRequired Then
            Dim d As New FillCandidatosCallback(AddressOf FillCandidatos)
            Me.Invoke(d, New Object() {[text]})
        Else
            Debug.WriteLine("Response: " & Me.items.Count.ToString())
            Dim index As Integer = 0
            For Each item As ArrayList In Me.items
                Dim nombre As New Label
                Dim partido As New Label
                Dim votos As New Label
                nombre.Text = item.Item(0)
                partido.Text = item.Item(1)
                votos.Text = item.Item(4)
                nombre.Anchor = AnchorStyles.Top
                partido.Anchor = AnchorStyles.Top
                votos.Anchor = AnchorStyles.Top
                If index = 0 Then
                    Me.tabla.RowStyles(index).SizeType = SizeType.AutoSize
                    'Me.tabla.RowStyles(index).Height = 30
                Else
                    Me.tabla.RowStyles.Add(New RowStyle(SizeType.AutoSize))
                    'Me.tabla.RowCount = Me.tabla.RowCount + 1
                End If
                Me.tabla.Controls.Add(nombre, 0, index)
                Me.tabla.Controls.Add(partido, 1, index)
                Me.tabla.Controls.Add(votos, 2, index)
                index = index + 1
            Next
        End If
    End Sub

    Private Sub RespuestaObtenerRegistros(ByVal listado As ArrayList, ByVal tabla As String) Handles WinSockCliente.RespuestaObtener
        Me.items = listado
        Me.demoCandidatos = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafeCandidatos))
        Me.demoCandidatos.Start()
    End Sub



    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbCandidato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCandidato.SelectedIndexChanged
        Dim value As Integer = Me.cmbCandidato.SelectedIndex + 1
        Dim params As New ArrayList
        params.Add(value)
        funciones.obtenerRegistros("Resultados", Me.user, Me.WinSockCliente, params)
    End Sub
End Class