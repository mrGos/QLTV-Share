Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Imports Configuration

Public Class frmQuanLyPhieuMuonSach
    Private listPMS As List(Of PhieuMuonSachDTO)
    Private listCT As List(Of CTPhieuMuonSachDTO)
    Private dgBUS As DocGiaBUS

    Private strGC_DangMuon = Configuration.ConfigurationManager.AppSettings("DangMuon")
    Private strGC2_QuaHan = Configuration.ConfigurationManager.AppSettings("QuaHan")
    Private strGC3_TraTre = Configuration.ConfigurationManager.AppSettings("DaTra")
    Private sBUS As SachBUS


    Private pmsBUS As PhieuMuonSachBUS
    Private ctBUS As CTPhieuMuonSachBUS
    Private result As Result
    Private pmSelected As PhieuMuonSachDTO
    Private ctSelected As CTPhieuMuonSachDTO
    Private Sub frmQuanLyPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPMS = New List(Of PhieuMuonSachDTO)
        listCT = New List(Of CTPhieuMuonSachDTO)
        ctSelected = New CTPhieuMuonSachDTO
        dgBUS = New DocGiaBUS

        sBUS = New SachBUS

        pmsBUS = New PhieuMuonSachBUS
        result = New Result
        ctBUS = New CTPhieuMuonSachBUS

        pmSelected = New PhieuMuonSachDTO

        load_dgvPMS()
    End Sub
    Private Sub load_dgvPMS()

        listPMS = Nothing
        listPMS = New List(Of PhieuMuonSachDTO)
        result = pmsBUS.selectAll(listPMS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListdg.SuspendLayout()
        dgvPhieuMuonSach.Columns.Clear()
        dgvPhieuMuonSach.DataSource = Nothing



        dgvPhieuMuonSach.AutoGenerateColumns = False
        dgvPhieuMuonSach.AllowUserToAddRows = False
        dgvPhieuMuonSach.DataSource = listPMS

        Dim clMaPMS = New DataGridViewTextBoxColumn()
        clMaPMS.Name = "MaPhieuMuonSach"
        clMaPMS.HeaderText = "Mã Phiếu Mượn"
        clMaPMS.DataPropertyName = "MaPhieuMuonSach"
        dgvPhieuMuonSach.Columns.Add(clMaPMS)


        Dim clMaDG = New DataGridViewTextBoxColumn()
        clMaDG.Name = "MaDocGia"
        clMaDG.HeaderText = "Mã Độc Gỉa"
        clMaDG.DataPropertyName = "MaDocGia"
        dgvPhieuMuonSach.Columns.Add(clMaDG)

        Dim clNgayMuon = New DataGridViewTextBoxColumn()
        clNgayMuon.Name = "NgayMuon"
        clNgayMuon.HeaderText = "Ngày Mượn"
        clNgayMuon.DataPropertyName = "NgayMuon"
        dgvPhieuMuonSach.Columns.Add(clNgayMuon)

        Dim clNgayToiHan = New DataGridViewTextBoxColumn()
        clNgayToiHan.Name = "NgayTra"
        clNgayToiHan.HeaderText = "Ngày Tới Hạn"
        clNgayToiHan.DataPropertyName = "NgayTra"
        dgvPhieuMuonSach.Columns.Add(clNgayToiHan)

        If (listPMS.Count = 0) Then
            pmSelected = New PhieuMuonSachDTO
            txtMaPhieuMuon.Text = String.Empty
            txtMaDocGia.Text = String.Empty
            dtpNgayMuon.Value = DateTime.Now
            dtpNgayToiHan.Value = DateTime.Now
        End If

    End Sub


    Private Sub dgvPhieuMuonSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPhieuMuonSach.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhieuMuonSach.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListDG.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhieuMuonSach.RowCount) Then
            Try
                pmSelected = CType(dgvPhieuMuonSach.Rows(currentRowIndex).DataBoundItem, PhieuMuonSachDTO)
                txtMaPhieuMuon.Text = pmSelected.MaPhieuMuonSach
                txtMaDocGia.Text = pmSelected.MaDocGia
                dtpNgayMuon.Value = pmSelected.NgayMuon
                dtpNgayToiHan.Value = pmSelected.NgayTra


                load_dgvCTPMSByMaPM()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Function load_dgvCTPMSByMaPM()
        listCT = Nothing
        listCT = New List(Of CTPhieuMuonSachDTO)

        result = ctBUS.selectAll_ByMaPM(txtMaPhieuMuon.Text, listCT)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Chi Tiết Phiếu Mượn Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return False
        End If

        'dgvListdg.SuspendLayout()
        dgvCTPhieuMuon.Columns.Clear()
        dgvCTPhieuMuon.DataSource = Nothing



        dgvCTPhieuMuon.AutoGenerateColumns = False
        dgvCTPhieuMuon.AllowUserToAddRows = False
        dgvCTPhieuMuon.DataSource = listCT

        Dim clMaPM = New DataGridViewTextBoxColumn()
        clMaPM.Name = "MaPhieuMuonSach"
        clMaPM.HeaderText = "Mã Phiếu Mượn"
        clMaPM.DataPropertyName = "MaPhieuMuonSach"
        dgvCTPhieuMuon.Columns.Add(clMaPM)


        Dim clMaCTPMS = New DataGridViewTextBoxColumn()
        clMaCTPMS.Name = "MaCTPhieuMuonSach"
        clMaCTPMS.HeaderText = "Mã Chi Tiết Phiếu"
        clMaCTPMS.DataPropertyName = "MaCTPhieuMuonSach"
        dgvCTPhieuMuon.Columns.Add(clMaCTPMS)



        Dim clMaSach = New DataGridViewTextBoxColumn()
        clMaSach.Name = "MaSach"
        clMaSach.HeaderText = "Mã Sách"
        clMaSach.DataPropertyName = "MaSach"
        dgvCTPhieuMuon.Columns.Add(clMaSach)

        Dim clGhiChu = New DataGridViewTextBoxColumn()
        clGhiChu.Name = "GhiChu"
        clGhiChu.HeaderText = "Ghi Chú"
        clGhiChu.DataPropertyName = "GhiChu"
        dgvCTPhieuMuon.Columns.Add(clGhiChu)

        If (listPMS.Count = 0) Then
            txtMaCTPhieuMuon.Text = String.Empty
            txtMaSach.Text = String.Empty
            txtGhiChu.Text = String.Empty

        End If

    End Function

    Private Sub dgvCTPhieuMuon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCTPhieuMuon.SelectionChanged
        Dim rowIndex As Integer = dgvCTPhieuMuon.CurrentCellAddress.Y 'current row selected

        If (-1 < rowIndex And rowIndex < dgvCTPhieuMuon.RowCount) Then
            Try

                ctSelected = CType(dgvCTPhieuMuon.Rows(rowIndex).DataBoundItem, CTPhieuMuonSachDTO)
                txtMaCTPhieuMuon.Text = ctSelected.MaCTPhieuMuonSach
                txtMaSach.Text = ctSelected.MaSach
                txtGhiChu.Text = ctSelected.GhiChu

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub btnCapNhatCT_Click(sender As Object, e As EventArgs) Handles btnCapNhatCT.Click

        If (pmSelected.MaPhieuMuonSach = String.Empty) Then
            MessageBox.Show("Không có phiếu mượn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim txtGhiChuPrevious = ctSelected.GhiChu


        ctSelected = New CTPhieuMuonSachDTO
        ctSelected.MaCTPhieuMuonSach = txtMaCTPhieuMuon.Text
        ctSelected.MaPhieuMuonSach = txtMaPhieuMuon.Text
        ctSelected.MaSach = txtMaSach.Text
        ctSelected.GhiChu = txtGhiChu.Text
        If (ctSelected.MaPhieuMuonSach = String.Empty) Then
            Return
        End If
        If (ctSelected.MaCTPhieuMuonSach = String.Empty) Then
            Return
        End If

        If (pmsBUS.checkSameText(txtGhiChuPrevious, ctSelected.GhiChu)) Then
            MessageBox.Show("Chưa có thông tin thay đổi. Ghi chú phải là: " + strGC_DangMuon + "," + strGC2_QuaHan + ", hoặc " + strGC3_TraTre, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If (pmsBUS.checkValidGhiChu(ctSelected.GhiChu, strGC_DangMuon, strGC3_TraTre, strGC2_QuaHan) = False) Then
            ctSelected.GhiChu = txtGhiChuPrevious
            MessageBox.Show("Ghi chú phải là: " + strGC_DangMuon + "," + strGC2_QuaHan + ", hoặc " + strGC3_TraTre, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        result = ctBUS.update(ctSelected)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật CT Phiếu Mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (ctSelected.GhiChu = Configuration.ConfigurationManager.AppSettings("DangMuon")) Then
                dgBUS.updateIncreaseNumberOfBook(pmSelected.MaDocGia)
                sBUS.update_TT(ctSelected.MaSach, "2")
            ElseIf (ctSelected.GhiChu = Configuration.ConfigurationManager.AppSettings("DaTra") Or ctSelected.GhiChu = Configuration.ConfigurationManager.AppSettings("QuaHan")) Then
                dgBUS.updateReduceNumberOfBook(pmSelected.MaDocGia)
                sBUS.update_TT(ctSelected.MaSach, "1")
            End If

            load_dgvCTPMSByMaPM()
        Else
            MessageBox.Show("Cập nhật CT Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnXoaCT_Click(sender As Object, e As EventArgs) Handles btnXoaCT.Click

        DeleteCT()
    End Sub

    Private Sub btnCapNhatPMS_Click(sender As Object, e As EventArgs) Handles btnCapNhatPMS.Click
        If (pmSelected.MaPhieuMuonSach = String.Empty) Then
            MessageBox.Show("Không có phiếu mượn sách.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        'genarate data
        pmSelected.MaPhieuMuonSach = txtMaPhieuMuon.Text
        pmSelected.MaDocGia = txtMaDocGia.Text
        pmSelected.NgayMuon = dtpNgayMuon.Value
        pmSelected.NgayTra = dtpNgayToiHan.Value

        If (pmsBUS.NTGreaterThanNM(pmSelected.NgayTra, pmSelected.NgayMuon) = False) Then
            MessageBox.Show("Ngày mượn phải lớn hơn ngày trả.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show((Convert.ToInt32(pmSelected.NgayTra.Subtract(pmSelected.NgayMuon).TotalDays)).ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        result = pmsBUS.update(pmSelected)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật Phiếu Mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_dgvPMS()
        Else
            MessageBox.Show("Cập nhật  Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If



        load_dgvPMS()

    End Sub

    Private Sub btnXoaPMS_Click(sender As Object, e As EventArgs) Handles btnXoaPMS.Click

        DeletePhieuMuon()

    End Sub

    Private Function DeleteCT()
        If (pmSelected.MaPhieuMuonSach = String.Empty) Then
            MessageBox.Show("Không có phiếu mượn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        result = ctBUS.delete(ctSelected.MaCTPhieuMuonSach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Xóa CT Phiếu Mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If (ctSelected.GhiChu = Configuration.ConfigurationManager.AppSettings("DangMuon")) Then
                dgBUS.updateReduceNumberOfBook(pmSelected.MaDocGia)
                sBUS.update_TT(ctSelected.MaSach, "1")
            End If

            load_dgvCTPMSByMaPM()
            Else
                MessageBox.Show("Xóat CT Phiếu Mượn không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        If (listCT.Count = 0) Then
            If (pmSelected.MaPhieuMuonSach = String.Empty) Then
                Return False
            End If

            delete_once_PM()
        End If

    End Function

    Private Function DeletePhieuMuon()

        If (pmSelected.MaPhieuMuonSach = String.Empty) Then
            MessageBox.Show("Không có phiếu mượn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' check list CTPMS and delete CT
        If listCT.Count > 0 Then
            Dim i As Integer
            For i = 0 To listCT.Count - 1
                DeleteCT()
            Next
        End If

        load_dgvPMS()

    End Function

    Private Function delete_once_PM()
        result = pmsBUS.delete(pmSelected.MaPhieuMuonSach)
        If (result.FlagResult = True) Then
            MessageBox.Show("Xóa Phiếu Mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_dgvPMS()
        Else
            MessageBox.Show("Xóa  Phiếu Mượn (_one) không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        load_dgvPMS()
    End Function
End Class