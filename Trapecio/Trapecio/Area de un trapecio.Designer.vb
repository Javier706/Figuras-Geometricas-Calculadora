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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBaseMayor = New System.Windows.Forms.TextBox()
        Me.txtBaseMenor = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(164, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Área del trapecio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(46, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base mayor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(46, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Base menor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(46, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Altura"
        '
        'txtBaseMayor
        '
        Me.txtBaseMayor.Location = New System.Drawing.Point(178, 89)
        Me.txtBaseMayor.Name = "txtBaseMayor"
        Me.txtBaseMayor.Size = New System.Drawing.Size(154, 23)
        Me.txtBaseMayor.TabIndex = 4
        '
        'txtBaseMenor
        '
        Me.txtBaseMenor.Location = New System.Drawing.Point(178, 134)
        Me.txtBaseMenor.Name = "txtBaseMenor"
        Me.txtBaseMenor.Size = New System.Drawing.Size(154, 23)
        Me.txtBaseMenor.TabIndex = 5
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Salmon
        Me.Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calcular.Location = New System.Drawing.Point(47, 266)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(100, 26)
        Me.Calcular.TabIndex = 7
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.Salmon
        Me.Limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Limpiar.Location = New System.Drawing.Point(174, 266)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 26)
        Me.Limpiar.TabIndex = 8
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.Salmon
        Me.Cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cerrar.Location = New System.Drawing.Point(311, 266)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(100, 26)
        Me.Cerrar.TabIndex = 9
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(46, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(178, 216)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(154, 23)
        Me.txtResultado.TabIndex = 11
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(178, 174)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(154, 23)
        Me.txtAltura.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(467, 314)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.txtBaseMenor)
        Me.Controls.Add(Me.txtBaseMayor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Area del Trapecio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBaseMayor As TextBox
    Friend WithEvents txtBaseMenor As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Cerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtAltura As TextBox
End Class
