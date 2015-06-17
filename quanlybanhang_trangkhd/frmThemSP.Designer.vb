<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemSP
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
        Me.txtHangSX = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.lblHangsx = New System.Windows.Forms.Label()
        Me.lblTensp = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhsachSP = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDanhsachSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHangSX
        '
        Me.txtHangSX.Location = New System.Drawing.Point(131, 89)
        Me.txtHangSX.Name = "txtHangSX"
        Me.txtHangSX.Size = New System.Drawing.Size(231, 20)
        Me.txtHangSX.TabIndex = 15
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(131, 55)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(231, 20)
        Me.txtTenSP.TabIndex = 13
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(131, 21)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(231, 20)
        Me.txtMaSP.TabIndex = 12
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(24, 24)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(81, 13)
        Me.lblmasp.TabIndex = 17
        Me.lblmasp.Text = "Mã sản phẩm: *"
        '
        'lblHangsx
        '
        Me.lblHangsx.AutoSize = True
        Me.lblHangsx.Location = New System.Drawing.Point(24, 92)
        Me.lblHangsx.Name = "lblHangsx"
        Me.lblHangsx.Size = New System.Drawing.Size(86, 13)
        Me.lblHangsx.TabIndex = 14
        Me.lblHangsx.Text = "Hãng sản xuất: *"
        '
        'lblTensp
        '
        Me.lblTensp.AutoSize = True
        Me.lblTensp.Location = New System.Drawing.Point(24, 58)
        Me.lblTensp.Name = "lblTensp"
        Me.lblTensp.Size = New System.Drawing.Size(85, 13)
        Me.lblTensp.TabIndex = 11
        Me.lblTensp.Text = "Tên sản phẩm: *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDanhsachSP)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 239)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách sản phẩm:"
        '
        'dgvDanhsachSP
        '
        Me.dgvDanhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhsachSP.Location = New System.Drawing.Point(14, 38)
        Me.dgvDanhsachSP.Name = "dgvDanhsachSP"
        Me.dgvDanhsachSP.Size = New System.Drawing.Size(328, 189)
        Me.dgvDanhsachSP.TabIndex = 19
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(206, 125)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(125, 125)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(287, 125)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Thoát"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(44, 125)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Thêm"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmThemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 428)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtHangSX)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblmasp)
        Me.Controls.Add(Me.lblHangsx)
        Me.Controls.Add(Me.lblTensp)
        Me.Name = "frmThemSP"
        Me.Text = "Thêm sản phẩm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDanhsachSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHangSX As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents lblHangsx As System.Windows.Forms.Label
    Friend WithEvents lblTensp As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhsachSP As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
