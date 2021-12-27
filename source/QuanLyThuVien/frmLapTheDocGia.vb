Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class frmLapTheDocGia
    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGiaBUS
    Private qdBUS As QuyDinhBUS
    Private qdDTO As QuyDinhDTO

    Private Sub frmLapTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGiaBUS()
        dtpNgayLapThe.Value = DateTime.Now

        qdDTO = New QuyDinhDTO
        qdBUS = New QuyDinhBUS
        qdBUS.selectQuyDinh(qdDTO)

        ' Load Loaidocgia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)

        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDG.DisplayMember = "TenLoaiDocGia"
        cbLoaiDG.ValueMember = "MaLoaiDocGia"

        cbLoaiDGCapNhat.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDGCapNhat.DisplayMember = "TenLoaiDocGia"
        cbLoaiDGCapNhat.ValueMember = "MaLoaiDocGia"

        loadListDocGia(cbLoaiDG.SelectedValue)
    End Sub

    Private Sub loadListDocGia()
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBus.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbLoaiDG.SelectedIndex = -1
        'dgvListdg.SuspendLayout()
        dgvListDG.Columns.Clear()
        dgvListDG.DataSource = Nothing

        dgvListDG.AutoGenerateColumns = False
        dgvListDG.AllowUserToAddRows = False
        dgvListDG.DataSource = listDocGia

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDocGia"
        clMa.HeaderText = "Mã Đọc Giả"
        clMa.DataPropertyName = "MaDocGia"
        dgvListDG.Columns.Add(clMa)

        Dim clLoaidg = New DataGridView()
        'clLoaidg.Name = "LoaiDG"
        'clLoaidg.HeaderText = "Tên Loại"
        'clLoaidg.DataPropertyName = "MaLoaiDocGia"
        'dgvListdg.Columns.Add(clLoaidg)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "HoTen"
        clHoTen.HeaderText = "Họ Tên"
        clHoTen.DataPropertyName = "HoTen"
        dgvListDG.Columns.Add(clHoTen)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDG.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDG.Columns.Add(clEmail)

        Dim clNgayLap = New DataGridViewTextBoxColumn()
        clNgayLap.Name = "NgayLap"
        clNgayLap.HeaderText = "Ngày Lập Thẻ"
        clNgayLap.DataPropertyName = "NgayLapThe"
        dgvListDG.Columns.Add(clNgayLap)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "NgaySinh"
        dgvListDG.Columns.Add(clNgaySinh)
        'dgvListdg.ResumeLayout()

        Dim clNgayHetHan = New DataGridViewTextBoxColumn()
        clNgayHetHan.Name = "NgayHetHan"
        clNgayHetHan.HeaderText = "Ngày Hết Hạn"
        clNgayHetHan.DataPropertyName = "NgayHetHan"
        dgvListDG.Columns.Add(clNgayHetHan)

        Dim clSoSachDangMuon = New DataGridViewTextBoxColumn()
        clSoSachDangMuon.Name = "SoSachDangMuon"
        clSoSachDangMuon.HeaderText = "Số sách đang mượn"
        clSoSachDangMuon.DataPropertyName = "SoSachDangMuon"
        dgvListDG.Columns.Add(clSoSachDangMuon)

        Dim clTinhTrangThe = New DataGridViewTextBoxColumn()
        clTinhTrangThe.Name = "TinhTrangThe"
        clTinhTrangThe.HeaderText = "Tình Trạng Thẻ"
        clTinhTrangThe.DataPropertyName = "TinhTrangThe"
        dgvListDG.Columns.Add(clTinhTrangThe)

    End Sub

    Private Sub loadListDocGia(maLoai As String)
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = dgBus.selectALL_ByType(maLoai, listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đọc giả theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListdg.SuspendLayout()
        dgvListDG.Columns.Clear()
        dgvListDG.DataSource = Nothing

        dgvListDG.AutoGenerateColumns = False
        dgvListDG.AllowUserToAddRows = False
        dgvListDG.DataSource = listDocGia

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDocGia"
        clMa.HeaderText = "Mã Đọc Giả"
        clMa.DataPropertyName = "MaDocGia"
        dgvListDG.Columns.Add(clMa)

        Dim clLoaidg = New DataGridView()
        'clLoaidg.Name = "LoaiDG"
        'clLoaidg.HeaderText = "Tên Loại"
        'clLoaidg.DataPropertyName = "MaLoaiDocGia"
        'dgvListdg.Columns.Add(clLoaidg)

        Dim clHoTen = New DataGridViewTextBoxColumn()
        clHoTen.Name = "HoTen"
        clHoTen.HeaderText = "Họ Tên"
        clHoTen.DataPropertyName = "HoTen"
        dgvListDG.Columns.Add(clHoTen)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDG.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDG.Columns.Add(clEmail)

        Dim clNgayLap = New DataGridViewTextBoxColumn()
        clNgayLap.Name = "NgayLap"
        clNgayLap.HeaderText = "Ngày Lập Thẻ"
        clNgayLap.DataPropertyName = "NgayLapThe"
        dgvListDG.Columns.Add(clNgayLap)

        Dim clNgaySinh = New DataGridViewTextBoxColumn()
        clNgaySinh.Name = "NgaySinh"
        clNgaySinh.HeaderText = "Ngày Sinh"
        clNgaySinh.DataPropertyName = "NgaySinh"
        dgvListDG.Columns.Add(clNgaySinh)
        'dgvListdg.ResumeLayout()

        Dim clNgayHetHan = New DataGridViewTextBoxColumn()
        clNgayHetHan.Name = "NgayHetHan"
        clNgayHetHan.HeaderText = "Ngày Hết Hạn"
        clNgayHetHan.DataPropertyName = "NgayHetHan"
        dgvListDG.Columns.Add(clNgayHetHan)

        Dim clSoSachDangMuon = New DataGridViewTextBoxColumn()
        clSoSachDangMuon.Name = "SoSachDangMuon"
        clSoSachDangMuon.HeaderText = "Số sách đang mượn"
        clSoSachDangMuon.DataPropertyName = "SoSachDangMuon"
        dgvListDG.Columns.Add(clSoSachDangMuon)

        Dim clTinhTrangThe = New DataGridViewTextBoxColumn()
        clTinhTrangThe.Name = "TinhTrangThe"
        clTinhTrangThe.HeaderText = "Tình Trạng Thẻ"
        clTinhTrangThe.DataPropertyName = "TinhTrangThe"
        dgvListDG.Columns.Add(clTinhTrangThe)
    End Sub
    Private Sub dgvListDG_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListDG.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDG.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        If (dtpNgayHetHan.Enabled = False) Then
            dtpNgayHetHan.Enabled = True
        End If
        If (dtpNgayLapThe.Enabled = False) Then
            dtpNgayLapThe.Enabled = True
        End If


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Try
                Dim dg = CType(dgvListDG.Rows(currentRowIndex).DataBoundItem, DocGiaDTO)
                txtMaSo.Text = dg.MaDocGia
                txtHoTen.Text = dg.HoTen
                txtDiaChi.Text = dg.DiaChi
                dtpNgaySinh.Value = dg.NgaySinh
                dtpNgayLapThe.Value = dg.NgayLapThe
                txtEmail.Text = dg.Email
                cbLoaiDGCapNhat.SelectedIndex = cbLoaiDG.SelectedIndex
                txtTinhTrangThe.Text = dg.TinhTrangThe
                dtpNgayHetHan.Value = dg.NgayHetHan
                nudSoSachDangMuon.Value = dg.SoSachDangMuon
                btnThem.Enabled = False
                btnThem.BackColor = Color.Gray
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub cbLoaiDG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoaiDG.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbLoaiDG.SelectedValue)
            loadListDocGia(maLoai)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Try
                Dim docgia As DocGiaDTO
                docgia = New DocGiaDTO()

                '1. Mapping data from GUI control
                docgia.MaDocGia = txtMaSo.Text
                docgia.HoTen = txtHoTen.Text
                docgia.Email = txtEmail.Text
                docgia.NgayLapThe = dtpNgayLapThe.Value
                docgia.DiaChi = txtDiaChi.Text
                docgia.NgaySinh = dtpNgaySinh.Value

                docgia.MaLoaiDocGia = cbLoaiDGCapNhat.SelectedValue
                docgia.NgayHetHan = dtpNgayHetHan.Value
                docgia.SoSachDangMuon = nudSoSachDangMuon.Value
                docgia.TinhTrangThe = txtTinhTrangThe.Text
                '2. Business .....
                If (dgBus.isValid(docgia) = False) Then
                    MessageBox.Show("Họ tên đọc giả không đúng.")
                    txtHoTen.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = dgBus.update(docgia)
                If (result.FlagResult = True) Then
                    ' Re-Load DocGia list
                    loadListDocGia(cbLoaiDG.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListDG.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDG.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa đọc giả có mã số: " + txtMaSo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        result = dgBus.delete(txtMaSo.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiDocGia list
                            loadListDocGia(cbLoaiDG.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListDG.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListDG.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa độc giả không thành công. Kiểm tra phiếu mượn và các ràng buộc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()



        '1. Mapping data from GUI control
        docgia.MaDocGia = txtMaSo.Text
        docgia.HoTen = txtHoTen.Text
        docgia.DiaChi = txtDiaChi.Text
        docgia.NgaySinh = dtpNgaySinh.Value
        docgia.Email = txtEmail.Text
        docgia.NgayLapThe = dtpNgayLapThe.Value
        docgia.MaLoaiDocGia = cbLoaiDGCapNhat.SelectedValue
        docgia.NgayHetHan = dtpNgayHetHan.Value
        docgia.TinhTrangThe = txtTinhTrangThe.Text
        docgia.SoSachDangMuon = nudSoSachDangMuon.Value
        '2. Business .....

        If (dgBus.isValid(docgia) = False) Then
            MessageBox.Show("Độc giả không hợp lệ. Trống")
            txtHoTen.Focus()
            Return
        End If
        If (dgBus.checkAge(docgia, qdDTO) = False) Then
            MessageBox.Show("Tuổi không hợp lệ: " & (DateTime.Now.Year - docgia.NgaySinh.Year).ToString())
            Return
        End If

        If (dgBus.checkEXP(docgia, qdDTO) = False) Then
            MessageBox.Show("Thời hạn sử dụng không hợp lệ. Thời hạn phải > Ngày Lập và Thẻ chỉ có thời hạn trong  " & qdDTO.thoiHang & " tháng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim span As TimeSpan = docgia.NgayHetHan.Subtract(docgia.NgayLapThe)
            MessageBox.Show((Convert.ToInt32(span.TotalDays / 30.436875)).ToString())
            Return
        End If



        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbLoaiDG.SelectedIndex = cbLoaiDGCapNhat.SelectedIndex
            loadListDocGia(cbLoaiDG.SelectedValue)
        Else
            MessageBox.Show("Thêm Đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub TaoMoi()

        'set MSSH auto
        Dim result As Result
        Dim nextMsdg = "1"
        result = dgBus.buildMSdg(nextMsdg)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        txtHoTen.Text = String.Empty
        txtDiaChi.Text = String.Empty
        txtEmail.Text = String.Empty
        cbLoaiDG.SelectedIndex = cbLoaiDGCapNhat.SelectedIndex
        dtpNgayLapThe.Value = DateTime.Now
        nudSoSachDangMuon.Value = 0
        txtTinhTrangThe.Text = Configuration.ConfigurationManager.AppSettings("TheDuocMuon")
        dtpNgayHetHan.Value = dtpNgayLapThe.Value.AddMonths(6)
        txtMaSo.Text = nextMsdg
    End Sub
    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        TaoMoi()
        btnThem.Enabled = True
        btnThem.BackColor = Color.Snow
        cbLoaiDGCapNhat.SelectedIndex = 1
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class