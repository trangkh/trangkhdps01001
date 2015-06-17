<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ThêmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSảnPhẩmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.ThêmSảnPhẩmToolStripMenuItem, Me.ThôngTinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngNhậpToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'ĐăngNhậpToolStripMenuItem
        '
        Me.ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem"
        Me.ĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngNhậpToolStripMenuItem.Text = "Đăng Nhập"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýNhânViênToolStripMenuItem, Me.QuảnLýKháchHàngToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'QuảnLýNhânViênToolStripMenuItem
        '
        Me.QuảnLýNhânViênToolStripMenuItem.Name = "QuảnLýNhânViênToolStripMenuItem"
        Me.QuảnLýNhânViênToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên"
        '
        'QuảnLýKháchHàngToolStripMenuItem
        '
        Me.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem"
        Me.QuảnLýKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PHẦN MỀM QUẢN LÝ SẢN PHẨM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.quanlybanhang_trangkhd.My.Resources.Resources.s
        Me.PictureBox1.Location = New System.Drawing.Point(99, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ThêmSảnPhẩmToolStripMenuItem
        '
        Me.ThêmSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSảnPhẩmToolStripMenuItem1})
        Me.ThêmSảnPhẩmToolStripMenuItem.Name = "ThêmSảnPhẩmToolStripMenuItem"
        Me.ThêmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.ThêmSảnPhẩmToolStripMenuItem.Text = "Thêm sản phẩm"
        '
        'ThêmSảnPhẩmToolStripMenuItem1
        '
        Me.ThêmSảnPhẩmToolStripMenuItem1.Name = "ThêmSảnPhẩmToolStripMenuItem1"
        Me.ThêmSảnPhẩmToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ThêmSảnPhẩmToolStripMenuItem1.Text = "Thêm sản phẩm"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ThôngTinToolStripMenuItem.Text = "Thông tin"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(608, 363)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngNhậpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
