<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WARNING2GB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WARNING2GB))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DontShowCheckbox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(35, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'DontShowCheckbox
        '
        Me.DontShowCheckbox.AutoSize = True
        Me.DontShowCheckbox.BackColor = System.Drawing.Color.Transparent
        Me.DontShowCheckbox.Location = New System.Drawing.Point(37, 245)
        Me.DontShowCheckbox.Name = "DontShowCheckbox"
        Me.DontShowCheckbox.Size = New System.Drawing.Size(172, 17)
        Me.DontShowCheckbox.TabIndex = 1
        Me.DontShowCheckbox.Text = "Don't show this message again"
        Me.DontShowCheckbox.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(271, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK, I understand"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WARNING2GB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PerfectCompress.My.Resources.Resources.warningWindowImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(502, 276)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DontShowCheckbox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WARNING2GB"
        Me.Text = "WARNING"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DontShowCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
