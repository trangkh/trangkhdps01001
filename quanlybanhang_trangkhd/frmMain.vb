Public Class frmMain

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        frmQuanlyKH.Show()
    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        frmdangnhap.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        frmdangnhap.Show()

    End Sub

    Private Sub QuảnLýNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNhânViênToolStripMenuItem.Click
        frmQuanLyNV.Show()
    End Sub

    Private Sub ThêmSảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem1.Click
        frmThemSP.Show()
    End Sub
End Class