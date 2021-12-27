Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmQuanLyTacGia
    Private tacgiaBUS As TacGiaBUS
    Private Sub frmQuanLyTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tacgiaBUS = New TacGiaBUS()
        loadlistTacGia()
    End Sub
    Private Sub loadlistTacGia()
        ' Load LoaiHocSinh list
        Dim listTacGia = New List(Of TacGiaDTO)
        Dim result As Result
        result = tacgiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTG.Columns.Clear()
        dgvDanhSachTG.DataSource = Nothing

        dgvDanhSachTG.AutoGenerateColumns = False
        dgvDanhSachTG.AllowUserToAddRows = False
        dgvDanhSachTG.DataSource = listTacGia

        Dim clMaTacGia = New DataGridViewTextBoxColumn()
        clMaTacGia.Name = "MaTacGia"
        clMaTacGia.HeaderText = "Mã Tác Giả"
        clMaTacGia.DataPropertyName = "MaTacGia"
        dgvDanhSachTG.Columns.Add(clMaTacGia)

        Dim clTenTacGia = New DataGridViewTextBoxColumn()
        clTenTacGia.Name = "TenTacGia"
        clTenTacGia.HeaderText = "Tên Tác Giả"
        clTenTacGia.DataPropertyName = "TenTacGia"
        dgvDanhSachTG.Columns.Add(clTenTacGia)

    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        'Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTG.RowCount) Then
            Try
                Dim tacgia As TacGiaDTO
                tacgia = New TacGiaDTO()

                '1. Mapping data from GUI control
                tacgia.maTacGia = txtMaTacGia.Text
                tacgia.tenTacGia = txtTenTacGia.Text

                '2. Business .....
                If (tacgiaBUS.isValidName(tacgia) = False) Then
                    MessageBox.Show("Tên tác giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenTacGia.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = tacgiaBUS.update(tacgia)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistTacGia()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachTG.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTG.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa tác giả có mã: " + txtMaTacGia.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = tacgiaBUS.delete(txtMaTacGia.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadlistTacGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachTG.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachTG.Rows(currentRowIndex).Selected = True
                            End If
                            btnTaiLai.PerformClick()
                            MessageBox.Show("Xóa tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa tác giả không thành công. Kiểm tra ràng buộc với sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        loadlistTacGia()
    End Sub

    Private Sub dgvDanhSachLoaiDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTG.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTG.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTG.RowCount) Then
            Try
                Dim tacgia = CType(dgvDanhSachTG.Rows(currentRowIndex).DataBoundItem, TacGiaDTO)
                txtMaTacGia.Text = tacgia.maTacGia
                txtTenTacGia.Text = tacgia.tenTacGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As frmTacGiaGUI = New frmTacGiaGUI()
        frm.MdiParent = frmMain
        frm.Show()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class