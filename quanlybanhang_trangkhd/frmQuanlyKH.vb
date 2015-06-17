Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanlyKH
    Dim database As New DataTable
    Dim chuoiketnoi As String = "workstation id=AssignmentFinal1.mssql.somee.com;packet size=4096;user id=trangkhdps01001;pwd=suayenl1994;data source=AssignmentFinal1.mssql.somee.com;persist security info=False;initial catalog=AssignmentFinal1"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim them As String = "insert into KhachHang values (@MaKH,@TenKH,@SDTKH)"
        Dim Executethem As New SqlCommand(them, connect)
        Try
            Executethem.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Executethem.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            Executethem.Parameters.AddWithValue("@SDTKH", txtSDTKH.Text)
            Executethem.ExecuteNonQuery()
            connect.Close()

            MessageBox.Show("Đã thêm")

        Catch ex As Exception
            MessageBox.Show("Trùng mã không thêm được")
        End Try
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachKH.DataSource = database.DefaultView
    End Sub

    Private Sub frmQuanlyKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        connect.Open()
        load.Fill(database)
        dgvDanhsachKH.DataSource = database.DefaultView

    End Sub

    Private Sub dgvDanhsachSP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhsachKH.CellClick
        Dim index As Integer = dgvDanhsachKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvDanhsachKH.Item(0, index).Value
        txtTenKH.Text = dgvDanhsachKH.Item(1, index).Value
        txtSDTKH.Text = dgvDanhsachKH.Item(2, index).Value
   
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim sua As String = "update KhachHang set TenKH=@TenKH,SoDT=@SoDT where MaKH=@MaKH"
        Dim Executesua As New SqlCommand(sua, connect)
        Try
            Executesua.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Executesua.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            Executesua.Parameters.AddWithValue("@SoDT", txtSDTKH.Text)
            Executesua.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Đã Sửa Dữ Liệu")
        Catch ex As Exception
            MessageBox.Show("sửa không được")
        End Try

        ' load lại dư liệu vô dataGridview
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachKH.DataSource = database.DefaultView
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xoa As String = "delete from KhachHang where MaKH = @MaKH"
        Dim Executexoa As New SqlCommand(xoa, connect)
        Try
            Executexoa.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Executexoa.ExecuteNonQuery()
            connect.Close()

            MessageBox.Show("ĐÃ XÓA")
        Catch ex As Exception
            MessageBox.Show("KHÔNG XÓA ĐƯỢC")
        End Try
        ' load lại dư liệu vô dataGridview
        Dim again As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        database.Clear()
        again.Fill(database)
        dgvDanhsachKH.DataSource = database.DefaultView
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class