Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmTacGiaGUI
    Private tgBUS As TacGiaBUS
    Private Sub frmTacGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgBUS = New TacGiaBUS()

        ' Get Next ID
        Dim nextID As String = String.Empty
        Dim result As Result
        result = tgBUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaTacGia.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim tg As TacGiaDTO
        tg = New TacGiaDTO()

        '1. Mapping data from GUI control
        tg.maTacGia = txtMaTacGia.Text
        tg.tenTacGia = txtTenTacGia.Text

        '2. Business .....
        If (tgBUS.isValidName(tg) = False) Then
            MessageBox.Show("Tên Loại đọc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If

        If (tgBUS.isValidCount() = False) Then
            MessageBox.Show("Số loại đọc giả vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tgBUS.insert(tg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenTacGia.Text = String.Empty

            ' Get Next ID
            Dim nextID As String
            result = tgBUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaTacGia.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnNhapVanDong_Click(sender As Object, e As EventArgs) Handles btnNhapVanDong.Click
        Dim tg As TacGiaDTO
        tg = New TacGiaDTO()

        '1. Mapping data from GUI control
        tg.maTacGia = txtMaTacGia.Text
        tg.tenTacGia = txtTenTacGia.Text

        '2. Business .....
        If (tgBUS.isValidName(tg) = False) Then
            MessageBox.Show("Tên Loại đọc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If
        If (tgBUS.isValidCount() = False) Then
            MessageBox.Show("Số loại đọc giả vượt mức cho phép. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenTacGia.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tgBUS.insert(tg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại đọc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class