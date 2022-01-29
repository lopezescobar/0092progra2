<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAzucar = New System.Windows.Forms.TextBox()
        Me.txtFrijol = New System.Windows.Forms.TextBox()
        Me.txtArroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblR5 = New System.Windows.Forms.Label()
        Me.lblR4 = New System.Windows.Forms.Label()
        Me.lblR3 = New System.Windows.Forms.Label()
        Me.lblR2 = New System.Windows.Forms.Label()
        Me.lblR1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAzucar)
        Me.GroupBox1.Controls.Add(Me.txtFrijol)
        Me.GroupBox1.Controls.Add(Me.txtArroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "datos de ingreso"
        '
        'txtAzucar
        '
        Me.txtAzucar.Location = New System.Drawing.Point(139, 156)
        Me.txtAzucar.Name = "txtAzucar"
        Me.txtAzucar.Size = New System.Drawing.Size(100, 23)
        Me.txtAzucar.TabIndex = 5
        Me.txtAzucar.Text = "0"
        '
        'txtFrijol
        '
        Me.txtFrijol.Location = New System.Drawing.Point(139, 92)
        Me.txtFrijol.Name = "txtFrijol"
        Me.txtFrijol.Size = New System.Drawing.Size(100, 23)
        Me.txtFrijol.TabIndex = 4
        Me.txtFrijol.Text = "0"
        '
        'txtArroz
        '
        Me.txtArroz.Location = New System.Drawing.Point(139, 32)
        Me.txtArroz.Name = "txtArroz"
        Me.txtArroz.Size = New System.Drawing.Size(100, 23)
        Me.txtArroz.TabIndex = 3
        Me.txtArroz.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "librad de azucar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "libras de frijol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "libras de arroz"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblR5)
        Me.GroupBox2.Controls.Add(Me.lblR4)
        Me.GroupBox2.Controls.Add(Me.lblR3)
        Me.GroupBox2.Controls.Add(Me.lblR2)
        Me.GroupBox2.Controls.Add(Me.lblR1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 183)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'lblR5
        '
        Me.lblR5.AutoSize = True
        Me.lblR5.Location = New System.Drawing.Point(452, 98)
        Me.lblR5.Name = "lblR5"
        Me.lblR5.Size = New System.Drawing.Size(22, 15)
        Me.lblR5.TabIndex = 9
        Me.lblR5.Text = "0.0"
        '
        'lblR4
        '
        Me.lblR4.AutoSize = True
        Me.lblR4.Location = New System.Drawing.Point(452, 19)
        Me.lblR4.Name = "lblR4"
        Me.lblR4.Size = New System.Drawing.Size(22, 15)
        Me.lblR4.TabIndex = 8
        Me.lblR4.Text = "0.0"
        '
        'lblR3
        '
        Me.lblR3.AutoSize = True
        Me.lblR3.Location = New System.Drawing.Point(132, 137)
        Me.lblR3.Name = "lblR3"
        Me.lblR3.Size = New System.Drawing.Size(22, 15)
        Me.lblR3.TabIndex = 7
        Me.lblR3.Text = "0.0"
        '
        'lblR2
        '
        Me.lblR2.AutoSize = True
        Me.lblR2.Location = New System.Drawing.Point(132, 98)
        Me.lblR2.Name = "lblR2"
        Me.lblR2.Size = New System.Drawing.Size(22, 15)
        Me.lblR2.TabIndex = 6
        Me.lblR2.Text = "0.0"
        '
        'lblR1
        '
        Me.lblR1.AutoSize = True
        Me.lblR1.Location = New System.Drawing.Point(132, 46)
        Me.lblR1.Name = "lblR1"
        Me.lblR1.Size = New System.Drawing.Size(22, 15)
        Me.lblR1.TabIndex = 5
        Me.lblR1.Text = "0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(365, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(365, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pago con el IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Valor del IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pago antes del IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(408, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 194)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operaciones"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(34, 141)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(34, 84)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(34, 32)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptat"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAzucar As TextBox
    Friend WithEvents txtFrijol As TextBox
    Friend WithEvents txtArroz As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblR5 As Label
    Friend WithEvents lblR4 As Label
    Friend WithEvents lblR3 As Label
    Friend WithEvents lblR2 As Label
    Friend WithEvents lblR1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAceptar As Button
End Class
