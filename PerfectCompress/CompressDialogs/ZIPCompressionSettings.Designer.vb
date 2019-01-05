<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZIPCompressionSettings
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DictionarySize = New System.Windows.Forms.TextBox()
        Me.WordSize = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CompressionLevel = New System.Windows.Forms.ComboBox()
        Me.CompressionMethod = New System.Windows.Forms.ComboBox()
        Me.CompressionMethodLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CompressionLevelLabel
        '
        Me.CompressionLevelLabel.AutoSize = True
        Me.CompressionLevelLabel.Location = New System.Drawing.Point(12, 9)
        Me.CompressionLevelLabel.Name = "CompressionLevelLabel"
        Me.CompressionLevelLabel.Size = New System.Drawing.Size(99, 13)
        Me.CompressionLevelLabel.TabIndex = 0
        Me.CompressionLevelLabel.Text = "Compression Level:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(356, 162)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 360
        Me.LineShape3.X2 = -5
        Me.LineShape3.Y1 = 94
        Me.LineShape3.Y2 = 94
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 157
        Me.LineShape1.X2 = 157
        Me.LineShape1.Y1 = -9
        Me.LineShape1.Y2 = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Advanced Settings:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Dictionary Size:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Word Size:"
        '
        'DictionarySize
        '
        Me.DictionarySize.Location = New System.Drawing.Point(241, 31)
        Me.DictionarySize.Name = "DictionarySize"
        Me.DictionarySize.Size = New System.Drawing.Size(100, 20)
        Me.DictionarySize.TabIndex = 18
        '
        'WordSize
        '
        Me.WordSize.Location = New System.Drawing.Point(241, 65)
        Me.WordSize.Name = "WordSize"
        Me.WordSize.Size = New System.Drawing.Size(100, 20)
        Me.WordSize.TabIndex = 19
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 138)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(259, 13)
        Me.LinkLabel1.TabIndex = 32
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ZIP powered by 7-Zip Copyright (C) 2010 Igor Pavlov."
        '
        'CompressionLevel
        '
        Me.CompressionLevel.FormattingEnabled = True
        Me.CompressionLevel.Items.AddRange(New Object() {"Store", "Fastest", "Fast", "Normal", "Maximum", "Ultra"})
        Me.CompressionLevel.Location = New System.Drawing.Point(15, 25)
        Me.CompressionLevel.Name = "CompressionLevel"
        Me.CompressionLevel.Size = New System.Drawing.Size(121, 21)
        Me.CompressionLevel.TabIndex = 34
        '
        'CompressionMethod
        '
        Me.CompressionMethod.FormattingEnabled = True
        Me.CompressionMethod.Items.AddRange(New Object() {"Deflate", "Deflate64", "BZip2", "LZMA", "PPMd"})
        Me.CompressionMethod.Location = New System.Drawing.Point(15, 65)
        Me.CompressionMethod.Name = "CompressionMethod"
        Me.CompressionMethod.Size = New System.Drawing.Size(121, 21)
        Me.CompressionMethod.TabIndex = 36
        '
        'CompressionMethodLabel
        '
        Me.CompressionMethodLabel.AutoSize = True
        Me.CompressionMethodLabel.Location = New System.Drawing.Point(12, 49)
        Me.CompressionMethodLabel.Name = "CompressionMethodLabel"
        Me.CompressionMethodLabel.Size = New System.Drawing.Size(109, 13)
        Me.CompressionMethodLabel.TabIndex = 35
        Me.CompressionMethodLabel.Text = "Compression Method:"
        '
        'ZIPCompressionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 162)
        Me.Controls.Add(Me.CompressionMethod)
        Me.Controls.Add(Me.CompressionMethodLabel)
        Me.Controls.Add(Me.CompressionLevel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.WordSize)
        Me.Controls.Add(Me.DictionarySize)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CompressionLevelLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ZIPCompressionSettings"
        Me.Text = "ZIP Compression Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompressionLevelLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DictionarySize As System.Windows.Forms.TextBox
    Friend WithEvents WordSize As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents CompressionLevel As ComboBox
    Friend WithEvents CompressionMethod As ComboBox
    Friend WithEvents CompressionMethodLabel As Label
End Class
