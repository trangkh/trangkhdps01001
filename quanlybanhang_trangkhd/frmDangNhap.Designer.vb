<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtDangNhap = New System.Windows.Forms.TextBox()
        Me.lblDangNhap = New System.Windows.Forms.Label()
        Me.GrbThongTinDangNhap = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.GrbThongTinDangNhap.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(157, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Đăng Nhập"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(255, 90)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(182, 21)
        Me.txtMatKhau.TabIndex = 2
        '
        'txtDangNhap
        '
        Me.txtDangNhap.Location = New System.Drawing.Point(255, 51)
        Me.txtDangNhap.Name = "txtDangNhap"
        Me.txtDangNhap.Size = New System.Drawing.Size(182, 21)
        Me.txtDangNhap.TabIndex = 1
        '
        'lblDangNhap
        '
        Me.lblDangNhap.AutoSize = True
        Me.lblDangNhap.Location = New System.Drawing.Point(154, 58)
        Me.lblDangNhap.Name = "lblDangNhap"
        Me.lblDangNhap.Size = New System.Drawing.Size(90, 15)
        Me.lblDangNhap.TabIndex = 0
        Me.lblDangNhap.Text = "Tên đăng nhập"
        '
        'GrbThongTinDangNhap
        '
        Me.GrbThongTinDangNhap.Controls.Add(Me.PictureBox1)
        Me.GrbThongTinDangNhap.Controls.Add(Me.btnThoat)
        Me.GrbThongTinDangNhap.Controls.Add(Me.btnDangNhap)
        Me.GrbThongTinDangNhap.Controls.Add(Me.txtMatKhau)
        Me.GrbThongTinDangNhap.Controls.Add(Me.txtDangNhap)
        Me.GrbThongTinDangNhap.Controls.Add(Me.lblMatKhau)
        Me.GrbThongTinDangNhap.Controls.Add(Me.lblDangNhap)
        Me.GrbThongTinDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbThongTinDangNhap.Location = New System.Drawing.Point(5, 40)
        Me.GrbThongTinDangNhap.Name = "GrbThongTinDangNhap"
        Me.GrbThongTinDangNhap.Size = New System.Drawing.Size(451, 168)
        Me.GrbThongTinDangNhap.TabIndex = 5
        Me.GrbThongTinDangNhap.TabStop = False
        Me.GrbThongTinDangNhap.Text = "Thông tin đăng nhập"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.quanlybanhang_trangkhd.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(17, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnThoat
        '
        Me.btnThoat.Image = Global.quanlybanhang_trangkhd.My.Resources.Resources.Delete
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(364, 117)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(72, 30)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Image = Global.quanlybanhang_trangkhd.My.Resources.Resources.Add
        Me.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDangNhap.Location = New System.Drawing.Point(255, 117)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(103, 30)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Location = New System.Drawing.Point(154, 97)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(58, 15)
        Me.lblMatKhau.TabIndex = 0
        Me.lblMatKhau.Text = "Mật khẩu"
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 220)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrbThongTinDangNhap)
        Me.Name = "frmdangnhap"
        Me.Text = "Đăng nhập"
        Me.GrbThongTinDangNhap.ResumeLayout(False)
        Me.GrbThongTinDangNhap.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents lblDangNhap As System.Windows.Forms.Label
    Friend WithEvents GrbThongTinDangNhap As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label

End Class
