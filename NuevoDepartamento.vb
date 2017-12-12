Public Class NuevoDepartamento
    Private user As User
    Private demo As Threading.Thread = Nothing
    Private demoSelect As Threading.Thread = Nothing
    Private items As ArrayList
    Dim funciones As New Funciones
    Dim WithEvents WinSockCliente As New Cliente
    Delegate Sub CloseFormCallback(ByVal [text1] As String)
    Delegate Sub FillSelectCallback(ByVal [text1] As String)

    Public Sub Inicio(ByVal user As User, ByVal socket As Cliente)
        Me.user = user
        Me.WinSockCliente = socket
    End Sub

    Private Sub ThreadProcSafe()
        Me.CloseForm("")
    End Sub

    Private Sub ThreadProcSafeSelect()
        Me.FillSelect("")
    End Sub

    Private Sub CloseForm(ByVal [text1] As String)
        If Me.InvokeRequired Then
            Dim d As New CloseFormCallback(AddressOf CloseForm)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FillSelect(ByVal [text] As String)
        If Me.InvokeRequired Then
            Dim d As New FillSelectCallback(AddressOf FillSelect)
            Me.Invoke(d, New Object() {[text]})
        Else
            Dim elements As New Dictionary(Of Integer, String)()
            For Each item As ArrayList In Me.items
                elements.Add(item.Item(0), item.Item(1))
            Next
            Me.cmbPais.DataSource = New BindingSource(elements, Nothing)
            Me.cmbPais.DisplayMember = "Value"
            Me.cmbPais.ValueMember = "Key"
        End If
    End Sub

    Private Sub RespuestaObtenerRegistros(ByVal listado As ArrayList, ByVal tabla As String) Handles WinSockCliente.RespuestaObtener
        Me.items = listado
        Me.demoSelect = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafeSelect))
        Me.demoSelect.Start()
    End Sub

    Private Sub RespuestaCrearRegistro(ByVal respuesta As Solicitud) Handles WinSockCliente.RespuestaCrearRegistro
        Debug.WriteLine("Respuesta: " + respuesta.MensajeSolicitud)
        If (respuesta.MensajeSolicitud = "Registro Creado!") Then
            MsgBox("Departamento Creado!", MsgBoxStyle.OkOnly)
            Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
            Me.demo.Start()
        Else
            MsgBox("Error al Crear el Departamento", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub NuevoDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.obtenerRegistros("Paises", Me.user, Me.WinSockCliente)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim hash As New ArrayList()
        Dim key As String = DirectCast(Me.cmbPais.SelectedItem, KeyValuePair(Of Integer, String)).Key
        hash.Add(key)
        hash.Add(Me.txtNombre.Text)
        Dim registro As New Registro("Departamento", hash)
        funciones.nuevoRegistro(registro, Me.WinSockCliente)
    End Sub
End Class