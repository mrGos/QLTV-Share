Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmQuyDinh
    Dim qdBus As QuyDinhBUS
    Dim quydinh As QuyDinhDTO

    Private Sub frmQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qdBus = New QuyDinhBUS()
        Dim result = qdBus.selectQuyDinh(quydinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If

        txtTuoiToiThieu.Text = quydinh.TuoiToiThieu
        txtTuoiToiDa.Text = quydinh.TuoiToiDa
        txtKhoangNamXB.Text = quydinh.khoangNamXuatBan
        txtSoLuongSachToiDa.Text = quydinh.SoLuongSachToiDa
        txtSoNgayMuongToiDa.Text = quydinh.SoNgayMuonToiDa
        txtTHSD.Text = quydinh.thoiHang
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try
            quydinh.TuoiToiThieu = Integer.Parse(txtTuoiToiThieu.Text)
            quydinh.TuoiToiDa = Integer.Parse(txtTuoiToiDa.Text)
            quydinh.khoangNamXuatBan = Integer.Parse(txtKhoangNamXB.Text)
            quydinh.SoLuongSachToiDa = Integer.Parse(txtSoLuongSachToiDa.Text)
            quydinh.SoNgayMuonToiDa = Integer.Parse(txtSoNgayMuongToiDa.Text)
            quydinh.thoiHang = Integer.Parse(txtTHSD.Text)
            Dim result = qdBus.update(quydinh)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub txtTuoiToiThieu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTuoiToiThieu.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTuoiToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTuoiToiDa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtKhoangNamXB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKhoangNamXB.KeyPress, txtTHSD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSoLuongSachToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuongSachToiDa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSoNgayMuongToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoNgayMuongToiDa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class