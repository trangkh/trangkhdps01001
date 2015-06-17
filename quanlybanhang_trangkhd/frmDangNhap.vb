Imports System.Data.SqlClient

Public Class frmdangnhap

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim chuoiketnoi As String = "workstation id=AssignmentFinal1.mssql.somee.com;packet size=4096;user id=trangkhdps01001;pwd=suayenl1994;data source=AssignmentFinal1.mssql.somee.com;persist security info=False;initial catalog=AssignmentFinal1"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNV='" & txtDangNhap.Text & "' and MatKhau='" & txtMatKhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("kết nối với nhân viên thành công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Bạn nhập sai Tài khoản hoặc mật khẩu")
            End If

        Catch ex As Exception
            KetNoi.Close()

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
