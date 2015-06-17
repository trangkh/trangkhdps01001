Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmThemSP
    Dim database As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmentFinal1.mssql.somee.com;packet size=4096;user id=trangkhdps01001;pwd=suayenl1994;data source=AssignmentFinal1.mssql.somee.com;persist security info=False;initial catalog=AssignmentFinal1"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmThemSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", connect)
        connect.Open()
        load.Fill(database)
        dgvDanhsachSP.DataSource = database.DefaultView
    End Sub

    Private Sub dgvDanhsachSP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhsachSP.CellClick
        Dim index As Integer = dgvDanhsachSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvDanhsachSP.Item(0, index).Value
        txtTenSP.Text = dgvDanhsachSP.Item(1, index).Value
        txtHangSX.Text = dgvDanhsachSP.Item(2, index).Value
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim them As String = "insert into NhanVien values (@MaSP,@TenSP,@HangSX)"
        Dim Executethem As New SqlCommand(them, connect)
        Try
            Executethem.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            Executethem.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            Executethem.Parameters.AddWithValue("@HangSX", txtHangSX.Text)
            Executethem.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Đã thêm")
        Catch ex As Exception
            MessageBox.Show("Trùng mã không thêm được")
        End Try
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachSP.DataSource = database.DefaultView
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim sua As String = "update SanPham set TenSP=@TenSP,HangSX=@HangSX where MaSP=@MaSP"
        Dim Executesua As New SqlCommand(sua, connect)
        Try
            Executesua.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            Executesua.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            Executesua.Parameters.AddWithValue("@HangSX", txtHangSX.Text)
            Executesua.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Đã Sửa Dữ Liệu")
        Catch ex As Exception
            MessageBox.Show("sửa không được")
        End Try

        ' load lại dư liệu vô dataGridview
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachSP.DataSource = database.DefaultView
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xoa As String = "delete from SanPham where MaSP = @MaSP"
        Dim Executexoa As New SqlCommand(xoa, connect)
        Try
            Executexoa.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            Executexoa.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MessageBox.Show("Xóa thành công")
        End Try
        ' load lại dư liệu vô dataGridview
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachSP.DataSource = database.DefaultView
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class