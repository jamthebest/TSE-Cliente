Public Class NuevoUsuario
    Private user As User
    Private demo As Threading.Thread = Nothing
    Private demoSelect As Threading.Thread = Nothing
    Private items As ArrayList
    Dim funciones As New Funciones
    Dim actualCambio As String = "pais"
    Dim path As String = IO.Path.GetFullPath(Proyecto.My.Resources.ResourceManager.BaseName)
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
            If Me.actualCambio = "pais" Then
                Me.cmbPais.DataSource = New BindingSource(elements, Nothing)
                Me.cmbPais.DisplayMember = "Value"
                Me.cmbPais.ValueMember = "Key"
            ElseIf Me.actualCambio = "departamento" Then
                Me.cmbDepartamento.DataSource = New BindingSource(elements, Nothing)
                Me.cmbDepartamento.DisplayMember = "Value"
                Me.cmbDepartamento.ValueMember = "Key"
            Else
                Me.cmbMunicipio.DataSource = New BindingSource(elements, Nothing)
                Me.cmbMunicipio.DisplayMember = "Value"
                Me.cmbMunicipio.ValueMember = "Key"
            End If
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
            MsgBox("Usuario Creado!", MsgBoxStyle.OkOnly)
            Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
            Me.demo.Start()
        Else
            MsgBox("Error al Crear el Usuario", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub NuevaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.path = Me.path.Substring(0, Me.path.Length - 28) & "Resources\App-login-manager-icon.png"
        funciones.obtenerRegistros("Paises", Me.user, Me.WinSockCliente)
    End Sub

    Private Sub cmbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPais.SelectedIndexChanged
        Dim key As Integer = DirectCast(Me.cmbPais.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim params As New ArrayList
        Me.actualCambio = "departamento"
        Me.cmbDepartamento.Enabled = True
        params.Add(key)
        funciones.obtenerRegistros("Departamentos", Me.user, Me.WinSockCliente, params)
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        Dim keyPais As Integer = DirectCast(Me.cmbPais.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim key As Integer = DirectCast(Me.cmbDepartamento.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim params As New ArrayList
        Me.actualCambio = "municipio"
        Me.cmbMunicipio.Enabled = True
        params.Add(keyPais)
        params.Add(key)
        funciones.obtenerRegistros("Municipios", Me.user, Me.WinSockCliente, params)
    End Sub

    Private Sub cmdFoto_Click(sender As Object, e As EventArgs) Handles cmdFoto.Click
        Dim dialog As New OpenFileDialog
        If dialog.ShowDialog = DialogResult.OK Then
            If dialog.FileName <> String.Empty Then
                Me.imgFoto.Image = Bitmap.FromFile(dialog.FileName)
                Me.path = dialog.FileName
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim hash As New ArrayList()
        Dim key As Integer = DirectCast(Me.cmbMunicipio.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim image As Byte() = funciones.FileToByteArray(Me.path)
        hash.Add(Me.txtIdentidad.Text)
        hash.Add(Me.txtNombre.Text)
        hash.Add(key)
        hash.Add(image)
        hash.Add(Me.txtUsuario.Text)
        hash.Add(funciones.MD5Encrypt(Me.txtContraseña.Text))
        hash.Add(2)
        Dim registro As New Registro("Usuario", hash)
        funciones.nuevoRegistro(registro, Me.WinSockCliente)
    End Sub
End Class