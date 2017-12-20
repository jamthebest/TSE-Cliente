<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCandidato = New System.Windows.Forms.ComboBox()
        Me.tabla = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Candidatos"
        '
        'cmbCandidato
        '
        Me.cmbCandidato.FormattingEnabled = True
        Me.cmbCandidato.Items.AddRange(New Object() {"Presidentes", "Alcaldes", "Diputados"})
        Me.cmbCandidato.Location = New System.Drawing.Point(79, 13)
        Me.cmbCandidato.Name = "cmbCandidato"
        Me.cmbCandidato.Size = New System.Drawing.Size(141, 21)
        Me.cmbCandidato.TabIndex = 1
        '
        'tabla
        '
        Me.tabla.AutoScroll = True
        Me.tabla.ColumnCount = 3
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tabla.Location = New System.Drawing.Point(13, 51)
        Me.tabla.Name = "tabla"
        Me.tabla.RowCount = 1
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tabla.Size = New System.Drawing.Size(924, 415)
        Me.tabla.TabIndex = 2
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(442, 472)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Cerrar"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 507)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.cmbCandidato)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resultados"
        Me.Text = "Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCandidato As System.Windows.Forms.ComboBox
    Friend WithEvents tabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
