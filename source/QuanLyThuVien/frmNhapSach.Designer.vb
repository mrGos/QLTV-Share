<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhapSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhapSach))
        Me.buttonTimKiem = New System.Windows.Forms.Button()
        Me.btnTaoMoi = New System.Windows.Forms.Button()
        Me.buttonThoat = New System.Windows.Forms.Button()
        Me.buttonCapNhap = New System.Windows.Forms.Button()
        Me.buttonXoaHet = New System.Windows.Forms.Button()
        Me.buttonRefresh = New System.Windows.Forms.Button()
        Me.groupBoxThongTinSach = New System.Windows.Forms.GroupBox()
        Me.cbbTinhTrangSach = New System.Windows.Forms.ComboBox()
        Me.labelNamXuanBan = New System.Windows.Forms.Label()
        Me.dtpNamXuatBan = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxTacGia = New System.Windows.Forms.ComboBox()
        Me.blTinhTrangSach = New System.Windows.Forms.Label()
        Me.textBoxTriGia = New System.Windows.Forms.TextBox()
        Me.labelTriGia = New System.Windows.Forms.Label()
        Me.labelNgayNhap = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.comboBoxNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.labelNhaXuatBan = New System.Windows.Forms.Label()
        Me.labelTenTacGia = New System.Windows.Forms.Label()
        Me.comboBoxLoaiSach = New System.Windows.Forms.ComboBox()
        Me.labelLoaiSach = New System.Windows.Forms.Label()
        Me.textBoxTenSach = New System.Windows.Forms.TextBox()
        Me.labelTenSach = New System.Windows.Forms.Label()
        Me.textBoxMaSach = New System.Windows.Forms.TextBox()
        Me.labelMaSach = New System.Windows.Forms.Label()
        Me.buttonThemSach = New System.Windows.Forms.Button()
        Me.dgvQuanLySach = New System.Windows.Forms.DataGridView()
        Me.textBoxTimKiem = New System.Windows.Forms.TextBox()
        Me.comboBoxTimKiem = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBoxThongTinSach.SuspendLayout()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonTimKiem
        '
        Me.buttonTimKiem.BackColor = System.Drawing.Color.Snow
        Me.buttonTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonTimKiem.ForeColor = System.Drawing.Color.IndianRed
        Me.buttonTimKiem.Image = CType(resources.GetObject("buttonTimKiem.Image"), System.Drawing.Image)
        Me.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonTimKiem.Location = New System.Drawing.Point(571, 22)
        Me.buttonTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonTimKiem.Name = "buttonTimKiem"
        Me.buttonTimKiem.Size = New System.Drawing.Size(100, 42)
        Me.buttonTimKiem.TabIndex = 38
        Me.buttonTimKiem.Text = "     Tìm Kiếm"
        Me.buttonTimKiem.UseVisualStyleBackColor = False
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.BackColor = System.Drawing.Color.Snow
        Me.btnTaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTaoMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaoMoi.ForeColor = System.Drawing.Color.IndianRed
        Me.btnTaoMoi.Image = CType(resources.GetObject("btnTaoMoi.Image"), System.Drawing.Image)
        Me.btnTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTaoMoi.Location = New System.Drawing.Point(803, 673)
        Me.btnTaoMoi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(130, 54)
        Me.btnTaoMoi.TabIndex = 37
        Me.btnTaoMoi.Text = "        Tạo Mới"
        Me.btnTaoMoi.UseVisualStyleBackColor = False
        '
        'buttonThoat
        '
        Me.buttonThoat.BackColor = System.Drawing.Color.Snow
        Me.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.buttonThoat.Image = CType(resources.GetObject("buttonThoat.Image"), System.Drawing.Image)
        Me.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonThoat.Location = New System.Drawing.Point(57, 673)
        Me.buttonThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonThoat.Name = "buttonThoat"
        Me.buttonThoat.Size = New System.Drawing.Size(148, 52)
        Me.buttonThoat.TabIndex = 35
        Me.buttonThoat.Text = "Thoát"
        Me.buttonThoat.UseVisualStyleBackColor = False
        '
        'buttonCapNhap
        '
        Me.buttonCapNhap.BackColor = System.Drawing.Color.Snow
        Me.buttonCapNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonCapNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCapNhap.ForeColor = System.Drawing.Color.IndianRed
        Me.buttonCapNhap.Image = CType(resources.GetObject("buttonCapNhap.Image"), System.Drawing.Image)
        Me.buttonCapNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCapNhap.Location = New System.Drawing.Point(1087, 673)
        Me.buttonCapNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCapNhap.Name = "buttonCapNhap"
        Me.buttonCapNhap.Size = New System.Drawing.Size(141, 54)
        Me.buttonCapNhap.TabIndex = 34
        Me.buttonCapNhap.Text = "       Cập Nhật"
        Me.buttonCapNhap.UseVisualStyleBackColor = False
        '
        'buttonXoaHet
        '
        Me.buttonXoaHet.BackColor = System.Drawing.Color.Snow
        Me.buttonXoaHet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonXoaHet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonXoaHet.ForeColor = System.Drawing.Color.IndianRed
        Me.buttonXoaHet.Image = CType(resources.GetObject("buttonXoaHet.Image"), System.Drawing.Image)
        Me.buttonXoaHet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonXoaHet.Location = New System.Drawing.Point(609, 673)
        Me.buttonXoaHet.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonXoaHet.Name = "buttonXoaHet"
        Me.buttonXoaHet.Size = New System.Drawing.Size(158, 52)
        Me.buttonXoaHet.TabIndex = 33
        Me.buttonXoaHet.Text = "     Xóa Hết"
        Me.buttonXoaHet.UseVisualStyleBackColor = False
        '
        'buttonRefresh
        '
        Me.buttonRefresh.BackColor = System.Drawing.Color.Snow
        Me.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRefresh.ForeColor = System.Drawing.Color.IndianRed
        Me.buttonRefresh.Image = CType(resources.GetObject("buttonRefresh.Image"), System.Drawing.Image)
        Me.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonRefresh.Location = New System.Drawing.Point(342, 673)
        Me.buttonRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Size = New System.Drawing.Size(157, 52)
        Me.buttonRefresh.TabIndex = 32
        Me.buttonRefresh.Text = "    Tải Lại"
        Me.buttonRefresh.UseVisualStyleBackColor = False
        '
        'groupBoxThongTinSach
        '
        Me.groupBoxThongTinSach.BackColor = System.Drawing.Color.MediumVioletRed
        Me.groupBoxThongTinSach.Controls.Add(Me.cbbTinhTrangSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNamXuanBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.dtpNamXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxTacGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.blTinhTrangSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTriGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTriGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNgayNhap)
        Me.groupBoxThongTinSach.Controls.Add(Me.dtpNgayNhap)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxNhaXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelNhaXuatBan)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTenTacGia)
        Me.groupBoxThongTinSach.Controls.Add(Me.comboBoxLoaiSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelLoaiSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxTenSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelTenSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.textBoxMaSach)
        Me.groupBoxThongTinSach.Controls.Add(Me.labelMaSach)
        Me.groupBoxThongTinSach.Location = New System.Drawing.Point(836, 142)
        Me.groupBoxThongTinSach.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBoxThongTinSach.Name = "groupBoxThongTinSach"
        Me.groupBoxThongTinSach.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBoxThongTinSach.Size = New System.Drawing.Size(492, 505)
        Me.groupBoxThongTinSach.TabIndex = 31
        Me.groupBoxThongTinSach.TabStop = False
        Me.groupBoxThongTinSach.Text = "Thông tin sách"
        '
        'cbbTinhTrangSach
        '
        Me.cbbTinhTrangSach.FormattingEnabled = True
        Me.cbbTinhTrangSach.Location = New System.Drawing.Point(162, 414)
        Me.cbbTinhTrangSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbbTinhTrangSach.Name = "cbbTinhTrangSach"
        Me.cbbTinhTrangSach.Size = New System.Drawing.Size(231, 24)
        Me.cbbTinhTrangSach.TabIndex = 46
        '
        'labelNamXuanBan
        '
        Me.labelNamXuanBan.AutoSize = True
        Me.labelNamXuanBan.Location = New System.Drawing.Point(52, 290)
        Me.labelNamXuanBan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNamXuanBan.Name = "labelNamXuanBan"
        Me.labelNamXuanBan.Size = New System.Drawing.Size(99, 17)
        Me.labelNamXuanBan.TabIndex = 45
        Me.labelNamXuanBan.Text = "Năm xuất bản:"
        '
        'dtpNamXuatBan
        '
        Me.dtpNamXuatBan.CustomFormat = "yyyy"
        Me.dtpNamXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNamXuatBan.Location = New System.Drawing.Point(164, 284)
        Me.dtpNamXuatBan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNamXuatBan.Name = "dtpNamXuatBan"
        Me.dtpNamXuatBan.Size = New System.Drawing.Size(265, 22)
        Me.dtpNamXuatBan.TabIndex = 44
        '
        'comboBoxTacGia
        '
        Me.comboBoxTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBoxTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBoxTacGia.FormattingEnabled = True
        Me.comboBoxTacGia.Location = New System.Drawing.Point(164, 193)
        Me.comboBoxTacGia.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxTacGia.Name = "comboBoxTacGia"
        Me.comboBoxTacGia.Size = New System.Drawing.Size(179, 24)
        Me.comboBoxTacGia.TabIndex = 43
        '
        'blTinhTrangSach
        '
        Me.blTinhTrangSach.AutoSize = True
        Me.blTinhTrangSach.Location = New System.Drawing.Point(38, 422)
        Me.blTinhTrangSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.blTinhTrangSach.Name = "blTinhTrangSach"
        Me.blTinhTrangSach.Size = New System.Drawing.Size(118, 17)
        Me.blTinhTrangSach.TabIndex = 15
        Me.blTinhTrangSach.Text = "Tình Trạng Sách:"
        '
        'textBoxTriGia
        '
        Me.textBoxTriGia.Location = New System.Drawing.Point(164, 373)
        Me.textBoxTriGia.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxTriGia.Name = "textBoxTriGia"
        Me.textBoxTriGia.Size = New System.Drawing.Size(229, 22)
        Me.textBoxTriGia.TabIndex = 14
        '
        'labelTriGia
        '
        Me.labelTriGia.AutoSize = True
        Me.labelTriGia.Location = New System.Drawing.Point(52, 378)
        Me.labelTriGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTriGia.Name = "labelTriGia"
        Me.labelTriGia.Size = New System.Drawing.Size(52, 17)
        Me.labelTriGia.TabIndex = 13
        Me.labelTriGia.Text = "Trị giá:"
        '
        'labelNgayNhap
        '
        Me.labelNgayNhap.AutoSize = True
        Me.labelNgayNhap.Location = New System.Drawing.Point(52, 336)
        Me.labelNgayNhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNgayNhap.Name = "labelNgayNhap"
        Me.labelNgayNhap.Size = New System.Drawing.Size(81, 17)
        Me.labelNgayNhap.TabIndex = 12
        Me.labelNgayNhap.Text = "Ngày nhập:"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(164, 328)
        Me.dtpNgayNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgayNhap.TabIndex = 11
        '
        'comboBoxNhaXuatBan
        '
        Me.comboBoxNhaXuatBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBoxNhaXuatBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBoxNhaXuatBan.FormattingEnabled = True
        Me.comboBoxNhaXuatBan.Location = New System.Drawing.Point(164, 238)
        Me.comboBoxNhaXuatBan.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxNhaXuatBan.Name = "comboBoxNhaXuatBan"
        Me.comboBoxNhaXuatBan.Size = New System.Drawing.Size(176, 24)
        Me.comboBoxNhaXuatBan.TabIndex = 10
        '
        'labelNhaXuatBan
        '
        Me.labelNhaXuatBan.AutoSize = True
        Me.labelNhaXuatBan.Location = New System.Drawing.Point(52, 245)
        Me.labelNhaXuatBan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNhaXuatBan.Name = "labelNhaXuatBan"
        Me.labelNhaXuatBan.Size = New System.Drawing.Size(96, 17)
        Me.labelNhaXuatBan.TabIndex = 9
        Me.labelNhaXuatBan.Text = "Nhà xuất bản:"
        '
        'labelTenTacGia
        '
        Me.labelTenTacGia.AutoSize = True
        Me.labelTenTacGia.Location = New System.Drawing.Point(52, 199)
        Me.labelTenTacGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTenTacGia.Name = "labelTenTacGia"
        Me.labelTenTacGia.Size = New System.Drawing.Size(59, 17)
        Me.labelTenTacGia.TabIndex = 7
        Me.labelTenTacGia.Text = "Tác giả:"
        '
        'comboBoxLoaiSach
        '
        Me.comboBoxLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxLoaiSach.FormattingEnabled = True
        Me.comboBoxLoaiSach.Location = New System.Drawing.Point(164, 147)
        Me.comboBoxLoaiSach.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxLoaiSach.Name = "comboBoxLoaiSach"
        Me.comboBoxLoaiSach.Size = New System.Drawing.Size(176, 24)
        Me.comboBoxLoaiSach.TabIndex = 6
        '
        'labelLoaiSach
        '
        Me.labelLoaiSach.AutoSize = True
        Me.labelLoaiSach.Location = New System.Drawing.Point(52, 154)
        Me.labelLoaiSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelLoaiSach.Name = "labelLoaiSach"
        Me.labelLoaiSach.Size = New System.Drawing.Size(73, 17)
        Me.labelLoaiSach.TabIndex = 4
        Me.labelLoaiSach.Text = "Loại sách:"
        '
        'textBoxTenSach
        '
        Me.textBoxTenSach.Location = New System.Drawing.Point(164, 103)
        Me.textBoxTenSach.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxTenSach.Name = "textBoxTenSach"
        Me.textBoxTenSach.Size = New System.Drawing.Size(231, 22)
        Me.textBoxTenSach.TabIndex = 3
        '
        'labelTenSach
        '
        Me.labelTenSach.AutoSize = True
        Me.labelTenSach.Location = New System.Drawing.Point(52, 108)
        Me.labelTenSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTenSach.Name = "labelTenSach"
        Me.labelTenSach.Size = New System.Drawing.Size(71, 17)
        Me.labelTenSach.TabIndex = 2
        Me.labelTenSach.Text = "Tên sách:"
        '
        'textBoxMaSach
        '
        Me.textBoxMaSach.Enabled = False
        Me.textBoxMaSach.Location = New System.Drawing.Point(164, 59)
        Me.textBoxMaSach.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxMaSach.Name = "textBoxMaSach"
        Me.textBoxMaSach.ReadOnly = True
        Me.textBoxMaSach.Size = New System.Drawing.Size(176, 22)
        Me.textBoxMaSach.TabIndex = 1
        '
        'labelMaSach
        '
        Me.labelMaSach.AutoSize = True
        Me.labelMaSach.Location = New System.Drawing.Point(52, 62)
        Me.labelMaSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelMaSach.Name = "labelMaSach"
        Me.labelMaSach.Size = New System.Drawing.Size(65, 17)
        Me.labelMaSach.TabIndex = 0
        Me.labelMaSach.Text = "Mã sách:"
        '
        'buttonThemSach
        '
        Me.buttonThemSach.BackColor = System.Drawing.Color.Snow
        Me.buttonThemSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonThemSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonThemSach.ForeColor = System.Drawing.Color.IndianRed
        Me.buttonThemSach.Image = CType(resources.GetObject("buttonThemSach.Image"), System.Drawing.Image)
        Me.buttonThemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonThemSach.Location = New System.Drawing.Point(941, 673)
        Me.buttonThemSach.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonThemSach.Name = "buttonThemSach"
        Me.buttonThemSach.Size = New System.Drawing.Size(138, 54)
        Me.buttonThemSach.TabIndex = 30
        Me.buttonThemSach.Text = "       Thêm"
        Me.buttonThemSach.UseVisualStyleBackColor = False
        '
        'dgvQuanLySach
        '
        Me.dgvQuanLySach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvQuanLySach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLySach.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvQuanLySach.Location = New System.Drawing.Point(3, 80)
        Me.dgvQuanLySach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvQuanLySach.MultiSelect = False
        Me.dgvQuanLySach.Name = "dgvQuanLySach"
        Me.dgvQuanLySach.ReadOnly = True
        Me.dgvQuanLySach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvQuanLySach.RowHeadersVisible = False
        Me.dgvQuanLySach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvQuanLySach.RowTemplate.ReadOnly = True
        Me.dgvQuanLySach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQuanLySach.Size = New System.Drawing.Size(704, 422)
        Me.dgvQuanLySach.TabIndex = 29
        '
        'textBoxTimKiem
        '
        Me.textBoxTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxTimKiem.Location = New System.Drawing.Point(171, 29)
        Me.textBoxTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxTimKiem.Name = "textBoxTimKiem"
        Me.textBoxTimKiem.Size = New System.Drawing.Size(391, 27)
        Me.textBoxTimKiem.TabIndex = 28
        '
        'comboBoxTimKiem
        '
        Me.comboBoxTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxTimKiem.FormattingEnabled = True
        Me.comboBoxTimKiem.Location = New System.Drawing.Point(52, 29)
        Me.comboBoxTimKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxTimKiem.Name = "comboBoxTimKiem"
        Me.comboBoxTimKiem.Size = New System.Drawing.Size(111, 28)
        Me.comboBoxTimKiem.TabIndex = 26
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Snow
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.IndianRed
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(1236, 673)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(132, 54)
        Me.btnXoa.TabIndex = 37
        Me.btnXoa.Text = "    Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Constantia", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(582, 48)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(227, 40)
        Me.lblTieuDe.TabIndex = 39
        Me.lblTieuDe.Text = "Quản Lý Sách"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.textBoxTimKiem)
        Me.GroupBox1.Controls.Add(Me.comboBoxTimKiem)
        Me.GroupBox1.Controls.Add(Me.buttonTimKiem)
        Me.GroupBox1.Controls.Add(Me.dgvQuanLySach)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 505)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hiển thị Sách"
        '
        'frmNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1395, 754)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnTaoMoi)
        Me.Controls.Add(Me.buttonThoat)
        Me.Controls.Add(Me.buttonCapNhap)
        Me.Controls.Add(Me.buttonXoaHet)
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.groupBoxThongTinSach)
        Me.Controls.Add(Me.buttonThemSach)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmNhapSach"
        Me.Text = "Quản lý sách"
        Me.groupBoxThongTinSach.ResumeLayout(False)
        Me.groupBoxThongTinSach.PerformLayout()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonTimKiem As Button
    Friend WithEvents btnTaoMoi As Button
    Friend WithEvents buttonThoat As Button
    Friend WithEvents buttonCapNhap As Button
    Friend WithEvents buttonXoaHet As Button
    Friend WithEvents buttonRefresh As Button
    Friend WithEvents groupBoxThongTinSach As GroupBox
    Friend WithEvents labelNamXuanBan As Label
    Friend WithEvents dtpNamXuatBan As DateTimePicker
    Friend WithEvents comboBoxTacGia As ComboBox
    Friend WithEvents blTinhTrangSach As Label
    Friend WithEvents textBoxTriGia As TextBox
    Friend WithEvents labelTriGia As Label
    Friend WithEvents labelNgayNhap As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents comboBoxNhaXuatBan As ComboBox
    Friend WithEvents labelNhaXuatBan As Label
    Friend WithEvents labelTenTacGia As Label
    Friend WithEvents comboBoxLoaiSach As ComboBox
    Friend WithEvents labelLoaiSach As Label
    Friend WithEvents textBoxTenSach As TextBox
    Friend WithEvents labelTenSach As Label
    Friend WithEvents textBoxMaSach As TextBox
    Friend WithEvents labelMaSach As Label
    Friend WithEvents buttonThemSach As Button
    Friend WithEvents dgvQuanLySach As DataGridView
    Friend WithEvents textBoxTimKiem As TextBox
    Friend WithEvents comboBoxTimKiem As ComboBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents cbbTinhTrangSach As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
