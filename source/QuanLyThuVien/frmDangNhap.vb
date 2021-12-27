Imports System.Configuration
Imports System.Data.SqlClient
Imports Utility
Imports QLTV_BUS
Imports QLTV_DTO

Public Class frmDangNhap

    Private ttBUS As ThuThuBUS
    Private result As Result
    Private ttDTO As ThuThuDTO



    Private Sub txtBoxTenDangNhap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoxTenDangNhap.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnDangNhap.PerformClick()
        End If
    End Sub

    Private Sub txtMatKhau_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatKhau.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnDangNhap.PerformClick()
        End If
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click



        ttDTO.TaiKhoan = txtBoxTenDangNhap.Text
        ttDTO.MatKhau = txtMatKhau.Text


        If (ttBUS.checkValidThuThu(ttDTO) = False) Then
            MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        result = ttBUS.selectALL(ttDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Đăng nhập thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmMain.LưuToolStripMenuItem.Enabled = True
            frmMain.BáoCáoToolStripMenuItem.Enabled = True
            frmMain.ĐăngXuấtToolStripMenuItem.Enabled = True
            frmMain.QuyĐịnhToolStripMenuItem.Enabled = True

            frmMain.ĐăngNhậpToolStripMenuItem.Enabled = False

            Me.Dispose()
            Me.Close()
        Else
            MessageBox.Show("Đăng nhập không thành công. Sai tên tài khoản hoặc mật khẩu ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Name = "Đăng nhập"
        result = New Result
        ttDTO = New ThuThuDTO
        ttBUS = New ThuThuBUS

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        Dim frm As frmDangKy = New frmDangKy
        frm.ShowDialog()
        frm.Dispose()
    End Sub
End Class