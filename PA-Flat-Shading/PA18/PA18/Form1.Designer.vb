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
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.txtAmbient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiffuse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLS1a = New System.Windows.Forms.TextBox()
        Me.txtLS1b = New System.Windows.Forms.TextBox()
        Me.txtLS1c = New System.Windows.Forms.TextBox()
        Me.CBsetColor = New System.Windows.Forms.ComboBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.RBtranslate = New System.Windows.Forms.RadioButton()
        Me.RBrotate = New System.Windows.Forms.RadioButton()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLS2c = New System.Windows.Forms.TextBox()
        Me.txtLS2b = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLS2a = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB1
        '
        Me.PB1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PB1.Location = New System.Drawing.Point(9, 10)
        Me.PB1.Margin = New System.Windows.Forms.Padding(2)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(403, 421)
        Me.PB1.TabIndex = 0
        Me.PB1.TabStop = False
        '
        'txtAmbient
        '
        Me.txtAmbient.Location = New System.Drawing.Point(498, 32)
        Me.txtAmbient.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmbient.Name = "txtAmbient"
        Me.txtAmbient.Size = New System.Drawing.Size(76, 20)
        Me.txtAmbient.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ambient :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Diffuse :"
        '
        'txtDiffuse
        '
        Me.txtDiffuse.Location = New System.Drawing.Point(498, 63)
        Me.txtDiffuse.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiffuse.Name = "txtDiffuse"
        Me.txtDiffuse.Size = New System.Drawing.Size(76, 20)
        Me.txtDiffuse.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(439, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Light Source 1 :"
        '
        'txtLS1a
        '
        Me.txtLS1a.Location = New System.Drawing.Point(524, 112)
        Me.txtLS1a.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLS1a.Name = "txtLS1a"
        Me.txtLS1a.Size = New System.Drawing.Size(31, 20)
        Me.txtLS1a.TabIndex = 5
        '
        'txtLS1b
        '
        Me.txtLS1b.Location = New System.Drawing.Point(558, 112)
        Me.txtLS1b.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLS1b.Name = "txtLS1b"
        Me.txtLS1b.Size = New System.Drawing.Size(31, 20)
        Me.txtLS1b.TabIndex = 7
        '
        'txtLS1c
        '
        Me.txtLS1c.Location = New System.Drawing.Point(592, 112)
        Me.txtLS1c.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLS1c.Name = "txtLS1c"
        Me.txtLS1c.Size = New System.Drawing.Size(31, 20)
        Me.txtLS1c.TabIndex = 8
        '
        'CBsetColor
        '
        Me.CBsetColor.FormattingEnabled = True
        Me.CBsetColor.Items.AddRange(New Object() {"All", "Red", "Green", "Blue"})
        Me.CBsetColor.Location = New System.Drawing.Point(630, 31)
        Me.CBsetColor.Margin = New System.Windows.Forms.Padding(2)
        Me.CBsetColor.Name = "CBsetColor"
        Me.CBsetColor.Size = New System.Drawing.Size(92, 21)
        Me.CBsetColor.TabIndex = 9
        Me.CBsetColor.Text = "Select Color"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(551, 175)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(2)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(62, 25)
        Me.btnApply.TabIndex = 10
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'RBtranslate
        '
        Me.RBtranslate.AutoSize = True
        Me.RBtranslate.Location = New System.Drawing.Point(502, 217)
        Me.RBtranslate.Margin = New System.Windows.Forms.Padding(2)
        Me.RBtranslate.Name = "RBtranslate"
        Me.RBtranslate.Size = New System.Drawing.Size(69, 17)
        Me.RBtranslate.TabIndex = 11
        Me.RBtranslate.TabStop = True
        Me.RBtranslate.Text = "Translate"
        Me.RBtranslate.UseVisualStyleBackColor = True
        '
        'RBrotate
        '
        Me.RBrotate.AutoSize = True
        Me.RBrotate.Location = New System.Drawing.Point(604, 217)
        Me.RBrotate.Margin = New System.Windows.Forms.Padding(2)
        Me.RBrotate.Name = "RBrotate"
        Me.RBrotate.Size = New System.Drawing.Size(57, 17)
        Me.RBrotate.TabIndex = 12
        Me.RBrotate.TabStop = True
        Me.RBrotate.Text = "Rotate"
        Me.RBrotate.UseVisualStyleBackColor = True
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(524, 367)
        Me.btnDraw.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(89, 41)
        Me.btnDraw.TabIndex = 13
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "W = Y + Axis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(501, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "A = X - Axis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 293)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "S = Y - Axis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(500, 314)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "D = X + Axis"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(590, 272)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Z = Z + Axis"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(590, 251)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "E = Z - Axis"
        '
        'txtLS2c
        '
        Me.txtLS2c.Location = New System.Drawing.Point(592, 136)
        Me.txtLS2c.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLS2c.Name = "txtLS2c"
        Me.txtLS2c.Size = New System.Drawing.Size(31, 20)
        Me.txtLS2c.TabIndex = 23
        '
        'txtLS2b
        '
        Me.txtLS2b.Location = New System.Drawing.Point(558, 136)
        Me.txtLS2b.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLS2b.Name = "txtLS2b"
        Me.txtLS2b.Size = New System.Drawing.Size(31, 20)
        Me.txtLS2b.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(439, 139)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Light Source 2 :"
        '
        'txtLS2a
        '
        Me.txtLS2a.Location = New System.Drawing.Point(524, 136)
        Me.txtLS2a.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLS2a.Name = "txtLS2a"
        Me.txtLS2a.Size = New System.Drawing.Size(31, 20)
        Me.txtLS2a.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(626, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "*Light Source 2 can be left blank"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 452)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLS2c)
        Me.Controls.Add(Me.txtLS2b)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLS2a)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.RBrotate)
        Me.Controls.Add(Me.RBtranslate)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.CBsetColor)
        Me.Controls.Add(Me.txtLS1c)
        Me.Controls.Add(Me.txtLS1b)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLS1a)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiffuse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmbient)
        Me.Controls.Add(Me.PB1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Flat Shading"
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB1 As PictureBox
    Friend WithEvents txtAmbient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiffuse As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLS1a As TextBox
    Friend WithEvents txtLS1b As TextBox
    Friend WithEvents txtLS1c As TextBox
    Friend WithEvents CBsetColor As ComboBox
    Friend WithEvents btnApply As Button
    Friend WithEvents RBtranslate As RadioButton
    Friend WithEvents RBrotate As RadioButton
    Friend WithEvents btnDraw As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLS2c As TextBox
    Friend WithEvents txtLS2b As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLS2a As TextBox
    Friend WithEvents Label11 As Label
End Class
