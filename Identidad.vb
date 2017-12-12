Public Class Identidad
    Private user As User
    Private demo As Threading.Thread = Nothing
    Private tipo As String
    Private estaAbierto As Boolean = True
    Dim items As New ArrayList
    Dim funciones As New Funciones
    Dim WithEvents WinSockCliente As New Cliente
    Delegate Sub CloseFormCallback(ByVal [text1] As String)

    Public Sub Inicio(ByVal user As User, ByVal tipo As String, ByVal socket As Cliente)
        Me.user = user
        Me.tipo = tipo
        Me.WinSockCliente = socket
    End Sub

    Private Sub ThreadProcSafe()
        Me.CloseForm("")
    End Sub

    Private Sub CloseForm(ByVal [text1] As String)
        If Me.InvokeRequired Then
            Dim d As New CloseFormCallback(AddressOf CloseForm)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Dim nuevo As New NuevoCandidato
            nuevo.Inicio(Me.user, Me.tipo, Me.WinSockCliente, Me.txtIdentidad.Text, Me.items)
            nuevo.MdiParent = Me.MdiParent
            nuevo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub RespuestaObtenerRegistros(ByVal listado As ArrayList, ByVal tabla As String) Handles WinSockCliente.RespuestaObtener
        If tabla = "Personas" And Me.estaAbierto Then
            Me.estaAbierto = False
            Me.items = If(listado.Count > 0, listado.Item(0), New ArrayList)
            Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
            Me.demo.Start()
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim parametros As New ArrayList
        parametros.Add("identidad")
        parametros.Add(Me.txtIdentidad.Text)
        funciones.obtenerRegistros("Personas", Me.user, Me.WinSockCliente, parametros)
    End Sub
End Class