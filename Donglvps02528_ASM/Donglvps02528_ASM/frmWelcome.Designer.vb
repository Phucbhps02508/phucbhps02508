<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.components = New System.ComponentModel.Container()
        Me.TimeLoad = New System.Windows.Forms.Timer(Me.components)
        Me.prbLoad = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'TimeLoad
        '
        Me.TimeLoad.Enabled = True
        Me.TimeLoad.Interval = 50
        '
        'prbLoad
        '
        Me.prbLoad.Location = New System.Drawing.Point(-1, 334)
        Me.prbLoad.Name = "prbLoad"
        Me.prbLoad.Size = New System.Drawing.Size(630, 23)
        Me.prbLoad.TabIndex = 0
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Welcome.My.Resources.Resources.cloud_computing_from_any_device
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.prbLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimeLoad As System.Windows.Forms.Timer
    Friend WithEvents prbLoad As System.Windows.Forms.ProgressBar

End Class
