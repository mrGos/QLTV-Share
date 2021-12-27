Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmNhaXuatBanGUI
    Private nxbBUS As NhaXuatBanBUS
    Private Sub frmNhaXuatBanGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nxbBUS = New NhaXuatBanBUS()

        ' Get Next ID
        Dim nextID As String = String.Empty
        Dim result As Result
        result = nxbBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaNhaXuatBan.Text = nextID
        Else
            MessageBox.Show("Lấy ID kế tiếp của Nhà xuất bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim nxb As NhaXuatBanDTO
        nxb = New NhaXuatBanDTO()

        '1. Mapping data from GUI control
        nxb.MaNhaXuatBan = txtMaNhaXuatBan.Text
        nxb.TenNhaXuatBan = txtTenNhaXuatBan.Text

        '2. Business .....
        If (nxbBUS.isValidName(nxb) = False) Then
            MessageBox.Show("Tên Nhà xuất bản không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenNhaXuatBan.Focus()
            Return
        End If


        '3. Insert to DB
        Dim result As Result
        result = nxbBUS.insert(nxb)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Nhà xuất bản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenNhaXuatBan.Text = String.Empty

            ' Get Next ID
            Dim nextID As String = String.Empty
            result = nxbBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaNhaXuatBan.Text = nextID
            Else
                MessageBox.Show("Lấy ID kế tiếp của Nhà xuất bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm Nhà xuất bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVanDong_Click(sender As Object, e As EventArgs) Handles btnNhapVanDong.Click
        Dim nxb As NhaXuatBanDTO
        nxb = New NhaXuatBanDTO()

        '1. Mapping data from GUI control
        nxb.MaNhaXuatBan = txtMaNhaXuatBan.Text
        nxb.TenNhaXuatBan = txtTenNhaXuatBan.Text

        '2. Business .....
        If (nxbBUS.isValidName(nxb) = False) Then
            MessageBox.Show("Tên Nhà xuất bản không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenNhaXuatBan.Focus()
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = nxbBUS.insert(nxb)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Nhà xuất bản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm Nhà xuất bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class