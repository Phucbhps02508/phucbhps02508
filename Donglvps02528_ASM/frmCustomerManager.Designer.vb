<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerManager
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
        Me.gpbInfo = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'gpbInfo
        '
        Me.gpbInfo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbInfo.Location = New System.Drawing.Point(23, 25)
        Me.gpbInfo.Name = "gpbInfo"
        Me.gpbInfo.Size = New System.Drawing.Size(226, 264)
        Me.gpbInfo.TabIndex = 0
        Me.gpbInfo.TabStop = False
        Me.gpbInfo.Text = "Information"
        '
        'frmCustomerManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 314)
        Me.Controls.Add(Me.gpbInfo)
        Me.Name = "frmCustomerManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Managerment"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbInfo As System.Windows.Forms.GroupBox
End Class
