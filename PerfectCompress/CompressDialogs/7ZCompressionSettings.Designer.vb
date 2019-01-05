<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _7ZCompressionSettings
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
        Me.CompressionLevelLabel = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.DictionarySize = New System.Windows.Forms.TextBox()
        Me.WordSize = New System.Windows.Forms.TextBox()
        Me.SolidBlockSize = New System.Windows.Forms.TextBox()
        Me.CompressionLevel = New System.Windows.Forms.ComboBox()
        Me.CompressionMethodLabel = New System.Windows.Forms.Label()
        Me.CompressionMethod = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CompressionLevelLabel
        '
        Me.CompressionLevelLabel.AutoSize = True
        Me.CompressionLevelLabel.Location = New System.Drawing.Point(9, 10)
        Me.CompressionLevelLabel.Name = "CompressionLevelLabel"
        Me.CompressionLevelLabel.Size = New System.Drawing.Size(99, 13)
        Me.CompressionLevelLabel.TabIndex = 8
        Me.CompressionLevelLabel.Text = "Compression Level:"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 153
        Me.LineShape1.X2 = 153
        Me.LineShape1.Y1 = -32
        Me.LineShape1.Y2 = 133
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 382
        Me.LineShape3.X2 = -7
        Me.LineShape3.Y1 = 133
        Me.LineShape3.Y2 = 133
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(367, 195)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Advanced Settings:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Dictionary Size:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Word Size:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Solid Block Size:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "for ""Solid"", write ""on"" instead"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(102, 170)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(253, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "7z powered by 7-Zip Copyright (C) 2010 Igor Pavlov."
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Location = New System.Drawing.Point(15, 144)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(340, 23)
        Me.CloseBtn.TabIndex = 37
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'DictionarySize
        '
        Me.DictionarySize.BackColor = System.Drawing.Color.White
        Me.DictionarySize.Location = New System.Drawing.Point(251, 27)
        Me.DictionarySize.Name = "DictionarySize"
        Me.DictionarySize.Size = New System.Drawing.Size(94, 20)
        Me.DictionarySize.TabIndex = 38
        '
        'WordSize
        '
        Me.WordSize.BackColor = System.Drawing.Color.White
        Me.WordSize.Location = New System.Drawing.Point(251, 53)
        Me.WordSize.Name = "WordSize"
        Me.WordSize.Size = New System.Drawing.Size(94, 20)
        Me.WordSize.TabIndex = 1
        '
        'SolidBlockSize
        '
        Me.SolidBlockSize.BackColor = System.Drawing.Color.White
        Me.SolidBlockSize.Location = New System.Drawing.Point(251, 79)
        Me.SolidBlockSize.Name = "SolidBlockSize"
        Me.SolidBlockSize.Size = New System.Drawing.Size(94, 20)
        Me.SolidBlockSize.TabIndex = 1
        '
        'CompressionLevel
        '
        Me.CompressionLevel.FormattingEnabled = True
        Me.CompressionLevel.Items.AddRange(New Object() {"Store", "Fastest", "Fast", "Normal", "Maximum", "Ultra"})
        Me.CompressionLevel.Location = New System.Drawing.Point(12, 26)
        Me.CompressionLevel.Name = "CompressionLevel"
        Me.CompressionLevel.Size = New System.Drawing.Size(121, 21)
        Me.CompressionLevel.TabIndex = 40
        '
        'CompressionMethodLabel
        '
        Me.CompressionMethodLabel.AutoSize = True
        Me.CompressionMethodLabel.Location = New System.Drawing.Point(9, 55)
        Me.CompressionMethodLabel.Name = "CompressionMethodLabel"
        Me.CompressionMethodLabel.Size = New System.Drawing.Size(109, 13)
        Me.CompressionMethodLabel.TabIndex = 41
        Me.CompressionMethodLabel.Text = "Compression Method:"
        '
        'CompressionMethod
        '
        Me.CompressionMethod.FormattingEnabled = True
        Me.CompressionMethod.Items.AddRange(New Object() {"LZMA", "LZMA2", "PPMd", "BZip2"})
        Me.CompressionMethod.Location = New System.Drawing.Point(12, 71)
        Me.CompressionMethod.Name = "CompressionMethod"
        Me.CompressionMethod.Size = New System.Drawing.Size(121, 21)
        Me.CompressionMethod.TabIndex = 42
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(251, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 20)
        Me.TextBox1.TabIndex = 38
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(251, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(94, 20)
        Me.TextBox2.TabIndex = 1
        '
        '_7ZCompressionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 195)
        Me.Controls.Add(Me.CompressionMethod)
        Me.Controls.Add(Me.CompressionMethodLabel)
        Me.Controls.Add(Me.CompressionLevel)
        Me.Controls.Add(Me.WordSize)
        Me.Controls.Add(Me.SolidBlockSize)
        Me.Controls.Add(Me.DictionarySize)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CompressionLevelLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_7ZCompressionSettings"
        Me.Text = "7Z Compression Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompressionLevelLabel As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SolidBlockSize As System.Windows.Forms.TextBox
    Friend WithEvents CompressionLevel As ComboBox
    Friend WithEvents CompressionMethodLabel As Label
    Friend WithEvents CompressionMethod As ComboBox
    Friend WithEvents DictionarySize As TextBox
    Friend WithEvents WordSize As TextBox
End Class
