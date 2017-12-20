<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Votación
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
        Me.cmdPresidente = New System.Windows.Forms.Button()
        Me.cmdAlcalde = New System.Windows.Forms.Button()
        Me.cmdDiputado = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdPresidente
        '
        Me.cmdPresidente.Location = New System.Drawing.Point(12, 23)
        Me.cmdPresidente.Name = "cmdPresidente"
        Me.cmdPresidente.Size = New System.Drawing.Size(200, 250)
        Me.cmdPresidente.TabIndex = 0
        Me.cmdPresidente.Text = "Planilla Presidencial"
        Me.cmdPresidente.UseVisualStyleBackColor = True
        '
        'cmdAlcalde
        '
        Me.cmdAlcalde.Location = New System.Drawing.Point(261, 23)
        Me.cmdAlcalde.Name = "cmdAlcalde"
        Me.cmdAlcalde.Size = New System.Drawing.Size(200, 250)
        Me.cmdAlcalde.TabIndex = 1
        Me.cmdAlcalde.Text = "Planilla de Alcaldes"
        Me.cmdAlcalde.UseVisualStyleBackColor = True
        '
        'cmdDiputado
        '
        Me.cmdDiputado.Location = New System.Drawing.Point(502, 23)
        Me.cmdDiputado.Name = "cmdDiputado"
        Me.cmdDiputado.Size = New System.Drawing.Size(200, 250)
        Me.cmdDiputado.TabIndex = 2
        Me.cmdDiputado.Text = "Planilla de Diputados"
        Me.cmdDiputado.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(64, 322)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(569, 322)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Votación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 357)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdDiputado)
        Me.Controls.Add(Me.cmdAlcalde)
        Me.Controls.Add(Me.cmdPresidente)
        Me.Name = "Votación"
        Me.Text = "Votación"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPresidente As System.Windows.Forms.Button
    Friend WithEvents cmdAlcalde As System.Windows.Forms.Button
    Friend WithEvents cmdDiputado As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
