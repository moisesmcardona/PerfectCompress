<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArcCompressionSettings
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArcLevel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SFXModule = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Compression Level:"
        '
        'ArcLevel
        '
        Me.ArcLevel.FormattingEnabled = True
        Me.ArcLevel.Items.AddRange(New Object() {"m0", "m1", "m1x", "m2", "m2x", "m3", "m3x", "m4", "m4x", "m5", "m5x", "m6", "m6x", "m7", "m7x", "m8", "m8x", "m9", "m9x", "mx"})
        Me.ArcLevel.Location = New System.Drawing.Point(15, 25)
        Me.ArcLevel.Name = "ArcLevel"
        Me.ArcLevel.Size = New System.Drawing.Size(160, 21)
        Me.ArcLevel.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "SFX Module:"
        '
        'SFXModule
        '
        Me.SFXModule.FormattingEnabled = True
        Me.SFXModule.Items.AddRange(New Object() {"arc-mini.sfx", "arc-tiny.sfx", "arc.sfx", "freearc-installer-nodelete.sfx", "freearc-installer.sfx", "freearc-mini.sfx", "freearc-tiny.sfx", "freearc.sfx"})
        Me.SFXModule.Location = New System.Drawing.Point(15, 66)
        Me.SFXModule.Name = "SFXModule"
        Me.SFXModule.Size = New System.Drawing.Size(160, 21)
        Me.SFXModule.Sorted = True
        Me.SFXModule.TabIndex = 27
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"freearc.sfc", "arc.sfx", "arc-mini.sfx", "arc-tiny.sfx", "arc.linux.sfx", "arc-mini.linux.sfx", "arc-tiny.linux.sfx", "freearc-installer.sfx", "freearc-installer-nodelete.sfx", "freearc-mini.sfx", "freearc-tiny.sfx"})
        Me.ComboBox2.Location = New System.Drawing.Point(15, 66)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox2.TabIndex = 27
        '
        'ArcCompressionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 132)
        Me.Controls.Add(Me.SFXModule)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ArcLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ArcCompressionSettings"
        Me.Text = "Arc Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ArcLevel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents SFXModule As ComboBox
End Class
