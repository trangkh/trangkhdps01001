Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLyNV
    Dim database As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmentFinal1.mssql.somee.com;packet size=4096;user id=trangkhdps01001;pwd=suayenl1994;data source=AssignmentFinal1.mssql.somee.com;persist security info=False;initial catalog=AssignmentFinal1"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub frmQuanLyNV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        connect.Open()
        load.Fill(database)
        dgvDanhsachNV.DataSource = database.DefaultView
    End Sub

    Private Sub dgvDanhsachNV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhsachNV.CellClick
        Dim index As Integer = dgvDanhsachNV.CurrentCell.RowIndex
        txtMaNV.Text = dgvDanhsachNV.Item(0, index).Value
        txtTenDangNhapNV.Text = dgvDanhsachNV.Item(1, index).Value
        txtMatKhauNV.Text = dgvDanhsachNV.Item(2, index).Value
        txtSDTNV.Text = dgvDanhsachNV.Item(3, index).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim them As String = "insert into NhanVien values (@MaNV,@TenDangNhap,@MatKhau,@SoDienThoai)"
        Dim Executethem As New SqlCommand(them, connect)
        Try
            Executethem.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            Executethem.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhapNV.Text)
            Executethem.Parameters.AddWithValue("@MatKhau", txtMatKhauNV.Text)
            Executethem.Parameters.AddWithValue("@SoDienThoai", txtSDTNV.Text)
            Executethem.ExecuteNonQuery()
            connect.Close()

            MessageBox.Show("Đã thêm")

        Catch ex As Exception
            MessageBox.Show("Trùng mã không thêm được")
        End Try
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachNV.DataSource = database.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim sua As String = "update NhanVien set TenDangNhap=@TenDangNhap,MatKhau=@MatKhau, SoDienThoai=@SoDienThoai where MaNV=@MaNV"
        Dim Executesua As New SqlCommand(sua, connect)
        Try
            Executesua.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            Executesua.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhapNV.Text)
            Executesua.Parameters.AddWithValue("@MatKhau", txtMatKhauNV.Text)
            Executesua.Parameters.AddWithValue("@SoDienThoai", txtSDTNV.Text)
            Executesua.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Đã Sửa Dữ Liệu")
        Catch ex As Exception
            MessageBox.Show("sửa không được")
        End Try

        ' load lại dư liệu vô dataGridview
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachNV.DataSource = database.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xoa As String = "delete from NhanVien where MaNV = @MaNV"
        Dim Executexoa As New SqlCommand(xoa, connect)
        Try
            Executexoa.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
            Executexoa.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MessageBox.Show("Xóa thành công")
        End Try
        ' load lại dư liệu vô dataGridview
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachNV.DataSource = database.DefaultView
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub dgvDanhsachNV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhsachNV.CellContentClick

    End Sub
End Class