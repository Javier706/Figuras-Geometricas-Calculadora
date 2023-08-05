<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labol1 = New System.Windows.Forms.Label()
        Me.txtLado1 = New System.Windows.Forms.TextBox()
        Me.labol2 = New System.Windows.Forms.Label()
        Me.Calcular2 = New System.Windows.Forms.Button()
        Me.Limpiar2 = New System.Windows.Forms.Button()
        Me.Cerrar2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtLado2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Área del cuadrado"
        '
        'labol1
        '
        Me.labol1.AutoSize = True
        Me.labol1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.labol1.ForeColor = System.Drawing.Color.Blue
        Me.labol1.Location = New System.Drawing.Point(40, 73)
        Me.labol1.Name = "labol1"
        Me.labol1.Size = New System.Drawing.Size(65, 21)
        Me.labol1.TabIndex = 1
        Me.labol1.Text = "Lado 1"
        '
        'txtLado1
        '
        Me.txtLado1.Location = New System.Drawing.Point(146, 68)
        Me.txtLado1.Name = "txtLado1"
        Me.txtLado1.Size = New System.Drawing.Size(169, 23)
        Me.txtLado1.TabIndex = 2
        '
        'labol2
        '
        Me.labol2.AutoSize = True
        Me.labol2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.labol2.ForeColor = System.Drawing.Color.Blue
        Me.labol2.Location = New System.Drawing.Point(40, 117)
        Me.labol2.Name = "labol2"
        Me.labol2.Size = New System.Drawing.Size(65, 21)
        Me.labol2.TabIndex = 3
        Me.labol2.Text = "Lado 2"
        '
        'Calcular2
        '
        Me.Calcular2.BackColor = System.Drawing.Color.Blue
        Me.Calcular2.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Calcular2.ForeColor = System.Drawing.Color.White
        Me.Calcular2.Location = New System.Drawing.Point(65, 199)
        Me.Calcular2.Name = "Calcular2"
        Me.Calcular2.Size = New System.Drawing.Size(91, 25)
        Me.Calcular2.TabIndex = 5
        Me.Calcular2.Text = "Calcular "
        Me.Calcular2.UseVisualStyleBackColor = False
        '
        'Limpiar2
        '
        Me.Limpiar2.BackColor = System.Drawing.Color.Blue
        Me.Limpiar2.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Limpiar2.ForeColor = System.Drawing.Color.White
        Me.Limpiar2.Location = New System.Drawing.Point(178, 199)
        Me.Limpiar2.Name = "Limpiar2"
        Me.Limpiar2.Size = New System.Drawing.Size(91, 25)
        Me.Limpiar2.TabIndex = 6
        Me.Limpiar2.Text = "Limpiar"
        Me.Limpiar2.UseVisualStyleBackColor = False
        '
        'Cerrar2
        '
        Me.Cerrar2.BackColor = System.Drawing.Color.Blue
        Me.Cerrar2.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Cerrar2.ForeColor = System.Drawing.Color.White
        Me.Cerrar2.Location = New System.Drawing.Point(297, 199)
        Me.Cerrar2.Name = "Cerrar2"
        Me.Cerrar2.Size = New System.Drawing.Size(91, 25)
        Me.Cerrar2.TabIndex = 7
        Me.Cerrar2.Text = "Cerrar"
        Me.Cerrar2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(40, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Resultado"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(146, 157)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(169, 23)
        Me.txtResult.TabIndex = 9
        '
        'txtLado2
        '
        Me.txtLado2.Location = New System.Drawing.Point(146, 117)
        Me.txtLado2.Name = "txtLado2"
        Me.txtLado2.Size = New System.Drawing.Size(169, 23)
        Me.txtLado2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 261)
        Me.Controls.Add(Me.txtLado2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cerrar2)
        Me.Controls.Add(Me.Limpiar2)
        Me.Controls.Add(Me.Calcular2)
        Me.Controls.Add(Me.labol2)
        Me.Controls.Add(Me.txtLado1)
        Me.Controls.Add(Me.labol1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Área del cuadrado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labol1 As Label
    Friend WithEvents txtLado1 As TextBox
    Friend WithEvents labol2 As Label
    Friend WithEvents txtLado2 As TextBox
    Friend WithEvents Calcular2 As Button
    Friend WithEvents Limpiar2 As Button
    Friend WithEvents Cerrar2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResult As TextBox
End Class
