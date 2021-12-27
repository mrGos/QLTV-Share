Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class frmQuanLyNhaXuatBan
    Private NhaXuatBanBUS As NhaXuatBanBUS
    Private Sub frmQuanLyNhaXuatBanGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NhaXuatBanBUS = New NhaXuatBanBUS()
        loadlistNhaXuatBan()
    End Sub
    Private Sub loadlistNhaXuatBan()
        ' Load LoaiHocSinh list
        Dim listNhaXuatBan = New List(Of NhaXuatBanDTO)
        Dim result As Result
        result = NhaXuatBanBUS.selectAll(listNhaXuatBan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Nhà Xuất Bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachNXB.Columns.Clear()
        dgvDanhSachNXB.DataSource = Nothing

        dgvDanhSachNXB.AutoGenerateColumns = False
        dgvDanhSachNXB.AllowUserToAddRows = False
        dgvDanhSachNXB.DataSource = listNhaXuatBan

        Dim clMaNhaXuatBan = New DataGridViewTextBoxColumn()
        clMaNhaXuatBan.Name = "MaNhaXuatBan"
        clMaNhaXuatBan.HeaderText = "Mã Nhà Xuất Bản"
        clMaNhaXuatBan.DataPropertyName = "MaNhaXuatBan"
        dgvDanhSachNXB.Columns.Add(clMaNhaXuatBan)

        Dim clTenNhaXuatBan = New DataGridViewTextBoxColumn()
        clTenNhaXuatBan.Name = "TenNhaXuatBan"
        clTenNhaXuatBan.HeaderText = "Tên Nhà Xuất Bản"
        clTenNhaXuatBan.DataPropertyName = "TenNhaXuatBan"
        dgvDanhSachNXB.Columns.Add(clTenNhaXuatBan)
    End Sub
    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        loadlistNhaXuatBan()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As frmNhaXuatBanGUI = New frmNhaXuatBanGUI()
        frm.MdiParent = frmMain
        frm.Show()
        btnTaiLai.PerformClick()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        'Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachNXB.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachNXB.RowCount) Then
            Try
                Dim NhaXuatBan As NhaXuatBanDTO
                NhaXuatBan = New NhaXuatBanDTO()

                '1. Mapping data from GUI control
                NhaXuatBan.MaNhaXuatBan = txtMaNhaXuatBan.Text
                NhaXuatBan.TenNhaXuatBan = txtTenNhaXuatBan.Text

                '2. Business .....
                If (NhaXuatBanBUS.isValidName(NhaXuatBan) = False) Then
                    MessageBox.Show("Tên Nhà Xuất Bản không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenNhaXuatBan.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = NhaXuatBanBUS.update(NhaXuatBan)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistNhaXuatBan()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachNXB.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Nhà Xuất Bản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Nhà Xuất Bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachNXB.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachNXB.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Nhà Xuất Bản có mã: " + txtMaNhaXuatBan.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = NhaXuatBanBUS.delete(txtMaNhaXuatBan.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadlistNhaXuatBan()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachNXB.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachNXB.Rows(currentRowIndex).Selected = True
                            End If
                            btnTaiLai.PerformClick()
                            MessageBox.Show("Xóa Nhà Xuất Bản thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Nhà Xuất Bản không thành công Kiểm tra ràng buộc với sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvDanhSachLoaiDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachNXB.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachNXB.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachNXB.RowCount) Then
            Try
                Dim NhaXuatBan = CType(dgvDanhSachNXB.Rows(currentRowIndex).DataBoundItem, NhaXuatBanDTO)
                txtMaNhaXuatBan.Text = NhaXuatBan.MaNhaXuatBan
                txtTenNhaXuatBan.Text = NhaXuatBan.TenNhaXuatBan
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class