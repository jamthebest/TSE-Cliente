Public Class NuevoPartido
    Private user As User
    Private demo As Threading.Thread = Nothing
    Dim funciones As New Funciones
    Dim path As String = IO.Path.GetFullPath(Proyecto.My.Resources.ResourceManager.BaseName)
    Dim WithEvents WinSockCliente As New Cliente
    Delegate Sub CloseFormCallback(ByVal [text1] As String)

    Public Sub Inicio(ByVal user As User, ByVal socket As Cliente)
        Me.user = user
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
            Me.Close()
        End If
    End Sub

    Private Sub RespuestaCrearRegistro(ByVal respuesta As Solicitud) Handles WinSockCliente.RespuestaCrearRegistro
        Debug.WriteLine("Respuesta: " + respuesta.MensajeSolicitud)
        If (respuesta.MensajeSolicitud = "Registro Creado!") Then
            MsgBox("Partido Político Creado!", MsgBoxStyle.OkOnly)
            Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
            Me.demo.Start()
        Else
            MsgBox("Error al Crear el Partido Político", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cmdLogo_Click(sender As Object, e As EventArgs) Handles cmdLogo.Click
        Dim dialog As New OpenFileDialog
        If dialog.ShowDialog = DialogResult.OK Then
            If dialog.FileName <> String.Empty Then
                Me.imgLogo.Image = Bitmap.FromFile(dialog.FileName)
                Me.path = dialog.FileName
                Debug.WriteLine("New Path: " & dialog.FileName)
            End If
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim hash As New ArrayList()
        Dim image As Byte() = funciones.FileToByteArray(Me.path)
        hash.Add(Me.txtNombre.Text)
        hash.Add(image)
        Dim registro As New Registro("PartidoPolitico", hash)
        funciones.nuevoRegistro(registro, Me.WinSockCliente)
    End Sub

    Private Sub NuevoPartido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.path = Me.path.Substring(0, Me.path.Length - 28) & "Resources\App_login_manager_icon.png"
        Debug.WriteLine("Path: " & Me.path)
    End Sub
End Class