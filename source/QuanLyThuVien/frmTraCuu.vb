Imports QLTV_DTO
Imports QLTV_BUS
Imports Utility

Public Class frmTraCuu
    Private tableSach As DataTable
    Private tableDocGia As DataTable
    Private tablePhieuMuonSach As DataTable

    Private dgBus As DocGiaBUS
    Private sBUS As SachBUS
    Private pmsBUS As PhieuMuonSachBUS

    Private Sub loadListDocGia()
        Dim result As Result
        result = dgBus.selectAll(tableDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        With dgvListDG
            .DataSource = Nothing
            .AllowUserToAddRows = False
            .DataSource = New BindingSource(tableDocGia, String.Empty)
            .ColumnHeadersVisible = True
            .ColumnHeadersVisible = True
            .Columns(0).HeaderText = "Mã độc giả"
            .Columns(1).HeaderText = "Họ tên"
            .Columns(2).HeaderText = "Loại độc giả"
            .Columns(3).HeaderText = "Ngày sinh"
            .Columns(4).HeaderText = "Địa chỉ"
            .Columns(5).HeaderText = "Email"
            .Columns(6).HeaderText = "Ngày Lập thẻ"
            .Columns(7).HeaderText = "Ngày hết hạn"
            .Columns(8).HeaderText = "Tình trạng thẻ"
        End With

    End Sub

    Private Sub loadDgvQuanLySach()
        Dim result As Result
        result = sBUS.selectAll(tableSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        With dgvQuanLySach
            .DataSource = Nothing
            .AllowUserToAddRows = False
            .DataSource = New BindingSource(tableSach, String.Empty)
            .ColumnHeadersVisible = True
            .Columns(0).HeaderText = "Mã sách"
            .Columns(1).HeaderText = "Tên sách"
            .Columns(2).HeaderText = "Loại sách"
            .Columns(3).HeaderText = "Nhà Xuất bản"
            .Columns(4).HeaderText = "Tác giả"
            .Columns(5).HeaderText = "Năm xuất bản"
            .Columns(6).HeaderText = "Ngày Nhập"
            .Columns(7).HeaderText = "Trị giá"
            .Columns(8).HeaderText = "Tình trạng sách"
        End With

    End Sub

    Private Sub loaddgvPhieuMuon()

        Dim result As Result
        result = pmsBUS.selectAllForTraCuu(tablePhieuMuonSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        With dgvPhieuMuon
            .DataSource = Nothing
            .AllowUserToAddRows = False
            .DataSource = New BindingSource(tablePhieuMuonSach, String.Empty)
            .ColumnHeadersVisible = True
            .Columns(0).HeaderText = "Mã Phiếu mượn"
            .Columns(1).HeaderText = "Họ tên"
            .Columns(2).HeaderText = "Tên sách"
            .Columns(3).HeaderText = "Tên loại sách"
            .Columns(4).HeaderText = "Tên tác giả"
            .Columns(5).HeaderText = "Ngày mượn"
            .Columns(6).HeaderText = "Ghi chú"
        End With
    End Sub

    Private Sub frmTraCuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New DocGiaBUS()
        sBUS = New SachBUS()
        pmsBUS = New PhieuMuonSachBUS()
        tableDocGia = New DataTable()
        tableSach = New DataTable()
        tablePhieuMuonSach = New DataTable()

        'Load cbThuocTinhDG
        Dim tb_TimKiemDG As DataTable
        tb_TimKiemDG = New DataTable("Tìm Kiếm DG")
        With tb_TimKiemDG
            .Columns.Add("onDB", GetType(String))
            .Columns.Add("OnDp", GetType(String))
            .Rows.Add("madocgia", "Mã Đôc Giả")
            .Rows.Add("hoten", "Họ tên")
            .Rows.Add("maloaidocgia", "Loại Độc Giả")
            .Rows.Add("diachi", "Địa Chỉ")
            .Rows.Add("email", "Email")
        End With

        With cbThuocTinhDG
            .DataSource = New BindingSource(tb_TimKiemDG, String.Empty)
            .DisplayMember = "OnDp"
            .ValueMember = "onDB"
        End With

        'Load cbThuocTinhSach
        Dim tb_TimKiemSach As DataTable
        tb_TimKiemSach = New DataTable("Tìm Kiếm Sách")
        With tb_TimKiemSach
            .Columns.Add("onDB", GetType(String))
            .Columns.Add("OnDp", GetType(String))
            .Rows.Add("masach", "Mã sách")
            .Rows.Add("tensach", "Tên sách")
            .Rows.Add("tenloaisach", "Loại sách")
            .Rows.Add("tentacgia", "Tên tác giả")
            .Rows.Add("tennhaxuatban", "Nhà xuất bản")
        End With

        With cbThuocTinhSach
            .DataSource = New BindingSource(tb_TimKiemSach, String.Empty)
            .DisplayMember = "OnDp"
            .ValueMember = "onDB"
        End With

        'Load cbThuocTinhPhieuMuon
        Dim tb_TimKiemPhieu As DataTable
        tb_TimKiemPhieu = New DataTable("Tìm Kiếm Phiếu")
        With tb_TimKiemPhieu
            .Columns.Add("onDB", GetType(String))
            .Columns.Add("OnDp", GetType(String))
            .Rows.Add("maphieumuonsach", "Mã Phiếu Mượn")
            .Rows.Add("hoten", "Họ tên")
            .Rows.Add("tensach", "Tên sách")
            .Rows.Add("tenloaisach", "Loại sách")
            .Rows.Add("tentacgia", "Tên tác giả")
            .Rows.Add("ghichu", "Ghi chú")
        End With

        With cbThuocTinhPhieuMuon
            .DataSource = New BindingSource(tb_TimKiemPhieu, String.Empty)
            .DisplayMember = "OnDp"
            .ValueMember = "onDB"
        End With
        With cbThuocTinhSort
            .DataSource = New BindingSource(tb_TimKiemPhieu, String.Empty)
            .DisplayMember = "OnDp"
            .ValueMember = "onDB"
        End With

        loadListDocGia()
        loadDgvQuanLySach()
        loaddgvPhieuMuon()
    End Sub

    Private Sub txtBoxDGFilter_TextChanged(sender As Object, e As EventArgs) Handles txtBoxDGFilter.TextChanged
        Dim searchDG As New DataView(tableDocGia)
        Dim sStr = cbThuocTinhDG.SelectedValue + " Like '%{0}%'"
        searchDG.RowFilter = String.Format(sStr, txtBoxDGFilter.Text.ToString)
        dgvListDG.DataSource = searchDG.ToTable()
    End Sub

    Private Sub txtBoxSachFilter_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSachFilter.TextChanged
        Dim searchSach As New DataView(tableSach)
        Dim sStr = cbThuocTinhSach.SelectedValue + " Like '%{0}%'"
        searchSach.RowFilter = String.Format(sStr, txtBoxSachFilter.Text.ToString)
        dgvQuanLySach.DataSource = searchSach
    End Sub

    Private Sub dgvQuanLySach_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvQuanLySach.RowPostPaint
        Dim b As SolidBrush
        b = New SolidBrush(dgvQuanLySach.RowHeadersDefaultCellStyle.ForeColor)
        Using (b)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub dgvListDG_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvListDG.RowPostPaint
        Dim b As SolidBrush
        b = New SolidBrush(dgvListDG.RowHeadersDefaultCellStyle.ForeColor)
        Using (b)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub btnRefreshDocGia_Click(sender As Object, e As EventArgs) Handles btnRefreshDocGia.Click
        txtBoxDGFilter.Text = String.Empty
    End Sub

    Private Sub btnRefreshSach_Click(sender As Object, e As EventArgs) Handles btnRefreshSach.Click
        txtBoxSachFilter.Text = String.Empty
    End Sub

    Private Sub dgvPhieuMuon_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvPhieuMuon.RowPostPaint
        Dim b As SolidBrush
        b = New SolidBrush(dgvPhieuMuon.RowHeadersDefaultCellStyle.ForeColor)
        Using (b)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub txtBoxPhieuMuonFilter_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPhieuMuonFilter.TextChanged
        searchPhieuMuon()
    End Sub

    Private Sub cbThuocTinhSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThuocTinhSort.SelectedIndexChanged
        searchPhieuMuon()
    End Sub

    Private Sub searchPhieuMuon()
        If txtBoxPhieuMuonFilter.Text Is String.Empty Then
            loaddgvPhieuMuon()
            Return
        End If
        Dim searchPhieu As New DataView(tablePhieuMuonSach)
        Dim sStr = cbThuocTinhPhieuMuon.SelectedValue + " Like '%{0}%' "
        searchPhieu.RowFilter = String.Format(sStr, txtBoxPhieuMuonFilter.Text.ToString)
        searchPhieu.Sort = cbThuocTinhSort.SelectedValue
        dgvPhieuMuon.DataSource = searchPhieu.ToTable()
    End Sub

    Private Sub btnRefreshPhieu_Click(sender As Object, e As EventArgs) Handles btnRefreshPhieu.Click
        txtBoxPhieuMuonFilter.Text = String.Empty
        cbThuocTinhPhieuMuon.SelectedItem = 0
        cbThuocTinhSort.SelectedItem = 0
    End Sub
End Class