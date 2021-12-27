Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility
Imports System.Configuration
Public Class frmPhieuMuonSach
    Dim result As Result
    Dim sachBUS As SachBUS
    Private dgBus As DocGiaBUS
    Dim dgSelected
    Dim qdBUS As QuyDinhBUS
    Dim qd As QuyDinhDTO
    Private pmsBUS As PhieuMuonSachBUS
    Private ctpmBUS As CTPhieuMuonSachBUS
    Dim span As New TimeSpan
    Private Sub frmPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sachBUS = New SachBUS()
        dgBus = New DocGiaBUS()
        ctpmBUS = New CTPhieuMuonSachBUS()

        dtpNgayMuon.Value = DateTime.Now
        dtpNgayToiHan.Value = dtpNgayMuon.Value.AddDays(4)
        pmsBUS = New PhieuMuonSachBUS
        qdBUS = New QuyDinhBUS
        qd = New QuyDinhDTO

        result = qdBUS.selectQuyDinh(qd)
        If (result.FlagResult = False) Then
            MessageBox.Show("load quy định thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        lstSachMuonMuon.DisplayMember = "TenSach"
        lstSachMuonMuon.ValueMember = "MaSach"

        ' Load docgia list
        Dim listDocGia = New List(Of DocGiaDTO)

        result = dgBus.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        cbbMaDocGia.DataSource = New BindingSource(listDocGia, String.Empty)
        cbbMaDocGia.DisplayMember = "MaDocGia"
        cbbMaDocGia.ValueMember = "MaDocGia"



        'set MSPMS auto
        Dim nextMS = "1"
        result = pmsBUS.BuildMS(nextMS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã PM Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        txtMaPhieuMuon.Text = nextMS
        txtGhiChu.Text = ConfigurationManager.AppSettings("DangMuon")


        loadlstSachDuocMuon()
        loadDgvQuanLySach()

    End Sub

    Private Function loadDgvQuanLySach()



        Dim listSach As New List(Of SachDTO)
        Dim result As Result
        result = sachBUS.selectAll(listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return False
        End If

        'dgvQuanLySach.SuspendLayout()
        dgvQuanLySach.Columns.Clear()
        dgvQuanLySach.DataSource = Nothing

        dgvQuanLySach.AutoGenerateColumns = False
        dgvQuanLySach.AllowUserToAddRows = False

        dgvQuanLySach.DataSource = listSach

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
        clMaLoaiSach.HeaderText = "Mã Thể Loại"
        clMaLoaiSach.DataPropertyName = "maloaisach"
        dgvQuanLySach.Columns.Add(clMaLoaiSach)

        Dim clTacGiaSach = New DataGridViewTextBoxColumn()
        clTacGiaSach.Name = "tacgia"
        clTacGiaSach.HeaderText = "Mã Tác giả"
        clTacGiaSach.DataPropertyName = "maTacGia"
        dgvQuanLySach.Columns.Add(clTacGiaSach)


        Return True
    End Function

    Private Function loadlstSachDuocMuon()
        'Lấy danh sách loại sách
        Dim listSach As New List(Of SachDTO)
        result = sachBUS.selectAllByStatus("1", listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách được mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return False
        End If

        For Each member In listSach
            Dim item = CType(member, SachDTO)
            lstSachDuocMuon.Items.Add(item)
        Next

        lstSachDuocMuon.DisplayMember = "TenSach"
        lstSachDuocMuon.ValueMember = "MaSach"
        Return True
    End Function

    Private Sub btnAddSachDuocMuon_Click(sender As Object, e As EventArgs) Handles btnAddSachDuocMuon.Click

        If lstSachDuocMuon.SelectedIndex = -1 Then
            MessageBox.Show("Bạn chưa chọn Sách Được Mượn")
        Else
            Dim selectedItems = (From i In lstSachDuocMuon.SelectedItems).ToList

            For Each selectedItem In selectedItems
                lstSachMuonMuon.Items.Add(lstSachDuocMuon.SelectedItem)
                lstSachDuocMuon.Items.Remove(lstSachDuocMuon.SelectedItem)
            Next
        End If
    End Sub

    Private Sub btnRmvSachMuonMuon_Click(sender As Object, e As EventArgs) Handles btnRmvSachMuonMuon.Click
        If lstSachMuonMuon.SelectedIndex = -1 Then
            MessageBox.Show("Bạn chưa chọn Sách Muốn Mượn")
        Else
            Dim selectedItems = (From i In lstSachMuonMuon.SelectedItems).ToList

            For Each selectedItem In selectedItems
                lstSachDuocMuon.Items.Add(lstSachMuonMuon.SelectedItem)
                lstSachMuonMuon.Items.Remove(lstSachMuonMuon.SelectedItem)
            Next
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub cbbMaDocGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaDocGia.SelectedIndexChanged

        dgSelected = CType(cbbMaDocGia.SelectedItem, DocGiaDTO)
        txtTenDocGia.Text = dgSelected.HoTen
        txtTinhTrangThe.Text = dgSelected.TinhTrangThe
        txtSoSachDangMuon.Text = dgSelected.SoSachDangMuon.ToString()
    End Sub

    Private Function LayMaCTPMKeTiep() As String
        'set MSPMS auto
        Dim nextCTPM = "1"
        result = ctpmBUS.BuildMS(nextCTPM)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã  Chi Tiết PM Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return String.Empty
        End If
        Return nextCTPM
    End Function
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim ctpm As CTPhieuMuonSachDTO
        ctpm = New CTPhieuMuonSachDTO()

        Dim phieumuon As PhieuMuonSachDTO
        phieumuon = New PhieuMuonSachDTO()

        Dim slSachMuonMuon = lstSachMuonMuon.Items.Count
        Dim DkSoLuongMuon = Int32.Parse(txtSoSachDangMuon.Text) + slSachMuonMuon

        '0 check field



        If (lstSachMuonMuon.Items.Count <= 0) Then
            MessageBox.Show("Chưa chọn sách muốn mượn")
            Return
        End If
        If (IsNumeric(txtSoSachDangMuon.Text) = False) Then
            MessageBox.Show("Số sách đang mượn không phải là số. Trống")
            txtSoSachDangMuon.Focus()
            Return
        End If

        If (DkSoLuongMuon > qd.SoLuongSachToiDa) Then
            MessageBox.Show("Tổng số Sách Đang Mượn và Muốn Mượn vượt quá số lượng cho phép " & qd.SoLuongSachToiDa.ToString())
            txtSoSachDangMuon.Focus()
            Return
        End If

        If (txtTinhTrangThe.Text <> ConfigurationManager.AppSettings("TheDuocMuon")) Then
            MessageBox.Show("Thẻ của bạn không Được Mượn. Chỉ cho phép thẻ có tình trạng " & ConfigurationManager.AppSettings("TheDuocMuon"))
            txtSoSachDangMuon.Focus()
            Return
        End If

        If (pmsBUS.isNgayTraHopLe(dtpNgayToiHan.Value, dtpNgayMuon.Value, qd) = False) Then
            MessageBox.Show("Số ngày mượn của bạn không hợp lệ. Quy định mượn trong vòng " & qd.SoNgayMuonToiDa & " ngày", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show((Convert.ToInt32(dtpNgayToiHan.Value.Subtract(dtpNgayMuon.Value).TotalDays)).ToString())
            txtSoSachDangMuon.Focus()
            Return
        End If

        'MessageBox.Show((Convert.ToInt32(dtpNgayToiHan.Value.Subtract(dtpNgayMuon.Value).TotalDays)).ToString())

        If (pmsBUS.isSachTraTre()) Then
            MessageBox.Show("Có sách đang mượn quá hạn. Không được mượn sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgSelected = CType(cbbMaDocGia.SelectedItem, DocGiaDTO)

        '1. Mapping data from GUI control
        phieumuon.MaPhieuMuonSach = txtMaPhieuMuon.Text
        phieumuon.MaDocGia = cbbMaDocGia.SelectedValue
        phieumuon.NgayMuon = dtpNgayMuon.Value
        phieumuon.NgayTra = dtpNgayToiHan.Value

        ctpm.MaPhieuMuonSach = phieumuon.MaPhieuMuonSach


        Console.WriteLine("PMSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS: " + phieumuon.MaPhieuMuonSach + ">>" + phieumuon.MaPhieuMuonSach + ">>" + phieumuon.NgayMuon.ToString() + ">>" + phieumuon.NgayTra.ToString())
        '2. Business .....



        ' If (dgBus.isValid(docgia) = False) Then
        'MessageBox.Show("Độc giả không hợp lệ. Trống")
        'txtHoTen.Focus()
        'Return
        ' End If


        '3. Insert to DB
        result = pmsBUS.insert(phieumuon)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim selectedItems = (From i In lstSachMuonMuon.Items).ToList

        For Each selectedItem In selectedItems
            Dim sach = CType(selectedItem, SachDTO)
            Dim docgia = CType(cbbMaDocGia.SelectedItem, DocGiaDTO)
            Console.WriteLine("CT: " + sach.maSach)
            ctpm.MaCTPhieuMuonSach = LayMaCTPMKeTiep()
            ctpm.MaSach = sach.maSach
            ctpm.GhiChu = txtGhiChu.Text
            result = ctpmBUS.insert(ctpm)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm Chi tiết Phiếu mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sach.MaTinhTrangSach = "2"
                docgia.SoSachDangMuon += 1
                sachBUS.update(sach)
                dgBus.update(docgia)
                txtSoSachDangMuon.Text = docgia.SoSachDangMuon.ToString()
            Else
                MessageBox.Show("Thêm Chi Tiết Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Next

        'set MSPMS auto
        Dim nextMS = "1"
        result = pmsBUS.BuildMS(nextMS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã PM Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        txtMaPhieuMuon.Text = nextMS

        lstSachDuocMuon.Items.Clear()
        loadlstSachDuocMuon()
        lstSachMuonMuon.Items.Clear()
    End Sub
End Class