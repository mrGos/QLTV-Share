<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyPhieuMuonSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyPhieuMuonSach))
        Me.dgvCTPhieuMuon = New System.Windows.Forms.DataGridView()
        Me.gbThongTinDocGia = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaPhieuMuon = New System.Windows.Forms.TextBox()
        Me.txtMaDocGia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayToiHan = New System.Windows.Forms.DateTimePicker()
        Me.dgvPhieuMuonSach = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaCTPhieuMuon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoaCT = New System.Windows.Forms.Button()
        Me.btnCapNhatCT = New System.Windows.Forms.Button()
        Me.btnXoaPMS = New System.Windows.Forms.Button()
        Me.btnCapNhatPMS = New System.Windows.Forms.Button()
        CType(Me.dgvCTPhieuMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbThongTinDocGia.SuspendLayout()
        CType(Me.dgvPhieuMuonSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCTPhieuMuon
        '
        Me.dgvCTPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCTPhieuMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvCTPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCTPhieuMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCTPhieuMuon.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvCTPhieuMuon.Location = New System.Drawing.Point(3, 18)
        Me.dgvCTPhieuMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCTPhieuMuon.MultiSelect = False
        Me.dgvCTPhieuMuon.Name = "dgvCTPhieuMuon"
        Me.dgvCTPhieuMuon.ReadOnly = True
        Me.dgvCTPhieuMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCTPhieuMuon.RowHeadersVisible = False
        Me.dgvCTPhieuMuon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCTPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCTPhieuMuon.Size = New System.Drawing.Size(466, 303)
        Me.dgvCTPhieuMuon.TabIndex = 5
        '
        'gbThongTinDocGia
        '
        Me.gbThongTinDocGia.BackColor = System.Drawing.Color.MediumVioletRed
        Me.gbThongTinDocGia.Controls.Add(Me.btnXoaPMS)
        Me.gbThongTinDocGia.Controls.Add(Me.Label6)
        Me.gbThongTinDocGia.Controls.Add(Me.btnCapNhatPMS)
        Me.gbThongTinDocGia.Controls.Add(Me.txtMaPhieuMuon)
        Me.gbThongTinDocGia.Controls.Add(Me.txtMaDocGia)
        Me.gbThongTinDocGia.Controls.Add(Me.Label2)
        Me.gbThongTinDocGia.Controls.Add(Me.Label4)
        Me.gbThongTinDocGia.Controls.Add(Me.Label3)
        Me.gbThongTinDocGia.Controls.Add(Me.dtpNgayMuon)
        Me.gbThongTinDocGia.Controls.Add(Me.dtpNgayToiHan)
        Me.gbThongTinDocGia.Location = New System.Drawing.Point(62, 100)
        Me.gbThongTinDocGia.Name = "gbThongTinDocGia"
        Me.gbThongTinDocGia.Size = New System.Drawing.Size(429, 324)
        Me.gbThongTinDocGia.TabIndex = 6
        Me.gbThongTinDocGia.TabStop = False
        Me.gbThongTinDocGia.Text = "Thông tin Phiếu mượn sách"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 89)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Mã độc giả:"
        '
        'txtMaPhieuMuon
        '
        Me.txtMaPhieuMuon.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaPhieuMuon.Enabled = False
        Me.txtMaPhieuMuon.Location = New System.Drawing.Point(194, 43)
        Me.txtMaPhieuMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaPhieuMuon.Name = "txtMaPhieuMuon"
        Me.txtMaPhieuMuon.Size = New System.Drawing.Size(159, 22)
        Me.txtMaPhieuMuon.TabIndex = 39
        '
        'txtMaDocGia
        '
        Me.txtMaDocGia.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaDocGia.Enabled = False
        Me.txtMaDocGia.Location = New System.Drawing.Point(194, 89)
        Me.txtMaDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaDocGia.Name = "txtMaDocGia"
        Me.txtMaDocGia.Size = New System.Drawing.Size(159, 22)
        Me.txtMaDocGia.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Ngày Mượn:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Ngày Tới Hạn:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Mã Phiếu Mượn:"
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.CustomFormat = ""
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayMuon.Location = New System.Drawing.Point(195, 143)
        Me.dtpNgayMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(158, 22)
        Me.dtpNgayMuon.TabIndex = 47
        Me.dtpNgayMuon.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'dtpNgayToiHan
        '
        Me.dtpNgayToiHan.CustomFormat = ""
        Me.dtpNgayToiHan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayToiHan.Location = New System.Drawing.Point(195, 198)
        Me.dtpNgayToiHan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayToiHan.Name = "dtpNgayToiHan"
        Me.dtpNgayToiHan.Size = New System.Drawing.Size(158, 22)
        Me.dtpNgayToiHan.TabIndex = 47
        Me.dtpNgayToiHan.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'dgvPhieuMuonSach
        '
        Me.dgvPhieuMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPhieuMuonSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvPhieuMuonSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPhieuMuonSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuMuonSach.Location = New System.Drawing.Point(62, 457)
        Me.dgvPhieuMuonSach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPhieuMuonSach.MultiSelect = False
        Me.dgvPhieuMuonSach.Name = "dgvPhieuMuonSach"
        Me.dgvPhieuMuonSach.ReadOnly = True
        Me.dgvPhieuMuonSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPhieuMuonSach.RowHeadersVisible = False
        Me.dgvPhieuMuonSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPhieuMuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhieuMuonSach.Size = New System.Drawing.Size(1288, 227)
        Me.dgvPhieuMuonSach.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtGhiChu)
        Me.GroupBox1.Controls.Add(Me.btnXoaCT)
        Me.GroupBox1.Controls.Add(Me.btnCapNhatCT)
        Me.GroupBox1.Controls.Add(Me.txtMaSach)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMaCTPhieuMuon)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dgvCTPhieuMuon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(524, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 324)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin chi tiết phiếu mượn"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(618, 116)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(178, 104)
        Me.txtGhiChu.TabIndex = 46
        '
        'txtMaSach
        '
        Me.txtMaSach.Enabled = False
        Me.txtMaSach.Location = New System.Drawing.Point(618, 63)
        Me.txtMaSach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(178, 22)
        Me.txtMaSach.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 122)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Ghi Chú:"
        '
        'txtMaCTPhieuMuon
        '
        Me.txtMaCTPhieuMuon.Enabled = False
        Me.txtMaCTPhieuMuon.Location = New System.Drawing.Point(618, 22)
        Me.txtMaCTPhieuMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaCTPhieuMuon.Name = "txtMaCTPhieuMuon"
        Me.txtMaCTPhieuMuon.ReadOnly = True
        Me.txtMaCTPhieuMuon.Size = New System.Drawing.Size(178, 22)
        Me.txtMaCTPhieuMuon.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(477, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Mã sách:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Mã CT Phiếu Mượn:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(521, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(407, 35)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quản Lý Phiếu Mượn Sách"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(62, 719)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(180, 54)
        Me.btnThoat.TabIndex = 43
        Me.btnThoat.Text = " Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnXoaCT
        '
        Me.btnXoaCT.BackColor = System.Drawing.Color.Snow
        Me.btnXoaCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoaCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCT.ForeColor = System.Drawing.Color.IndianRed
        Me.btnXoaCT.Image = CType(resources.GetObject("btnXoaCT.Image"), System.Drawing.Image)
        Me.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaCT.Location = New System.Drawing.Point(679, 262)
        Me.btnXoaCT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoaCT.Name = "btnXoaCT"
        Me.btnXoaCT.Size = New System.Drawing.Size(140, 48)
        Me.btnXoaCT.TabIndex = 45
        Me.btnXoaCT.Text = "   Xóa"
        Me.btnXoaCT.UseVisualStyleBackColor = False
        '
        'btnCapNhatCT
        '
        Me.btnCapNhatCT.BackColor = System.Drawing.Color.Snow
        Me.btnCapNhatCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCapNhatCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhatCT.ForeColor = System.Drawing.Color.IndianRed
        Me.btnCapNhatCT.Image = CType(resources.GetObject("btnCapNhatCT.Image"), System.Drawing.Image)
        Me.btnCapNhatCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapNhatCT.Location = New System.Drawing.Point(484, 260)
        Me.btnCapNhatCT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhatCT.Name = "btnCapNhatCT"
        Me.btnCapNhatCT.Size = New System.Drawing.Size(151, 50)
        Me.btnCapNhatCT.TabIndex = 44
        Me.btnCapNhatCT.Text = "       Cập Nhật"
        Me.btnCapNhatCT.UseVisualStyleBackColor = False
        '
        'btnXoaPMS
        '
        Me.btnXoaPMS.BackColor = System.Drawing.Color.Snow
        Me.btnXoaPMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoaPMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaPMS.ForeColor = System.Drawing.Color.IndianRed
        Me.btnXoaPMS.Image = CType(resources.GetObject("btnXoaPMS.Image"), System.Drawing.Image)
        Me.btnXoaPMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoaPMS.Location = New System.Drawing.Point(254, 258)
        Me.btnXoaPMS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoaPMS.Name = "btnXoaPMS"
        Me.btnXoaPMS.Size = New System.Drawing.Size(140, 48)
        Me.btnXoaPMS.TabIndex = 45
        Me.btnXoaPMS.Text = "   Xóa"
        Me.btnXoaPMS.UseVisualStyleBackColor = False
        '
        'btnCapNhatPMS
        '
        Me.btnCapNhatPMS.BackColor = System.Drawing.Color.Snow
        Me.btnCapNhatPMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCapNhatPMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhatPMS.ForeColor = System.Drawing.Color.IndianRed
        Me.btnCapNhatPMS.Image = CType(resources.GetObject("btnCapNhatPMS.Image"), System.Drawing.Image)
        Me.btnCapNhatPMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapNhatPMS.Location = New System.Drawing.Point(59, 258)
        Me.btnCapNhatPMS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhatPMS.Name = "btnCapNhatPMS"
        Me.btnCapNhatPMS.Size = New System.Drawing.Size(151, 48)
        Me.btnCapNhatPMS.TabIndex = 44
        Me.btnCapNhatPMS.Text = "       Cập Nhật"
        Me.btnCapNhatPMS.UseVisualStyleBackColor = False
        '
        'frmQuanLyPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1419, 799)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbThongTinDocGia)
        Me.Controls.Add(Me.dgvPhieuMuonSach)
        Me.Name = "frmQuanLyPhieuMuonSach"
        Me.Text = "Quản lý phiếu mượn sách"
        CType(Me.dgvCTPhieuMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbThongTinDocGia.ResumeLayout(False)
        Me.gbThongTinDocGia.PerformLayout()
        CType(Me.dgvPhieuMuonSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCTPhieuMuon As DataGridView
    Friend WithEvents gbThongTinDocGia As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaDocGia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNgayToiHan As DateTimePicker
    Friend WithEvents dgvPhieuMuonSach As DataGridView
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMaCTPhieuMuon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaPhieuMuon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoaPMS As Button
    Friend WithEvents btnCapNhatPMS As Button
    Friend WithEvents btnXoaCT As Button
    Friend WithEvents btnCapNhatCT As Button
    Friend WithEvents txtGhiChu As TextBox
End Class
