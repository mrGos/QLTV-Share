Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility
Public Class frmNhapSach
    Private sachBUS As SachBUS
    Private tacGiaBUS As TacGiaBUS
    Private loaiSachBUS As LoaiSachBUS
    Private nhaxuatbanBUS As NhaXuatBanBUS
    Private tinhtrangsachBUS As TinhTrangSachBUS
    Private search As Boolean

    Private Sub frmNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SachBUS = New SachBUS()
        LoaiSachBUS = New LoaiSachBUS()
        tacGiaBUS = New TacGiaBUS()
        nhaxuatbanBUS = New NhaXuatBanBUS()
        tinhtrangsachBUS = New TinhTrangSachBUS()

        Dim result As Result

        'Lấy danh sách loại sách
        Dim listLoaiSach As New List(Of LoaiSachDTO)
        result = LoaiSachBUS.selectAll(listLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxLoaiSach.DataSource = New BindingSource(listLoaiSach, String.Empty)
        comboBoxLoaiSach.DisplayMember = "tenLoai"
        comboBoxLoaiSach.ValueMember = "maLoai"

        'Lấy danh sách nhà xuất bản
        Dim listNhaXuatBan As New List(Of NhaXuatBanDTO)

        result = nhaxuatbanBUS.selectAll(listNhaXuatBan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách nhà xuất bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxNhaXuatBan.DataSource = New BindingSource(listNhaXuatBan, String.Empty)
        comboBoxNhaXuatBan.DisplayMember = "TenNhaXuatBan"
        comboBoxNhaXuatBan.ValueMember = "maNhaXuatBan"

        'Lấy danh sách tác giả
        Dim listTacGia As New List(Of TacGiaDTO)
        result = tacGiaBUS.selectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tác giả không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        comboBoxTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        comboBoxTacGia.ValueMember = "maTacGia"
        comboBoxTacGia.DisplayMember = "tenTacGia"

        'Lấy danh sách Tình Trạng Sách
        Dim listTinhTrangSach As New List(Of TinhTrangSachDTO)

        result = tinhtrangsachBUS.selectAll(listTinhTrangSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tình trạng sách  bản không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbbTinhTrangSach.DataSource = New BindingSource(listTinhTrangSach, String.Empty)
        cbbTinhTrangSach.ValueMember = "MaTinhTrangSach"
        cbbTinhTrangSach.DisplayMember = "TenTinhTrangSach"

        Dim tb_TimKiem As DataTable
        tb_TimKiem = New DataTable("Tìm Kiếm")
        tb_TimKiem.Columns.Add("onDB", GetType(String))
        tb_TimKiem.Columns.Add("OnDp", GetType(String))

        tb_TimKiem.Rows.Add("masach", "Mã sách")
        tb_TimKiem.Rows.Add("tensach", "Tên sách")
        tb_TimKiem.Rows.Add("tenloaisach", "Loại sách")
        tb_TimKiem.Rows.Add("tentacgia", "Tên tác giả")
        tb_TimKiem.Rows.Add("year(namxuatban)", "Ngày xuất bản")
        tb_TimKiem.Rows.Add("tennhaxuatban", "Nhà xuất bản")
        tb_TimKiem.Rows.Add("trigia", "Trị giá")

        comboBoxTimKiem.DataSource = New BindingSource(tb_TimKiem, String.Empty)
        comboBoxTimKiem.DisplayMember = "OnDp"
        comboBoxTimKiem.ValueMember = "onDB"


        loadDgvQuanLySach()

    End Sub
    Private Function loadDgvQuanLySach()
        Dim listSach As New List(Of SachDTO)
        Dim result As Result
        If search Then
            result = sachBUS.selectWithFilter(listSach, comboBoxTimKiem.SelectedValue, textBoxTimKiem.Text)
        Else
            result = sachBUS.selectAll(listSach)
        End If

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return False
        End If

        dgvQuanLySach.SuspendLayout()
        dgvQuanLySach.Columns.Clear()
        dgvQuanLySach.DataSource = Nothing

        dgvQuanLySach.AutoGenerateColumns = False
        dgvQuanLySach.AllowUserToAddRows = False
        dgvQuanLySach.DataSource = listSach

        Dim clSTT = New DataGridViewTextBoxColumn()
        clSTT.Name = "stt"
        clSTT.HeaderText = "STT"
        clSTT.DataPropertyName = ""
        dgvQuanLySach.Columns.Add(clSTT)
        dgvQuanLySach.Columns(0).Width = 50

        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "masach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "masach"
        dgvQuanLySach.Columns.Add(clMaSach)


        Dim clTenSach = New DataGridViewTextBoxColumn()
        clTenSach.Name = "tensach"
        clTenSach.HeaderText = "Tên Sách"
        clTenSach.DataPropertyName = "tensach"
        dgvQuanLySach.Columns.Add(clTenSach)

        Dim clMaLoaiSach = New DataGridViewTextBoxColumn()
        clMaLoaiSach.Name = "Loaisach"
        clMaLoaiSach.HeaderText = "Mã Loại sách"
        clMaLoaiSach.DataPropertyName = "maloaisach"
        dgvQuanLySach.Columns.Add(clMaLoaiSach)

        Dim clTacGiaSach = New DataGridViewTextBoxColumn()
        clTacGiaSach.Name = "tacgia"
        clTacGiaSach.HeaderText = "Mã Tác giả"
        clTacGiaSach.DataPropertyName = "maTacGia"
        dgvQuanLySach.Columns.Add(clTacGiaSach)

        Dim clMaNhaXuatBan = New DataGridViewTextBoxColumn()
        clMaNhaXuatBan.Name = "nhaxuatban"
        clMaNhaXuatBan.HeaderText = "Mã Nhà Xuất Bản"
        clMaNhaXuatBan.DataPropertyName = "manhaxuatban"
        dgvQuanLySach.Columns.Add(clMaNhaXuatBan)

        Dim clNgayNhap = New DataGridViewTextBoxColumn()
        clNgayNhap.Name = "ngaynhap"
        clNgayNhap.HeaderText = "Ngày Nhập Sách"
        clNgayNhap.DataPropertyName = "ngaynhap"
        dgvQuanLySach.Columns.Add(clNgayNhap)

        Dim clNamXuatBan = New DataGridViewTextBoxColumn()
        clNamXuatBan.Name = "namxuatban"
        clNamXuatBan.HeaderText = "Năm Xuất Bản"
        clNamXuatBan.DataPropertyName = "namXuatBan"
        dgvQuanLySach.Columns.Add(clNamXuatBan)

        Dim clTriGia = New DataGridViewTextBoxColumn()
        clTriGia.Name = "trigia"
        clTriGia.HeaderText = "Trị giá"
        clTriGia.DataPropertyName = "trigia"
        dgvQuanLySach.Columns.Add(clTriGia)

        Dim clTinhTrangSach = New DataGridViewTextBoxColumn()
        clTinhTrangSach.Name = "matinhtrangsach"
        clTinhTrangSach.HeaderText = "Mã Tình Trạng Sách"
        clTinhTrangSach.DataPropertyName = "matinhtrangsach"
        dgvQuanLySach.Columns.Add(clTinhTrangSach)

        search = False
        buttonThemSach.Enabled = False

        Return True
    End Function
    Private Sub dgvQuanLySach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvQuanLySach.SelectionChanged
        Dim currentRowIndex As Integer = dgvQuanLySach.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLySach.RowCount) Then
            Try
                Dim sach = CType(dgvQuanLySach.Rows(currentRowIndex).DataBoundItem, SachDTO)
                textBoxMaSach.Text = sach.maSach
                textBoxTenSach.Text = sach.tenSach
                comboBoxLoaiSach.SelectedValue = sach.maLoaiSach
                comboBoxTacGia.SelectedValue = sach.maTacGia
                comboBoxNhaXuatBan.SelectedValue = sach.maNhaXuatBan
                dtpNamXuatBan.Value = sach.namXuatBan.Date
                dtpNgayNhap.Value = sach.ngayNhap
                textBoxTriGia.Text = sach.triGia.ToString()
                cbbTinhTrangSach.SelectedValue = sach.MaTinhTrangSach
                cbbTinhTrangSach.Enabled = True
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub buttonThoat_Click(sender As Object, e As EventArgs) Handles buttonThoat.Click
        Me.Close()
    End Sub

    Private Sub buttonRefresh_Click(sender As Object, e As EventArgs) Handles buttonRefresh.Click
        loadDgvQuanLySach()
    End Sub

    Private Sub buttonXoaHet_Click(sender As Object, e As EventArgs) Handles buttonXoaHet.Click
        Dim listSach As List(Of SachDTO)
        listSach = dgvQuanLySach.DataSource
        If (listSach.Count = 0) Then
            MessageBox.Show("Không có sách", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Select Case MsgBox("Bạn có thực sự muốn xóa hết sách ", MsgBoxStyle.YesNo, "Information")
            Case MsgBoxResult.Yes
                Try
                    '1. Delete from DB
                    Dim resultDeleteAllSach As Result
                    resultDeleteAllSach = sachBUS.deleteAll()
                    If (resultDeleteAllSach.FlagResult = True) Then

                        ' Re-Load LoaiDocGia list
                        loadDgvQuanLySach()

                        MessageBox.Show("Xóa sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Xóa sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        System.Console.WriteLine(resultDeleteAllSach.SystemMessage)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                End Try
            Case MsgBoxResult.No
                Return
        End Select
        TaoMoi()
    End Sub

    Private Sub TaoMoi()
        Dim result As Result
        Dim nextMssach = "1"
        result = sachBUS.BuildMS(nextMssach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        textBoxMaSach.Text = nextMssach
        textBoxTenSach.Text = String.Empty
        dtpNamXuatBan.Value = DateTime.Now
        dtpNgayNhap.Value = DateTime.Now
        textBoxTriGia.Text = "30000"

    End Sub
    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        TaoMoi()
        buttonThemSach.Enabled = True
    End Sub

    Private Sub buttonThemSach_Click(sender As Object, e As EventArgs) Handles buttonThemSach.Click
        Dim sach As SachDTO
        sach = New SachDTO()

        If (IsNumeric(textBoxTriGia.Text) = False) Then
            MessageBox.Show("Trị Gía không hợp lệ. Trống")
            textBoxTriGia.Focus()
            Return
        End If
        '1. Mapping data from GUI control
        sach.maSach = textBoxMaSach.Text
        sach.tenSach = textBoxTenSach.Text
        sach.maLoaiSach = comboBoxLoaiSach.SelectedValue
        sach.maNhaXuatBan = comboBoxNhaXuatBan.SelectedValue
        sach.maTacGia = comboBoxTacGia.SelectedValue
        sach.namXuatBan = dtpNamXuatBan.Value
        sach.ngayNhap = dtpNgayNhap.Value
        sach.triGia = Convert.ToInt32(textBoxTriGia.Text)
        sach.MaTinhTrangSach = cbbTinhTrangSach.SelectedValue

        '2. Business .....
        If (sachBUS.isValid(sach) = False) Then
            MessageBox.Show("Sách không hợp lệ. Trống")
            textBoxTenSach.Focus()
            Return
        End If

        If (sachBUS.checkNamXuatBan(sach) = False) Then
            MessageBox.Show("Khoảng cách năm xuất bản không hợp lệ")
            Return
        End If

        '3. Insert to DB
        Dim result As Result
        result = sachBUS.insert(sach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadDgvQuanLySach()
        Else
            MessageBox.Show("Thêm Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub buttonCapNhap_Click(sender As Object, e As EventArgs) Handles buttonCapNhap.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvQuanLySach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLySach.RowCount) Then
            Try
                Dim sach As SachDTO
                sach = New SachDTO()

                If (IsNumeric(textBoxTriGia.Text) = False) Then
                    MessageBox.Show("Trị Gía không hợp lệ. Trống")
                    textBoxTriGia.Focus()
                    Return
                End If
                '1. Mapping data from GUI control
                sach.maSach = textBoxMaSach.Text
                sach.tenSach = textBoxTenSach.Text
                sach.maLoaiSach = comboBoxLoaiSach.SelectedValue
                sach.maNhaXuatBan = comboBoxNhaXuatBan.SelectedValue
                sach.maTacGia = comboBoxTacGia.SelectedValue
                sach.namXuatBan = dtpNamXuatBan.Value
                sach.ngayNhap = dtpNgayNhap.Value
                sach.triGia = Convert.ToInt32(textBoxTriGia.Text)
                sach.MaTinhTrangSach = cbbTinhTrangSach.SelectedValue

                '2. Business .....
                If (sachBUS.isValid(sach) = False) Then
                    MessageBox.Show("Sách không hợp lệ. Trống")
                    textBoxTenSach.Focus()
                    Return
                End If
                If (sachBUS.checkNamXuatBan(sach) = False) Then
                    MessageBox.Show("Ngày tháng xuất bản sách không hợp lệ")
                    Return
                End If
                '3. update to DB
                Dim result As Result
                result = sachBUS.update(sach)
                If (result.FlagResult = True) Then
                    ' Re-Load DocGia list
                    loadDgvQuanLySach()
                    ' Hightlight the row has been updated on table
                    dgvQuanLySach.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvQuanLySach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvQuanLySach.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa đọc giả có mã số: " + textBoxMaSach.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = sachBUS.delete(textBoxMaSach.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiDocGia list
                            loadDgvQuanLySach()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvQuanLySach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvQuanLySach.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Sách không thành công. Kiểm tra lại các ràng buộc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub dgvQuanLySach_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvQuanLySach.RowPostPaint
        Dim b As SolidBrush
        b = New SolidBrush(dgvQuanLySach.RowHeadersDefaultCellStyle.ForeColor)
        Using (b)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub buttonTimKiem_Click(sender As Object, e As EventArgs) Handles buttonTimKiem.Click
        If (textBoxTimKiem.Text <> String.Empty) Then
            search = True
        End If
        loadDgvQuanLySach()
    End Sub

    Private Sub dgvQuanLySach_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvQuanLySach.MouseClick
        buttonThemSach.Enabled = False
    End Sub
End Class