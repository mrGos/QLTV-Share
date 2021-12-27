Imports System.Configuration
Imports System.Data.SqlClient
Imports Utility
Imports QLTV_DTO
Imports QLTV_BUS
Public Class frmDangKy


    Private ttDTO As ThuThuDTO
    Private ttBUS As ThuThuBUS
    Private Result As Result

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click

        If ttBUS.checkSignIn(txtBoxTenDangNhap.Text, txtMatKhau.Text, txtBoxNhapLaiMatKhau.Text) = False Then
            MessageBox.Show("Đăng ký không thành công. Kiểm tra lại mật khẩu và nhập lại mật khẩu ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ttDTO.TaiKhoan = txtBoxTenDangNhap.Text
        ttDTO.MatKhau = txtMatKhau.Text

        Result = ttBUS.insert(ttDTO)
        If (Result.FlagResult = True) Then
            MessageBox.Show("Đăng ký thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmMain.LưuToolStripMenuItem.Enabled = True
            frmMain.BáoCáoToolStripMenuItem.Enabled = True
            frmMain.ĐăngXuấtToolStripMenuItem.Enabled = True

            frmMain.ĐăngNhậpToolStripMenuItem.Enabled = False

            Me.Dispose()
            Me.Close()
        Else
            MessageBox.Show("Tài khoản đã có người sử dụng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(Result.SystemMessage)
            Return
        End If

    End Sub



    Private Sub frmDangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Name = "Đăng ký"
        ttDTO = New ThuThuDTO
        ttBUS = New ThuThuBUS

    End Sub
End Class