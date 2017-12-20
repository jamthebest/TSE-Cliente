<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Candidato
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.imgPartido = New System.Windows.Forms.PictureBox()
        Me.lblPartido = New System.Windows.Forms.Label()
        Me.imgCandidato = New System.Windows.Forms.PictureBox()
        Me.lblCandidato = New System.Windows.Forms.Label()
        Me.cmdVotar = New System.Windows.Forms.Button()
        CType(Me.imgPartido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCandidato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgPartido
        '
        Me.imgPartido.Location = New System.Drawing.Point(3, 3)
        Me.imgPartido.Name = "imgPartido"
        Me.imgPartido.Size = New System.Drawing.Size(173, 34)
        Me.imgPartido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPartido.TabIndex = 0
        Me.imgPartido.TabStop = False
        '
        'lblPartido
        '
        Me.lblPartido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartido.Location = New System.Drawing.Point(3, 40)
        Me.lblPartido.Name = "lblPartido"
        Me.lblPartido.Size = New System.Drawing.Size(173, 25)
        Me.lblPartido.TabIndex = 1
        Me.lblPartido.Text = "Partido Político"
        Me.lblPartido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgCandidato
        '
        Me.imgCandidato.Location = New System.Drawing.Point(23, 68)
        Me.imgCandidato.Name = "imgCandidato"
        Me.imgCandidato.Size = New System.Drawing.Size(124, 159)
        Me.imgCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCandidato.TabIndex = 2
        Me.imgCandidato.TabStop = False
        '
        'lblCandidato
        '
        Me.lblCandidato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidato.Location = New System.Drawing.Point(5, 230)
        Me.lblCandidato.Name = "lblCandidato"
        Me.lblCandidato.Size = New System.Drawing.Size(171, 30)
        Me.lblCandidato.TabIndex = 3
        Me.lblCandidato.Text = "Nombre Candidato"
        Me.lblCandidato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdVotar
        '
        Me.cmdVotar.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVotar.Location = New System.Drawing.Point(23, 263)
        Me.cmdVotar.Name = "cmdVotar"
        Me.cmdVotar.Size = New System.Drawing.Size(124, 59)
        Me.cmdVotar.TabIndex = 4
        Me.cmdVotar.UseVisualStyleBackColor = True
        '
        'Candidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.cmdVotar)
        Me.Controls.Add(Me.lblCandidato)
        Me.Controls.Add(Me.imgCandidato)
        Me.Controls.Add(Me.lblPartido)
        Me.Controls.Add(Me.imgPartido)
        Me.Name = "Candidato"
        Me.Size = New System.Drawing.Size(179, 337)
        CType(Me.imgPartido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCandidato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgPartido As System.Windows.Forms.PictureBox
    Friend WithEvents lblPartido As System.Windows.Forms.Label
    Friend WithEvents imgCandidato As System.Windows.Forms.PictureBox
    Friend WithEvents lblCandidato As System.Windows.Forms.Label
    Friend WithEvents cmdVotar As System.Windows.Forms.Button

End Class
