<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCandidato
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdInscribir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPartido = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.cmdFoto = New System.Windows.Forms.Button()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInscribir
        '
        Me.cmdInscribir.Location = New System.Drawing.Point(354, 347)
        Me.cmdInscribir.Name = "cmdInscribir"
        Me.cmdInscribir.Size = New System.Drawing.Size(75, 23)
        Me.cmdInscribir.TabIndex = 9
        Me.cmdInscribir.Text = "Inscribir"
        Me.cmdInscribir.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(501, 347)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'imgFoto
        '
        Me.imgFoto.Image = Global.Proyecto.My.Resources.Resources.App_login_manager_icon
        Me.imgFoto.Location = New System.Drawing.Point(463, 64)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(148, 152)
        Me.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgFoto.TabIndex = 8
        Me.imgFoto.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(174, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(281, 24)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "CANDIDATO PRESIDENCIAL"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto.My.Resources.Resources.TSE
        Me.PictureBox2.Location = New System.Drawing.Point(12, 332)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Enabled = False
        Me.txtIdentidad.Location = New System.Drawing.Point(130, 64)
        Me.txtIdentidad.Mask = "9999-9999-99999"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(311, 20)
        Me.txtIdentidad.TabIndex = 81
        Me.txtIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(130, 224)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(311, 20)
        Me.txtContraseña.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(130, 198)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(311, 20)
        Me.txtUsuario.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Usuario:"
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.Enabled = False
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(130, 170)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(311, 21)
        Me.cmbMunicipio.TabIndex = 76
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.Enabled = False
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(130, 143)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(311, 21)
        Me.cmbDepartamento.TabIndex = 75
        '
        'cmbPais
        '
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(130, 116)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(311, 21)
        Me.cmbPais.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Municipio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Departamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Pais"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(130, 90)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(311, 20)
        Me.txtNombre.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Identidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Partido Político:"
        '
        'cmbPartido
        '
        Me.cmbPartido.FormattingEnabled = True
        Me.cmbPartido.Location = New System.Drawing.Point(130, 250)
        Me.cmbPartido.Name = "cmbPartido"
        Me.cmbPartido.Size = New System.Drawing.Size(311, 21)
        Me.cmbPartido.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Cargo:"
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(130, 277)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(311, 20)
        Me.txtCargo.TabIndex = 85
        '
        'cmdFoto
        '
        Me.cmdFoto.Location = New System.Drawing.Point(501, 227)
        Me.cmdFoto.Name = "cmdFoto"
        Me.cmdFoto.Size = New System.Drawing.Size(75, 23)
        Me.cmdFoto.TabIndex = 86
        Me.cmdFoto.Text = "Cargar Foto"
        Me.cmdFoto.UseVisualStyleBackColor = True
        '
        'NuevoCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 395)
        Me.Controls.Add(Me.cmdFoto)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPartido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbMunicipio)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.cmbPais)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdInscribir)
        Me.Controls.Add(Me.imgFoto)
        Me.Name = "NuevoCandidato"
        Me.Text = "Datos de Inscripciones Presidencial"
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgFoto As PictureBox
    Friend WithEvents cmdInscribir As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtIdentidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPartido As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents cmdFoto As System.Windows.Forms.Button
End Class
