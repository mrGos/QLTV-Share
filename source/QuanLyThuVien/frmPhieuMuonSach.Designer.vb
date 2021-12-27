<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuMuonSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuMuonSach))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbbMaDocGia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaPhieuMuon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTenDocGia = New System.Windows.Forms.TextBox()
        Me.txtSoSachDangMuon = New System.Windows.Forms.TextBox()
        Me.txtTinhTrangThe = New System.Windows.Forms.TextBox()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayToiHan = New System.Windows.Forms.DateTimePicker()
        Me.btnAddSachDuocMuon = New System.Windows.Forms.Button()
        Me.btnRmvSachMuonMuon = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstSachDuocMuon = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstSachMuonMuon = New System.Windows.Forms.ListBox()
        Me.dtbNgayMuon = New System.Windows.Forms.GroupBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvQuanLySach = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.dtbNgayMuon.SuspendLayout()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã độc giả:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tên độc giả:"
        '
        'cbbMaDocGia
        '
        Me.cbbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMaDocGia.FormattingEnabled = True
        Me.cbbMaDocGia.Location = New System.Drawing.Point(176, 83)
        Me.cbbMaDocGia.Name = "cbbMaDocGia"
        Me.cbbMaDocGia.Size = New System.Drawing.Size(178, 24)
        Me.cbbMaDocGia.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(608, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ngày mượn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã phiếu mượn:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngày tới hạn:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(608, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Số lượng sách đang mượn:"
        '
        'txtMaPhieuMuon
        '
        Me.txtMaPhieuMuon.Enabled = False
        Me.txtMaPhieuMuon.Location = New System.Drawing.Point(176, 37)
        Me.txtMaPhieuMuon.Name = "txtMaPhieuMuon"
        Me.txtMaPhieuMuon.Size = New System.Drawing.Size(178, 22)
        Me.txtMaPhieuMuon.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tình trạng thẻ ĐG:"
        '
        'txtTenDocGia
        '
        Me.txtTenDocGia.Enabled = False
        Me.txtTenDocGia.Location = New System.Drawing.Point(176, 121)
        Me.txtTenDocGia.Name = "txtTenDocGia"
        Me.txtTenDocGia.Size = New System.Drawing.Size(178, 22)
        Me.txtTenDocGia.TabIndex = 2
        '
        'txtSoSachDangMuon
        '
        Me.txtSoSachDangMuon.Enabled = False
        Me.txtSoSachDangMuon.Location = New System.Drawing.Point(801, 123)
        Me.txtSoSachDangMuon.Name = "txtSoSachDangMuon"
        Me.txtSoSachDangMuon.Size = New System.Drawing.Size(178, 22)
        Me.txtSoSachDangMuon.TabIndex = 2
        '
        'txtTinhTrangThe
        '
        Me.txtTinhTrangThe.Enabled = False
        Me.txtTinhTrangThe.Location = New System.Drawing.Point(176, 173)
        Me.txtTinhTrangThe.Name = "txtTinhTrangThe"
        Me.txtTinhTrangThe.Size = New System.Drawing.Size(178, 22)
        Me.txtTinhTrangThe.TabIndex = 2
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayMuon.Location = New System.Drawing.Point(802, 32)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(178, 22)
        Me.dtpNgayMuon.TabIndex = 3
        '
        'dtpNgayToiHan
        '
        Me.dtpNgayToiHan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayToiHan.Location = New System.Drawing.Point(802, 77)
        Me.dtpNgayToiHan.Name = "dtpNgayToiHan"
        Me.dtpNgayToiHan.Size = New System.Drawing.Size(178, 22)
        Me.dtpNgayToiHan.TabIndex = 3
        '
        'btnAddSachDuocMuon
        '
        Me.btnAddSachDuocMuon.BackColor = System.Drawing.Color.LightCyan
        Me.btnAddSachDuocMuon.Image = CType(resources.GetObject("btnAddSachDuocMuon.Image"), System.Drawing.Image)
        Me.btnAddSachDuocMuon.Location = New System.Drawing.Point(491, 288)
        Me.btnAddSachDuocMuon.Name = "btnAddSachDuocMuon"
        Me.btnAddSachDuocMuon.Size = New System.Drawing.Size(92, 42)
        Me.btnAddSachDuocMuon.TabIndex = 5
        Me.btnAddSachDuocMuon.UseVisualStyleBackColor = False
        '
        'btnRmvSachMuonMuon
        '
        Me.btnRmvSachMuonMuon.BackColor = System.Drawing.Color.LightCyan
        Me.btnRmvSachMuonMuon.Image = CType(resources.GetObject("btnRmvSachMuonMuon.Image"), System.Drawing.Image)
        Me.btnRmvSachMuonMuon.Location = New System.Drawing.Point(491, 361)
        Me.btnRmvSachMuonMuon.Name = "btnRmvSachMuonMuon"
        Me.btnRmvSachMuonMuon.Size = New System.Drawing.Size(92, 40)
        Me.btnRmvSachMuonMuon.TabIndex = 5
        Me.btnRmvSachMuonMuon.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.lstSachDuocMuon)
        Me.Panel3.Location = New System.Drawing.Point(71, 226)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 204)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 41)
        Me.Panel1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(130, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sách Được Mượn"
        '
        'lstSachDuocMuon
        '
        Me.lstSachDuocMuon.FormattingEnabled = True
        Me.lstSachDuocMuon.ItemHeight = 16
        Me.lstSachDuocMuon.Location = New System.Drawing.Point(0, 40)
        Me.lstSachDuocMuon.Name = "lstSachDuocMuon"
        Me.lstSachDuocMuon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSachDuocMuon.Size = New System.Drawing.Size(376, 164)
        Me.lstSachDuocMuon.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.lstSachMuonMuon)
        Me.Panel4.Location = New System.Drawing.Point(617, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 204)
        Me.Panel4.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 41)
        Me.Panel2.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(137, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sách Muốn Mượn:"
        '
        'lstSachMuonMuon
        '
        Me.lstSachMuonMuon.FormattingEnabled = True
        Me.lstSachMuonMuon.ItemHeight = 16
        Me.lstSachMuonMuon.Location = New System.Drawing.Point(0, 40)
        Me.lstSachMuonMuon.Name = "lstSachMuonMuon"
        Me.lstSachMuonMuon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSachMuonMuon.Size = New System.Drawing.Size(376, 164)
        Me.lstSachMuonMuon.TabIndex = 4
        '
        'dtbNgayMuon
        '
        Me.dtbNgayMuon.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.dtbNgayMuon.Controls.Add(Me.Panel4)
        Me.dtbNgayMuon.Controls.Add(Me.Panel3)
        Me.dtbNgayMuon.Controls.Add(Me.btnRmvSachMuonMuon)
        Me.dtbNgayMuon.Controls.Add(Me.btnAddSachDuocMuon)
        Me.dtbNgayMuon.Controls.Add(Me.txtGhiChu)
        Me.dtbNgayMuon.Controls.Add(Me.Label11)
        Me.dtbNgayMuon.Controls.Add(Me.dtpNgayToiHan)
        Me.dtbNgayMuon.Controls.Add(Me.dtpNgayMuon)
        Me.dtbNgayMuon.Controls.Add(Me.txtTinhTrangThe)
        Me.dtbNgayMuon.Controls.Add(Me.txtSoSachDangMuon)
        Me.dtbNgayMuon.Controls.Add(Me.txtTenDocGia)
        Me.dtbNgayMuon.Controls.Add(Me.Label10)
        Me.dtbNgayMuon.Controls.Add(Me.txtMaPhieuMuon)
        Me.dtbNgayMuon.Controls.Add(Me.Label6)
        Me.dtbNgayMuon.Controls.Add(Me.Label5)
        Me.dtbNgayMuon.Controls.Add(Me.Label2)
        Me.dtbNgayMuon.Controls.Add(Me.Label4)
        Me.dtbNgayMuon.Controls.Add(Me.cbbMaDocGia)
        Me.dtbNgayMuon.Controls.Add(Me.Label7)
        Me.dtbNgayMuon.Controls.Add(Me.Label1)
        Me.dtbNgayMuon.Location = New System.Drawing.Point(70, 72)
        Me.dtbNgayMuon.Name = "dtbNgayMuon"
        Me.dtbNgayMuon.Size = New System.Drawing.Size(1028, 449)
        Me.dtbNgayMuon.TabIndex = 0
        Me.dtbNgayMuon.TabStop = False
        Me.dtbNgayMuon.Text = "Thông tin mượn sách:"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Enabled = False
        Me.txtGhiChu.Location = New System.Drawing.Point(801, 170)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(178, 22)
        Me.txtGhiChu.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(608, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ghi chú phiếu mượn:"
        '
        'dgvQuanLySach
        '
        Me.dgvQuanLySach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuanLySach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvQuanLySach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvQuanLySach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLySach.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvQuanLySach.Location = New System.Drawing.Point(70, 562)
        Me.dgvQuanLySach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvQuanLySach.MultiSelect = False
        Me.dgvQuanLySach.Name = "dgvQuanLySach"
        Me.dgvQuanLySach.ReadOnly = True
        Me.dgvQuanLySach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvQuanLySach.RowHeadersVisible = False
        Me.dgvQuanLySach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvQuanLySach.RowTemplate.ReadOnly = True
        Me.dgvQuanLySach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQuanLySach.Size = New System.Drawing.Size(1028, 185)
        Me.dgvQuanLySach.TabIndex = 30
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Snow
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(806, 774)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(292, 62)
        Me.btnThem.TabIndex = 31
        Me.btnThem.Text = "Cho Mượn"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(70, 774)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(292, 62)
        Me.btnThoat.TabIndex = 31
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(425, 9)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(337, 35)
        Me.lblTieuDe.TabIndex = 40
        Me.lblTieuDe.Text = "Lập Phiếu Mượn Sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 541)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hiển thị danh sách Sách"
        '
        'frmPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1167, 874)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvQuanLySach)
        Me.Controls.Add(Me.dtbNgayMuon)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPhieuMuonSach"
        Me.Text = "Lập phiếu mượn sách"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.dtbNgayMuon.ResumeLayout(False)
        Me.dtbNgayMuon.PerformLayout()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbbMaDocGia As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaPhieuMuon As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTenDocGia As TextBox
    Friend WithEvents txtSoSachDangMuon As TextBox
    Friend WithEvents txtTinhTrangThe As TextBox
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents dtpNgayToiHan As DateTimePicker
    Friend WithEvents btnAddSachDuocMuon As Button
    Friend WithEvents btnRmvSachMuonMuon As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lstSachDuocMuon As ListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lstSachMuonMuon As ListBox
    Friend WithEvents dtbNgayMuon As GroupBox
    Friend WithEvents dgvQuanLySach As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents Label3 As Label
End Class
