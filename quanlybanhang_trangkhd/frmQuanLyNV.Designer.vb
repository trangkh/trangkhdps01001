<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNV
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
        Me.txtMatKhauNV = New System.Windows.Forms.TextBox()
        Me.txtTenDangNhapNV = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.lblHangsx = New System.Windows.Forms.Label()
        Me.lblTensp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSDTNV = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhsachNV = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDanhsachNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMatKhauNV
        '
        Me.txtMatKhauNV.Location = New System.Drawing.Point(177, 98)
        Me.txtMatKhauNV.Name = "txtMatKhauNV"
        Me.txtMatKhauNV.Size = New System.Drawing.Size(199, 20)
        Me.txtMatKhauNV.TabIndex = 22
        '
        'txtTenDangNhapNV
        '
        Me.txtTenDangNhapNV.Location = New System.Drawing.Point(177, 64)
        Me.txtTenDangNhapNV.Name = "txtTenDangNhapNV"
        Me.txtTenDangNhapNV.Size = New System.Drawing.Size(199, 20)
        Me.txtTenDangNhapNV.TabIndex = 20
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(177, 30)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(199, 20)
        Me.txtMaNV.TabIndex = 19
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(70, 33)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(82, 13)
        Me.lblmasp.TabIndex = 23
        Me.lblmasp.Text = "Mã nhân viên: *"
        '
        'lblHangsx
        '
        Me.lblHangsx.AutoSize = True
        Me.lblHangsx.Location = New System.Drawing.Point(70, 105)
        Me.lblHangsx.Name = "lblHangsx"
        Me.lblHangsx.Size = New System.Drawing.Size(62, 13)
        Me.lblHangsx.TabIndex = 21
        Me.lblHangsx.Text = "Mật khẩu: *"
        '
        'lblTensp
        '
        Me.lblTensp.AutoSize = True
        Me.lblTensp.Location = New System.Drawing.Point(70, 67)
        Me.lblTensp.Name = "lblTensp"
        Me.lblTensp.Size = New System.Drawing.Size(91, 13)
        Me.lblTensp.TabIndex = 18
        Me.lblTensp.Text = "Tên đăng nhập: *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Số điện thoại NV: *"
        '
        'txtSDTNV
        '
        Me.txtSDTNV.Location = New System.Drawing.Point(177, 138)
        Me.txtSDTNV.Name = "txtSDTNV"
        Me.txtSDTNV.Size = New System.Drawing.Size(199, 20)
        Me.txtSDTNV.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDanhsachNV)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 211)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách nhân viên"
        '
        'dgvDanhsachNV
        '
        Me.dgvDanhsachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhsachNV.Location = New System.Drawing.Point(9, 18)
        Me.dgvDanhsachNV.Name = "dgvDanhsachNV"
        Me.dgvDanhsachNV.Size = New System.Drawing.Size(427, 175)
        Me.dgvDanhsachNV.TabIndex = 26
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(234, 177)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 30)
        Me.btnXoa.TabIndex = 30
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(153, 177)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 30)
        Me.btnSua.TabIndex = 29
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(315, 177)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 28
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(72, 177)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 27
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmQuanLyNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 446)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSDTNV)
        Me.Controls.Add(Me.txtMatKhauNV)
        Me.Controls.Add(Me.txtTenDangNhapNV)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmasp)
        Me.Controls.Add(Me.lblHangsx)
        Me.Controls.Add(Me.lblTensp)
        Me.Name = "frmQuanLyNV"
        Me.Text = "Quản lý nhân viên"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDanhsachNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMatKhauNV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenDangNhapNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents lblHangsx As System.Windows.Forms.Label
    Friend WithEvents lblTensp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSDTNV As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhsachNV As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
End Class
