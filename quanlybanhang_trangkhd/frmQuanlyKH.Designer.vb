<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanlyKH
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
        Me.txtSDTKH = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.lblHangsx = New System.Windows.Forms.Label()
        Me.lblTensp = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhsachKH = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDanhsachKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSDTKH
        '
        Me.txtSDTKH.Location = New System.Drawing.Point(157, 93)
        Me.txtSDTKH.Name = "txtSDTKH"
        Me.txtSDTKH.Size = New System.Drawing.Size(199, 20)
        Me.txtSDTKH.TabIndex = 23
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(157, 59)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(199, 20)
        Me.txtTenKH.TabIndex = 21
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(157, 25)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(199, 20)
        Me.txtMaKH.TabIndex = 20
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(50, 28)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(50, 13)
        Me.lblmasp.TabIndex = 25
        Me.lblmasp.Text = "Mã KH: *"
        '
        'lblHangsx
        '
        Me.lblHangsx.AutoSize = True
        Me.lblHangsx.Location = New System.Drawing.Point(50, 96)
        Me.lblHangsx.Name = "lblHangsx"
        Me.lblHangsx.Size = New System.Drawing.Size(83, 13)
        Me.lblHangsx.TabIndex = 22
        Me.lblHangsx.Text = "Số điện thoại : *"
        '
        'lblTensp
        '
        Me.lblTensp.AutoSize = True
        Me.lblTensp.Location = New System.Drawing.Point(50, 62)
        Me.lblTensp.Name = "lblTensp"
        Me.lblTensp.Size = New System.Drawing.Size(54, 13)
        Me.lblTensp.TabIndex = 19
        Me.lblTensp.Text = "Tên KH: *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDanhsachKH)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 233)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách khách hàng"
        '
        'dgvDanhsachKH
        '
        Me.dgvDanhsachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhsachKH.Location = New System.Drawing.Point(6, 30)
        Me.dgvDanhsachKH.Name = "dgvDanhsachKH"
        Me.dgvDanhsachKH.Size = New System.Drawing.Size(331, 189)
        Me.dgvDanhsachKH.TabIndex = 27
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(215, 132)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 30)
        Me.btnXoa.TabIndex = 31
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(134, 132)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 30)
        Me.btnSua.TabIndex = 30
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(296, 132)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 30)
        Me.btnThoat.TabIndex = 29
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(53, 132)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 30)
        Me.btnThem.TabIndex = 28
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmQuanlyKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 423)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSDTKH)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblmasp)
        Me.Controls.Add(Me.lblHangsx)
        Me.Controls.Add(Me.lblTensp)
        Me.Name = "frmQuanlyKH"
        Me.Text = "QuanlyKH"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDanhsachKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSDTKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents lblHangsx As System.Windows.Forms.Label
    Friend WithEvents lblTensp As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhsachKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
End Class
