Public Class NuevoCandidato
    Private tipo As String
    Private user As User
    Private demo As Threading.Thread = Nothing
    Private demoSelect As Threading.Thread = Nothing
    Private items As ArrayList
    Private identidad As String
    Dim funciones As New Funciones
    Dim actualCambio As String = "partido"
    Dim primeraCarga As Boolean = True
    Dim path As String = IO.Path.GetFullPath(Proyecto.My.Resources.ResourceManager.BaseName)
    Dim parametros As New ArrayList
    Dim WithEvents WinSockCliente As New Cliente
    Delegate Sub CloseFormCallback(ByVal [text1] As String)
    Delegate Sub FillSelectCallback(ByVal [text1] As String)

    Public Sub Inicio(ByVal user As User, ByVal tipo As String, ByVal socket As Cliente, ByVal identidad As String, Optional ByVal params As ArrayList = Nothing)
        Me.actualCambio = "partido"
        Me.primeraCarga = True
        Me.user = user
        Me.WinSockCliente = socket
        Me.tipo = tipo
        Me.identidad = identidad
        Dim mensaje As String = If(tipo = "Presidente", "Presidencial", If(tipo = "Alcalde", "a la Alcaldía", "a Diputación"))
        Me.Text = "Datos de Inscripciones " + mensaje
        Me.lblTitulo.Text = "CANDIDATO " + mensaje.ToUpper()
        Me.txtCargo.Text = tipo
        Me.parametros = params
        Me.txtIdentidad.Text = identidad
    End Sub

    Private Sub LlenarValores()
        If Me.parametros.Count > 0 Then
            Me.txtNombre.Enabled = False
            Me.txtUsuario.Enabled = False
            Me.txtContraseña.Enabled = False
            Me.cmbPais.Enabled = False
            Me.cmbDepartamento.Enabled = False
            Me.cmbMunicipio.Enabled = False
            Me.cmdFoto.Visible = False

            Me.txtNombre.Text = Me.parametros.Item(2)
            funciones.BytesToFile(Me.parametros.Item(3), "Foto")
            Me.imgFoto.ImageLocation = "Foto"
            Me.txtUsuario.Text = Me.parametros.Item(4)
            Me.cmbPais.Text = Me.parametros.Item(6)
            Me.cmbDepartamento.Text = Me.parametros.Item(7)
            Me.cmbMunicipio.Text = Me.parametros.Item(8)
        End If
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
            If Me.actualCambio = "partido" Then
                Me.cmbPartido.DataSource = New BindingSource(elements, Nothing)
                Me.cmbPartido.DisplayMember = "Value"
                Me.cmbPartido.ValueMember = "Key"
                If Me.primeraCarga Then
                    Me.actualCambio = "pais"
                    funciones.obtenerRegistros("Paises", Me.user, Me.WinSockCliente)
                End If
            ElseIf Me.actualCambio = "pais" Then
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
                If Me.primeraCarga Then
                    Me.LlenarValores()
                End If
                Me.primeraCarga = False
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
            MsgBox("Candidato Registrado!", MsgBoxStyle.OkOnly)
            Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
            Me.demo.Start()
        Else
            MsgBox("Error al Regisstrar al Candidato", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub NuevoCandidato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.path = "") Then
            Me.path = Me.path.Substring(0, Me.path.Length - 28) & "Resources\App_login_manager_icon.png"
        End If
        funciones.obtenerRegistros("Partidos", Me.user, Me.WinSockCliente)
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

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        If Not IsNothing(Me.demo) Then
            If Me.demo.IsAlive Then
                Me.demo.Abort()
            End If
        End If
        If Me.demoSelect.IsAlive Then
            Me.demoSelect.Abort()
        End If
        Me.Close()
    End Sub

    Private Sub cmdInscribir_Click(sender As Object, e As EventArgs) Handles cmdInscribir.Click
        Dim hash As New ArrayList()
        Dim key As Integer = DirectCast(Me.cmbPartido.SelectedItem, KeyValuePair(Of Integer, String)).Key
        hash.Add(key)
        hash.Add(If(Me.txtCargo.Text = "Presidente", 1, If(Me.txtCargo.Text = "Alcalde", 2, 3)))
        If Me.parametros.Count = 0 Then
            key = DirectCast(Me.cmbMunicipio.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim image As Byte() = funciones.FileToByteArray(Me.path)
            hash.Add(Me.txtIdentidad.Text)
            hash.Add(Me.txtNombre.Text)
            hash.Add(key)
            hash.Add(image)
            hash.Add(Me.txtUsuario.Text)
            hash.Add(funciones.MD5Encrypt(Me.txtContraseña.Text))
            hash.Add(2)
        Else
            hash.Add(Me.parametros.Item(0))
        End If
        Dim registro As New Registro("Candidato", hash)
        funciones.nuevoRegistro(registro, Me.WinSockCliente)
    End Sub
End Class