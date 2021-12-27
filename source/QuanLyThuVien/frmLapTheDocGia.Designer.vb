<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapTheDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLapTheDocGia))
        Me.txtTieuDe = New System.Windows.Forms.Label()
        Me.gbThongTinDocGia = New System.Windows.Forms.GroupBox()
        Me.nudSoSachDangMuon = New System.Windows.Forms.NumericUpDown()
        Me.txtMaSo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbLoaiDGCapNhat = New System.Windows.Forms.ComboBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTinhTrangThe = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtpNgayHetHan = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.dgvListDG = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTaoMoi = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbLoaiDG = New System.Windows.Forms.ComboBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbThongTinDocGia.SuspendLayout()
        CType(Me.nudSoSachDangMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTieuDe
        '
        Me.txtTieuDe.AutoSize = True
        Me.txtTieuDe.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTieuDe.ForeColor = System.Drawing.Color.Black
        Me.txtTieuDe.Location = New System.Drawing.Point(532, 27)
        Me.txtTieuDe.Name = "txtTieuDe"
        Me.txtTieuDe.Size = New System.Drawing.Size(181, 34)
        Me.txtTieuDe.TabIndex = 0
        Me.txtTieuDe.Text = "Thẻ Độc Giả"
        '
        'gbThongTinDocGia
        '
        Me.gbThongTinDocGia.BackColor = System.Drawing.Color.MediumVioletRed
        Me.gbThongTinDocGia.Controls.Add(Me.nudSoSachDangMuon)
        Me.gbThongTinDocGia.Controls.Add(Me.txtMaSo)
        Me.gbThongTinDocGia.Controls.Add(Me.Label6)
        Me.gbThongTinDocGia.Controls.Add(Me.txtHoTen)
        Me.gbThongTinDocGia.Controls.Add(Me.Label5)
        Me.gbThongTinDocGia.Controls.Add(Me.Label10)
        Me.gbThongTinDocGia.Controls.Add(Me.Label1)
        Me.gbThongTinDocGia.Controls.Add(Me.Label2)
        Me.gbThongTinDocGia.Controls.Add(Me.cbLoaiDGCapNhat)
        Me.gbThongTinDocGia.Controls.Add(Me.txtDiaChi)
        Me.gbThongTinDocGia.Controls.Add(Me.Label9)
        Me.gbThongTinDocGia.Controls.Add(Me.Label7)
        Me.gbThongTinDocGia.Controls.Add(Me.Label8)
        Me.gbThongTinDocGia.Controls.Add(Me.Label4)
        Me.gbThongTinDocGia.Controls.Add(Me.txtTinhTrangThe)
        Me.gbThongTinDocGia.Controls.Add(Me.txtEmail)
        Me.gbThongTinDocGia.Controls.Add(Me.dtpNgayHetHan)
        Me.gbThongTinDocGia.Controls.Add(Me.dtpNgayLapThe)
        Me.gbThongTinDocGia.Controls.Add(Me.Label3)
        Me.gbThongTinDocGia.Controls.Add(Me.dtpNgaySinh)
        Me.gbThongTinDocGia.Location = New System.Drawing.Point(650, 111)
        Me.gbThongTinDocGia.Name = "gbThongTinDocGia"
        Me.gbThongTinDocGia.Size = New System.Drawing.Size(541, 508)
        Me.gbThongTinDocGia.TabIndex = 1
        Me.gbThongTinDocGia.TabStop = False
        Me.gbThongTinDocGia.Text = "Thông tin độc giả:"
        '
        'nudSoSachDangMuon
        '
        Me.nudSoSachDangMuon.Location = New System.Drawing.Point(200, 383)
        Me.nudSoSachDangMuon.Name = "nudSoSachDangMuon"
        Me.nudSoSachDangMuon.Size = New System.Drawing.Size(77, 22)
        Me.nudSoSachDangMuon.TabIndex = 45
        '
        'txtMaSo
        '
        Me.txtMaSo.Enabled = False
        Me.txtMaSo.Location = New System.Drawing.Point(201, 35)
        Me.txtMaSo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSo.Name = "txtMaSo"
        Me.txtMaSo.ReadOnly = True
        Me.txtMaSo.Size = New System.Drawing.Size(215, 22)
        Me.txtMaSo.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Họ Tên:"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(201, 81)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(295, 22)
        Me.txtHoTen.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 383)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Số sách đang mượn:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(66, 470)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Tình trạng thẻ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 337)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Tên Loại DG:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Địa Chỉ:"
        '
        'cbLoaiDGCapNhat
        '
        Me.cbLoaiDGCapNhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDGCapNhat.FormattingEnabled = True
        Me.cbLoaiDGCapNhat.Location = New System.Drawing.Point(200, 334)
        Me.cbLoaiDGCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDGCapNhat.Name = "cbLoaiDGCapNhat"
        Me.cbLoaiDGCapNhat.Size = New System.Drawing.Size(233, 24)
        Me.cbLoaiDGCapNhat.TabIndex = 50
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(200, 137)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(295, 26)
        Me.txtDiaChi.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 425)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Ngày hết hạn:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(94, 289)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Ngày Lập:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 243)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Ngày Sinh:"
        '
        'txtTinhTrangThe
        '
        Me.txtTinhTrangThe.Location = New System.Drawing.Point(200, 467)
        Me.txtTinhTrangThe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTinhTrangThe.Name = "txtTinhTrangThe"
        Me.txtTinhTrangThe.Size = New System.Drawing.Size(213, 22)
        Me.txtTinhTrangThe.TabIndex = 43
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(200, 193)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(295, 22)
        Me.txtEmail.TabIndex = 43
        '
        'dtpNgayHetHan
        '
        Me.dtpNgayHetHan.CustomFormat = ""
        Me.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayHetHan.Location = New System.Drawing.Point(201, 425)
        Me.dtpNgayHetHan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayHetHan.Name = "dtpNgayHetHan"
        Me.dtpNgayHetHan.Size = New System.Drawing.Size(264, 22)
        Me.dtpNgayHetHan.TabIndex = 46
        Me.dtpNgayHetHan.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.CustomFormat = ""
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(200, 289)
        Me.dtpNgayLapThe.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgayLapThe.TabIndex = 46
        Me.dtpNgayLapThe.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Mã Số:"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = ""
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(201, 238)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgaySinh.TabIndex = 47
        Me.dtpNgaySinh.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'dgvListDG
        '
        Me.dgvListDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvListDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvListDG.GridColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.dgvListDG.Location = New System.Drawing.Point(3, 60)
        Me.dgvListDG.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListDG.MultiSelect = False
        Me.dgvListDG.Name = "dgvListDG"
        Me.dgvListDG.ReadOnly = True
        Me.dgvListDG.RowHeadersVisible = False
        Me.dgvListDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListDG.Size = New System.Drawing.Size(599, 445)
        Me.dgvListDG.TabIndex = 28
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Snow
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.IndianRed
        Me.btnXoa.Location = New System.Drawing.Point(1077, 649)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(140, 48)
        Me.btnXoa.TabIndex = 41
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.Snow
        Me.btnCapNhat.BackgroundImage = CType(resources.GetObject("btnCapNhat.BackgroundImage"), System.Drawing.Image)
        Me.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnCapNhat.Location = New System.Drawing.Point(918, 649)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(151, 48)
        Me.btnCapNhat.TabIndex = 40
        Me.btnCapNhat.Text = "       Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Snow
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThem.Location = New System.Drawing.Point(766, 649)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(144, 50)
        Me.btnThem.TabIndex = 42
        Me.btnThem.Text = "  Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.BackColor = System.Drawing.Color.Snow
        Me.btnTaoMoi.BackgroundImage = CType(resources.GetObject("btnTaoMoi.BackgroundImage"), System.Drawing.Image)
        Me.btnTaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTaoMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaoMoi.ForeColor = System.Drawing.Color.IndianRed
        Me.btnTaoMoi.Location = New System.Drawing.Point(619, 649)
        Me.btnTaoMoi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(139, 50)
        Me.btnTaoMoi.TabIndex = 42
        Me.btnTaoMoi.Text = "     Tạo Mới"
        Me.btnTaoMoi.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(185, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Loại DG:"
        '
        'cbLoaiDG
        '
        Me.cbLoaiDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDG.FormattingEnabled = True
        Me.cbLoaiDG.Location = New System.Drawing.Point(267, 22)
        Me.cbLoaiDG.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiDG.Name = "cbLoaiDG"
        Me.cbLoaiDG.Size = New System.Drawing.Size(122, 24)
        Me.cbLoaiDG.TabIndex = 43
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.BackgroundImage = CType(resources.GetObject("btnThoat.BackgroundImage"), System.Drawing.Image)
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Location = New System.Drawing.Point(13, 649)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(142, 50)
        Me.btnThoat.TabIndex = 42
        Me.btnThoat.Text = " Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dgvListDG)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbLoaiDG)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 508)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hiển thị danh sách"
        '
        'frmLapTheDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 736)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTaoMoi)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.gbThongTinDocGia)
        Me.Controls.Add(Me.txtTieuDe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLapTheDocGia"
        Me.Text = "Lập thẻ độc giả"
        Me.gbThongTinDocGia.ResumeLayout(False)
        Me.gbThongTinDocGia.PerformLayout()
        CType(Me.nudSoSachDangMuon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTieuDe As Label
    Friend WithEvents gbThongTinDocGia As GroupBox
    Friend WithEvents txtMaSo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbLoaiDGCapNhat As ComboBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dtpNgayHetHan As DateTimePicker
    Friend WithEvents dtpNgayLapThe As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents dgvListDG As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTaoMoi As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cbLoaiDG As ComboBox
    Friend WithEvents btnThoat As Button
    Friend WithEvents txtTinhTrangThe As TextBox
    Friend WithEvents nudSoSachDangMuon As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
End Class
