Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility
Imports System.Configuration
Public Class frmNhanTraSach

    Dim tsBUS As NhanTraSachBUS
    Dim dgBUS As DocGiaBUS

    Dim dgSelected As DocGiaDTO
    Dim pmSelected As PhieuMuonSachDTO
    Dim sachBUS As SachBUS

    Private dataSachDangMuonByDGLoaded As DataTable
    Private listMaPMSByDG As List(Of PhieuMuonSachDTO)
    Private listSachDM As List(Of SachDTO)

    Private Sub frmNhanTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsBUS = New NhanTraSachBUS
        dgBUS = New DocGiaBUS


        listMaPMSByDG = New List(Of PhieuMuonSachDTO)
        Dim listDocGia = New List(Of DocGiaDTO)

        listSachDM = New List(Of SachDTO)

        dataSachDangMuonByDGLoaded = New DataTable
        
        Dim result As Result
        result = dgBUS.selectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("không load được danh sách độc giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        dgvSachDangMuonByDG.AllowUserToAddRows = False

        cbbMaDocGia.DataSource = New BindingSource(listDocGia, String.Empty)
        cbbMaDocGia.DisplayMember = "MaDocGia"
        cbbMaDocGia.ValueMember = "MaDocGia"

        lstSachMuonTra.DisplayMember = "TenSach"
        lstSachMuonTra.ValueMember = "MaSach"


    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Function loadListPMS(mdg As String)


        listMaPMSByDG = Nothing
        listMaPMSByDG = New List(Of PhieuMuonSachDTO)

        sachBUS = New SachBUS

        Dim result As Result
        result = tsBUS.loadListPMSDangMuonByMaDG(mdg, listMaPMSByDG)
        If (result.FlagResult = False) Then
            MessageBox.Show("không load được danh sách Phiếu đang mượn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        cbbMaPhieuMuon.DataSource = New BindingSource(listMaPMSByDG, String.Empty)
        cbbMaPhieuMuon.DisplayMember = "MaPhieuMuonSach"
        cbbMaPhieuMuon.ValueMember = "MaPhieuMuonSach"

    End Function
    Private Function loadDgvSachDangMuonByDG(mdg As String)


        dataSachDangMuonByDGLoaded = Nothing
        dataSachDangMuonByDGLoaded = New DataTable
        Dim result As Result
        result = tsBUS.loadDSSachDangMuonByMaDocGia(mdg, dataSachDangMuonByDGLoaded)
        If (result.FlagResult = False) Then
            MessageBox.Show("không load được danh sách đang mượn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If



        dgvSachDangMuonByDG.DataSource = New BindingSource(dataSachDangMuonByDGLoaded, String.Empty)
        dataSachDangMuonByDGLoaded.Columns("MaPhieuMuon").ColumnName = "Mã Phiếu Mượn"
        dataSachDangMuonByDGLoaded.Columns("MaSach").ColumnName = "Mã Sách"
        dataSachDangMuonByDGLoaded.Columns("TenSach").ColumnName = "Tên Sách"
        dataSachDangMuonByDGLoaded.Columns("ghichu").ColumnName = "Ghi Chú"

        Return True
    End Function

    Private Sub cbbMaDocGia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaDocGia.SelectedIndexChanged

        lstSachDangMuon.Items.Clear()
        lstSachMuonTra.Items.Clear()

        dgSelected = CType(cbbMaDocGia.SelectedItem, DocGiaDTO)


        txtTenDocGia.Text = dgSelected.HoTen
        txtTinhTrangThe.Text = dgSelected.TinhTrangThe
        txtSoSachDangMuon.Text = dgSelected.SoSachDangMuon

        loadListPMS(dgSelected.MaDocGia)
        pmSelected = CType(cbbMaPhieuMuon.SelectedItem, PhieuMuonSachDTO)

        loadDgvSachDangMuonByDG(dgSelected.MaDocGia)
        loadlstSachDangMuon()

        If pmSelected IsNot Nothing Then

            dtpNgayMuon.Value = pmSelected.NgayMuon
            dtpNgayToiHan.Value = pmSelected.NgayTra

            Dim span As TimeSpan = DateTime.Now.Subtract(pmSelected.NgayTra)
            Dim i = span.Days
            If (i < 0) Then
                i = 0
            End If
            txtSoNgayTraQuaHan.Text = i.ToString()
        End If
    End Sub

    Private Function loadlstSachDangMuon()

        lstSachDangMuon.Items.Clear()

        'Lấy danh sách  sách Dang muon
        listSachDM.Clear()

        If pmSelected IsNot Nothing Then


            Dim result As Result
            result = tsBUS.loadListSachDM(dgSelected.MaDocGia, pmSelected.MaPhieuMuonSach, listSachDM)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách được mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return False
            End If


            For Each member In listSachDM
                Dim item = CType(member, SachDTO)
                lstSachDangMuon.Items.Add(item)
            Next

            lstSachDangMuon.DisplayMember = "TenSach"
            lstSachDangMuon.ValueMember = "MaSach"

        End If
        Return True
    End Function

    Private Sub cbbMaPhieuMuon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMaPhieuMuon.SelectedIndexChanged
        pmSelected = CType(cbbMaPhieuMuon.SelectedItem, PhieuMuonSachDTO)
        lstSachDangMuon.Items.Clear()
        lstSachMuonTra.Items.Clear()
        loadlstSachDangMuon()
    End Sub

    Private Sub btnAddSachDangMuon_Click(sender As Object, e As EventArgs) Handles btnAddSachDangMuon.Click
        If lstSachDangMuon.SelectedIndex = -1 Then
            MessageBox.Show("Bạn chưa chọn Sách Đang Mượn")
        Else
            Dim selectedItems = (From i In lstSachDangMuon.SelectedItems).ToList

            For Each selectedItem In selectedItems
                lstSachMuonTra.Items.Add(lstSachDangMuon.SelectedItem)
                lstSachDangMuon.Items.Remove(lstSachDangMuon.SelectedItem)
            Next
        End If
    End Sub

    Private Sub btnRmvMuonTra_Click(sender As Object, e As EventArgs) Handles btnRmvMuonTra.Click
        If lstSachMuonTra.SelectedIndex = -1 Then
            MessageBox.Show("Bạn chưa chọn Sách Muốn Trả")
        Else
            Dim selectedItems = (From i In lstSachMuonTra.SelectedItems).ToList

            For Each selectedItem In selectedItems
                lstSachDangMuon.Items.Add(lstSachMuonTra.SelectedItem)
                lstSachMuonTra.Items.Remove(lstSachMuonTra.SelectedItem)
            Next
        End If
    End Sub

    Private Sub btnTraSach_Click(sender As Object, e As EventArgs) Handles btnTraSach.Click
        Dim ctpm As CTPhieuMuonSachDTO
        ctpm = New CTPhieuMuonSachDTO()


        Dim GhiChu As String



        '0 check field
        If (lstSachMuonTra.Items.Count <= 0) Then
            MessageBox.Show("Chưa chọn sách muốn trả")
            Return
        End If





        '1. Mapping data from GUI control


        ctpm.MaPhieuMuonSach = pmSelected.MaPhieuMuonSach




        '2. Business .....
        If (Integer.Parse(txtSoNgayTraQuaHan.Text) > 0) Then
            GhiChu = ConfigurationManager.AppSettings("QuaHan")
        Else
            GhiChu = ConfigurationManager.AppSettings("DaTra")
        End If

        '3. Insert to DB
        Dim result As Result


        Dim selectedItems = (From i In lstSachMuonTra.Items).ToList

        For Each selectedItem In selectedItems
            Dim sach = CType(selectedItem, SachDTO)



            result = tsBUS.TraSachUpdate(dgSelected.MaDocGia, pmSelected.MaPhieuMuonSach, sach.maSach, GhiChu)
            If (Result.FlagResult = True) Then
                MessageBox.Show("Update Trả sách cho ghi chú Chi tiết Phiếu mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sach.MaTinhTrangSach = "1"
                dgSelected.SoSachDangMuon -= 1
                SachBUS.update(sach)
                dgBUS.update(dgSelected)
                txtSoSachDangMuon.Text = dgSelected.SoSachDangMuon.ToString()
            Else
                MessageBox.Show("Thêm Chi Tiết Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
            End If
        Next



        lstSachDangMuon.Items.Clear()
        lstSachMuonTra.Items.Clear()
        loadlstSachDangMuon()
        loadDgvSachDangMuonByDG(dgSelected.MaDocGia)
    End Sub
End Class