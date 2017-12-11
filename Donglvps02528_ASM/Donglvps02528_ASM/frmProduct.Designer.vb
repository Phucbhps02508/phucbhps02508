<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.grbPro = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtOOID = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtExDate = New System.Windows.Forms.TextBox()
        Me.txtProDate = New System.Windows.Forms.TextBox()
        Me.txtProCID = New System.Windows.Forms.TextBox()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvInfor = New System.Windows.Forms.DataGridView()
        Me.grbPro.SuspendLayout()
        CType(Me.dgvInfor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbPro
        '
        Me.grbPro.Controls.Add(Me.btnClear)
        Me.grbPro.Controls.Add(Me.btnDel)
        Me.grbPro.Controls.Add(Me.btnEdit)
        Me.grbPro.Controls.Add(Me.btnAdd)
        Me.grbPro.Controls.Add(Me.btnFind)
        Me.grbPro.Controls.Add(Me.txtOOID)
        Me.grbPro.Controls.Add(Me.txtQuantity)
        Me.grbPro.Controls.Add(Me.txtExDate)
        Me.grbPro.Controls.Add(Me.txtProDate)
        Me.grbPro.Controls.Add(Me.txtProCID)
        Me.grbPro.Controls.Add(Me.txtProID)
        Me.grbPro.Controls.Add(Me.Label6)
        Me.grbPro.Controls.Add(Me.Label5)
        Me.grbPro.Controls.Add(Me.Label4)
        Me.grbPro.Controls.Add(Me.Label3)
        Me.grbPro.Controls.Add(Me.Label2)
        Me.grbPro.Controls.Add(Me.Label1)
        Me.grbPro.Location = New System.Drawing.Point(12, 12)
        Me.grbPro.Name = "grbPro"
        Me.grbPro.Size = New System.Drawing.Size(314, 432)
        Me.grbPro.TabIndex = 0
        Me.grbPro.TabStop = False
        Me.grbPro.Text = "Products"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(10, 392)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(298, 32)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(10, 354)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(298, 32)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(10, 316)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(298, 32)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 278)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(298, 32)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(10, 240)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(298, 32)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtOOID
        '
        Me.txtOOID.Location = New System.Drawing.Point(142, 204)
        Me.txtOOID.Name = "txtOOID"
        Me.txtOOID.Size = New System.Drawing.Size(166, 26)
        Me.txtOOID.TabIndex = 6
        Me.txtOOID.Tag = "Giá trị phải giống giá trị Order ID thuộc bảng Order"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(142, 169)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(166, 26)
        Me.txtQuantity.TabIndex = 5
        '
        'txtExDate
        '
        Me.txtExDate.Location = New System.Drawing.Point(142, 134)
        Me.txtExDate.Name = "txtExDate"
        Me.txtExDate.Size = New System.Drawing.Size(166, 26)
        Me.txtExDate.TabIndex = 4
        '
        'txtProDate
        '
        Me.txtProDate.Location = New System.Drawing.Point(142, 99)
        Me.txtProDate.Name = "txtProDate"
        Me.txtProDate.Size = New System.Drawing.Size(166, 26)
        Me.txtProDate.TabIndex = 3
        '
        'txtProCID
        '
        Me.txtProCID.Location = New System.Drawing.Point(142, 64)
        Me.txtProCID.Name = "txtProCID"
        Me.txtProCID.Size = New System.Drawing.Size(166, 26)
        Me.txtProCID.TabIndex = 2
        '
        'txtProID
        '
        Me.txtProID.Location = New System.Drawing.Point(142, 29)
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(166, 26)
        Me.txtProID.TabIndex = 1
        Me.txtProID.Tag = "Giá trị phải giống giá trị Product ID thuộc bảng Orders"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Orders Oder ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Product Quantity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Expire Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pro Cate ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product ID :"
        '
        'dgvInfor
        '
        Me.dgvInfor.AllowUserToAddRows = False
        Me.dgvInfor.AllowUserToDeleteRows = False
        Me.dgvInfor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfor.Location = New System.Drawing.Point(341, 20)
        Me.dgvInfor.Name = "dgvInfor"
        Me.dgvInfor.ReadOnly = True
        Me.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInfor.Size = New System.Drawing.Size(540, 423)
        Me.dgvInfor.TabIndex = 15
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 455)
        Me.Controls.Add(Me.dgvInfor)
        Me.Controls.Add(Me.grbPro)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.grbPro.ResumeLayout(False)
        Me.grbPro.PerformLayout()
        CType(Me.dgvInfor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbPro As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOOID As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtExDate As System.Windows.Forms.TextBox
    Friend WithEvents txtProDate As System.Windows.Forms.TextBox
    Friend WithEvents txtProCID As System.Windows.Forms.TextBox
    Friend WithEvents txtProID As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents dgvInfor As System.Windows.Forms.DataGridView
End Class
