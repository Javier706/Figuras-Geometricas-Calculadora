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
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(126, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Área del rectangulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(52, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(52, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(121, 62)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(252, 46)
        Me.txtBase.TabIndex = 3
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(126, 114)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(247, 46)
        Me.txtAltura.TabIndex = 4
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Gray
        Me.Calcular.ForeColor = System.Drawing.Color.Yellow
        Me.Calcular.Location = New System.Drawing.Point(34, 240)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(136, 39)
        Me.Calcular.TabIndex = 5
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.Gray
        Me.Limpiar.ForeColor = System.Drawing.Color.Yellow
        Me.Limpiar.Location = New System.Drawing.Point(190, 240)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(136, 39)
        Me.Limpiar.TabIndex = 6
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.Gray
        Me.Cerrar.ForeColor = System.Drawing.Color.Yellow
        Me.Cerrar.Location = New System.Drawing.Point(347, 240)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(136, 39)
        Me.Cerrar.TabIndex = 7
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(126, 166)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(247, 46)
        Me.txtResultado.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(14, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(531, 319)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Viner Hand ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Form1"
        Me.Text = "Área del rectangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Cerrar As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label4 As Label
End Class
