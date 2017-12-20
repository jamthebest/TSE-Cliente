Public Class PlanillaPresidencial
    Private user As User
    Private demo As Threading.Thread = Nothing
    Private demoCandidatos As Threading.Thread = Nothing
    Private items As ArrayList
    Dim funciones As New Funciones
    Dim WithEvents WinSockCliente As New Cliente
    Delegate Sub CloseFormCallback(ByVal [text1] As String)
    Delegate Sub FillCandidatosCallback(ByVal [text1] As String)

    Public Sub Inicio(ByVal user As User, ByVal socket As Cliente)
        Me.user = user
        Me.WinSockCliente = socket
    End Sub

    Private Sub ThreadProcSafe()
        Me.CloseForm("")
    End Sub

    Private Sub ThreadProcSafeCandidatos()
        Me.FillCandidatos("")
    End Sub

    Private Sub CloseForm(ByVal [text1] As String)
        If Me.InvokeRequired Then
            Dim d As New CloseFormCallback(AddressOf CloseForm)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Me.Visible = False
            Me.Close()
        End If
    End Sub

    Private Sub FillCandidatos(ByVal [text] As String)
        If Me.InvokeRequired Then
            Dim d As New FillCandidatosCallback(AddressOf FillCandidatos)
            Me.Invoke(d, New Object() {[text]})
        Else
            Debug.WriteLine("Response: " & Me.items.Count.ToString())
            Dim index As Integer = 0
            Me.pnlCandidatos.ColumnCount = Me.items.Count
            For Each item As ArrayList In Me.items
                Dim candi As New Candidato(item.Item(1), item.Item(5), item.Item(4), Me, Nothing, Nothing, item.Item(3), item.Item(6))
                Me.pnlCandidatos.Controls.Add(candi, index, 0)
                index = index + 1
            Next
        End If
    End Sub

    Private Sub RespuestaObtenerRegistros(ByVal listado As ArrayList, ByVal tabla As String) Handles WinSockCliente.RespuestaObtener
        Me.items = listado
        Me.demoCandidatos = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafeCandidatos))
        Me.demoCandidatos.Start()
    End Sub

    Private Sub RespuestaCrearRegistro(ByVal respuesta As Solicitud) Handles WinSockCliente.RespuestaCrearRegistro
        If Not (Me.Visible) Then
            Return
        End If
        Debug.WriteLine("Respuesta: " + respuesta.MensajeSolicitud)
        If (respuesta.MensajeSolicitud = "Registro Creado!") Then
            MsgBox("Voto Creado!", MsgBoxStyle.OkOnly)
            Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
            Me.demo.Start()
        Else
            MsgBox("Error al contabilizar el Voto", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub PlanillaPresidencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New ArrayList
        params.Add(1)
        funciones.obtenerRegistros("Candidatos", Me.user, Me.WinSockCliente, params)
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim voto As Integer = 0
        For Each cand As Candidato In Me.pnlCandidatos.Controls
            If cand.estaActivo() Then
                voto = cand.getCandidato()
            End If
        Next
        If voto = 0 Then
            Me.Close()
        Else
            Dim hash As New ArrayList()
            hash.Add(Me.user.idUser)
            hash.Add(voto)
            Dim registro As New Registro("Voto", hash)
            funciones.nuevoRegistro(registro, Me.WinSockCliente)
        End If
    End Sub

    Public Sub validar()
        For Each cand As Candidato In Me.pnlCandidatos.Controls
            If cand.estaActivo() Then
                cand.removerMarca()
            End If
        Next
    End Sub
End Class