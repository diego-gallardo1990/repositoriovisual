<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonTEXTO = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonIMAGEN = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxREDUCIR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonTEXTO
        '
        Me.ButtonTEXTO.BackColor = System.Drawing.Color.DimGray
        Me.ButtonTEXTO.ForeColor = System.Drawing.Color.White
        Me.ButtonTEXTO.Location = New System.Drawing.Point(115, 217)
        Me.ButtonTEXTO.Name = "ButtonTEXTO"
        Me.ButtonTEXTO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonTEXTO.TabIndex = 0
        Me.ButtonTEXTO.Text = "TEXTO A PDF"
        Me.ButtonTEXTO.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(338, 181)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ButtonIMAGEN
        '
        Me.ButtonIMAGEN.BackColor = System.Drawing.Color.DimGray
        Me.ButtonIMAGEN.ForeColor = System.Drawing.Color.White
        Me.ButtonIMAGEN.Location = New System.Drawing.Point(246, 218)
        Me.ButtonIMAGEN.Name = "ButtonIMAGEN"
        Me.ButtonIMAGEN.Size = New System.Drawing.Size(140, 40)
        Me.ButtonIMAGEN.TabIndex = 3
        Me.ButtonIMAGEN.Text = "IMAGEN A PDF"
        Me.ButtonIMAGEN.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBoxREDUCIR
        '
        Me.TextBoxREDUCIR.ForeColor = System.Drawing.Color.Green
        Me.TextBoxREDUCIR.Location = New System.Drawing.Point(157, 227)
        Me.TextBoxREDUCIR.Name = "TextBoxREDUCIR"
        Me.TextBoxREDUCIR.Size = New System.Drawing.Size(47, 22)
        Me.TextBoxREDUCIR.TabIndex = 4
        Me.TextBoxREDUCIR.Text = "100"
        Me.TextBoxREDUCIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "REDUCIR AL %:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(54, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Unir PDF"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(269, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 46)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Explorar Archivo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(28, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(235, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Selecciona archivo a dividir"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(416, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 41)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Dividir PDF"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonTEXTO)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 276)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convertir Texto a PDF"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBoxREDUCIR)
        Me.GroupBox2.Controls.Add(Me.ButtonIMAGEN)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 276)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convertir Imagen a PDF"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(270, 316)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 103)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dividir PDF"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 316)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(228, 103)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Unir PDF"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 444)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONVERTIR A PDF"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonTEXTO As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonIMAGEN As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBoxREDUCIR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
