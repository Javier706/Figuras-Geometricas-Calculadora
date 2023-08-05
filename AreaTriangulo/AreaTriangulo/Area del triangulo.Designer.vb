<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Triangulo
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
        Me.TxtBase = New System.Windows.Forms.TextBox()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(139, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Área del triangulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(76, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(76, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(76, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Resultado"
        '
        'TxtBase
        '
        Me.TxtBase.Location = New System.Drawing.Point(160, 51)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(165, 23)
        Me.TxtBase.TabIndex = 4
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(160, 90)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(165, 23)
        Me.TxtAltura.TabIndex = 5
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(160, 124)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(165, 23)
        Me.TxtResultado.TabIndex = 6
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Calcular.ForeColor = System.Drawing.Color.White
        Me.Calcular.Location = New System.Drawing.Point(94, 179)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(77, 23)
        Me.Calcular.TabIndex = 7
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Limpiar.ForeColor = System.Drawing.Color.White
        Me.Limpiar.Location = New System.Drawing.Point(192, 179)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(76, 23)
        Me.Limpiar.TabIndex = 8
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cerrar.ForeColor = System.Drawing.Color.White
        Me.Cerrar.Location = New System.Drawing.Point(292, 179)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(76, 23)
        Me.Cerrar.TabIndex = 9
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'Triangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(499, 327)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.TxtBase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Triangulo"
        Me.Text = "Área del triangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBase As TextBox
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Cerrar As Button
End Class
