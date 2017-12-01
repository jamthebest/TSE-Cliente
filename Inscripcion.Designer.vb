<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inscripcion))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InscribirPartidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPartido = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionDeCandidatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPresidente = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlcalde = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDiputado = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVotante = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPais = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDepartamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMunicipio = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InscripcionDeCandidatosToolStripMenuItem, Me.InscribirPartidoToolStripMenuItem, Me.AgregarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InscribirPartidoToolStripMenuItem
        '
        Me.InscribirPartidoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPartido})
        Me.InscribirPartidoToolStripMenuItem.Name = "InscribirPartidoToolStripMenuItem"
        Me.InscribirPartidoToolStripMenuItem.Size = New System.Drawing.Size(147, 20)
        Me.InscribirPartidoToolStripMenuItem.Text = "Inscripción de Entidades"
        '
        'menuPartido
        '
        Me.menuPartido.Name = "menuPartido"
        Me.menuPartido.Size = New System.Drawing.Size(155, 22)
        Me.menuPartido.Text = "Partido Político"
        '
        'InscripcionDeCandidatosToolStripMenuItem
        '
        Me.InscripcionDeCandidatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPresidente, Me.menuAlcalde, Me.menuDiputado, Me.menuVotante})
        Me.InscripcionDeCandidatosToolStripMenuItem.Image = Global.Proyecto.My.Resources.Resources.business_application_addmale_useradd_insert_add_user_client_2312
        Me.InscripcionDeCandidatosToolStripMenuItem.Name = "InscripcionDeCandidatosToolStripMenuItem"
        Me.InscripcionDeCandidatosToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.InscripcionDeCandidatosToolStripMenuItem.Text = "Inscripción de Personas"
        '
        'menuPresidente
        '
        Me.menuPresidente.Name = "menuPresidente"
        Me.menuPresidente.Size = New System.Drawing.Size(152, 22)
        Me.menuPresidente.Text = "Presidentes"
        '
        'menuAlcalde
        '
        Me.menuAlcalde.Name = "menuAlcalde"
        Me.menuAlcalde.Size = New System.Drawing.Size(152, 22)
        Me.menuAlcalde.Text = "Alcaldes"
        '
        'menuDiputado
        '
        Me.menuDiputado.Name = "menuDiputado"
        Me.menuDiputado.Size = New System.Drawing.Size(152, 22)
        Me.menuDiputado.Text = "Diputados"
        '
        'menuVotante
        '
        Me.menuVotante.Name = "menuVotante"
        Me.menuVotante.Size = New System.Drawing.Size(152, 22)
        Me.menuVotante.Text = "Votante"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPais, Me.menuDepartamento, Me.menuMunicipio})
        Me.AgregarToolStripMenuItem.Image = Global.Proyecto.My.Resources.Resources.globe_world_download_2324
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar Ubicación"
        '
        'menuPais
        '
        Me.menuPais.Name = "menuPais"
        Me.menuPais.Size = New System.Drawing.Size(150, 22)
        Me.menuPais.Text = "Pais"
        '
        'menuDepartamento
        '
        Me.menuDepartamento.Name = "menuDepartamento"
        Me.menuDepartamento.Size = New System.Drawing.Size(150, 22)
        Me.menuDepartamento.Text = "Departamento"
        '
        'menuMunicipio
        '
        Me.menuMunicipio.Name = "menuMunicipio"
        Me.menuMunicipio.Size = New System.Drawing.Size(150, 22)
        Me.menuMunicipio.Text = "Municipio"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Proyecto.My.Resources.Resources.TSE
        Me.PictureBox5.Location = New System.Drawing.Point(616, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(207, 77)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Inscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(835, 508)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inscripcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InscripcionDeCandidatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuPresidente As ToolStripMenuItem
    Friend WithEvents menuDiputado As ToolStripMenuItem
    Friend WithEvents menuAlcalde As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuPais As ToolStripMenuItem
    Friend WithEvents menuDepartamento As ToolStripMenuItem
    Friend WithEvents menuMunicipio As ToolStripMenuItem
    Friend WithEvents menuVotante As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents InscribirPartidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPartido As System.Windows.Forms.ToolStripMenuItem
End Class
