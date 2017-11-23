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
        Me.btnPresidencial = New System.Windows.Forms.Button()
        Me.btnDiputacion = New System.Windows.Forms.Button()
        Me.btnAlcaldia = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.lstPresidentes = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDiputados = New System.Windows.Forms.ListBox()
        Me.lstAlcaldes = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPresidencial
        '
        Me.btnPresidencial.Location = New System.Drawing.Point(6, 65)
        Me.btnPresidencial.Name = "btnPresidencial"
        Me.btnPresidencial.Size = New System.Drawing.Size(75, 23)
        Me.btnPresidencial.TabIndex = 3
        Me.btnPresidencial.Text = "Presidencial"
        Me.btnPresidencial.UseVisualStyleBackColor = True
        '
        'btnDiputacion
        '
        Me.btnDiputacion.Location = New System.Drawing.Point(6, 297)
        Me.btnDiputacion.Name = "btnDiputacion"
        Me.btnDiputacion.Size = New System.Drawing.Size(75, 23)
        Me.btnDiputacion.TabIndex = 4
        Me.btnDiputacion.Text = "Diputación"
        Me.btnDiputacion.UseVisualStyleBackColor = True
        '
        'btnAlcaldia
        '
        Me.btnAlcaldia.Location = New System.Drawing.Point(6, 179)
        Me.btnAlcaldia.Name = "btnAlcaldia"
        Me.btnAlcaldia.Size = New System.Drawing.Size(75, 23)
        Me.btnAlcaldia.TabIndex = 5
        Me.btnAlcaldia.Text = "Alcaldia"
        Me.btnAlcaldia.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(105, 259)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(84, 98)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(273, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.App_login_manager_icon
        Me.PictureBox1.Location = New System.Drawing.Point(105, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(105, 141)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(84, 98)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'btnUsuario
        '
        Me.btnUsuario.Location = New System.Drawing.Point(279, 141)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnUsuario.TabIndex = 7
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'lstPresidentes
        '
        Me.lstPresidentes.FormattingEnabled = True
        Me.lstPresidentes.Location = New System.Drawing.Point(48, 65)
        Me.lstPresidentes.Name = "lstPresidentes"
        Me.lstPresidentes.Size = New System.Drawing.Size(168, 329)
        Me.lstPresidentes.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstDiputados)
        Me.GroupBox1.Controls.Add(Me.lstAlcaldes)
        Me.GroupBox1.Controls.Add(Me.lstPresidentes)
        Me.GroupBox1.Location = New System.Drawing.Point(470, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 408)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generación de Resultados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Planilla Diputados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Planilla Alcaldia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Planilla Presidencial"
        '
        'lstDiputados
        '
        Me.lstDiputados.FormattingEnabled = True
        Me.lstDiputados.Location = New System.Drawing.Point(429, 65)
        Me.lstDiputados.Name = "lstDiputados"
        Me.lstDiputados.Size = New System.Drawing.Size(168, 329)
        Me.lstDiputados.TabIndex = 10
        '
        'lstAlcaldes
        '
        Me.lstAlcaldes.FormattingEnabled = True
        Me.lstAlcaldes.Location = New System.Drawing.Point(237, 65)
        Me.lstAlcaldes.Name = "lstAlcaldes"
        Me.lstAlcaldes.Size = New System.Drawing.Size(168, 329)
        Me.lstAlcaldes.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.btnPresidencial)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.btnUsuario)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.btnDiputacion)
        Me.GroupBox2.Controls.Add(Me.btnAlcaldia)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 408)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inscripciones"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Proyecto.My.Resources.Resources.TSE
        Me.PictureBox5.Location = New System.Drawing.Point(240, 297)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(189, 105)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Inscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Inscripcion"
        Me.Text = "Inscripción de Candidatos"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnPresidencial As Button
    Friend WithEvents btnDiputacion As Button
    Friend WithEvents btnAlcaldia As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnUsuario As Button
    Friend WithEvents lstPresidentes As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstDiputados As ListBox
    Friend WithEvents lstAlcaldes As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
