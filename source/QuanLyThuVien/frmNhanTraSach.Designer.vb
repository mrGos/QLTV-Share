<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanTraSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhanTraSach))
        Me.dtbNgayMuon = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstSachMuonTra = New System.Windows.Forms.ListBox()
        Me.cbbMaPhieuMuon = New System.Windows.Forms.ComboBox()
        Me.cbbMaDocGia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstSachDangMuon = New System.Windows.Forms.ListBox()
        Me.btnRmvMuonTra = New System.Windows.Forms.Button()
        Me.btnAddSachDangMuon = New System.Windows.Forms.Button()
        Me.txtSoNgayTraQuaHan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpNgayToiHan = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.txtTinhTrangThe = New System.Windows.Forms.TextBox()
        Me.txtSoSachDangMuon = New System.Windows.Forms.TextBox()
        Me.txtTenDocGia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvSachDangMuonByDG = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnTraSach = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dtbNgayMuon.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSachDangMuonByDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtbNgayMuon
        '
        Me.dtbNgayMuon.BackColor = System.Drawing.Color.IndianRed
        Me.dtbNgayMuon.Controls.Add(Me.Panel4)
        Me.dtbNgayMuon.Controls.Add(Me.cbbMaPhieuMuon)
        Me.dtbNgayMuon.Controls.Add(Me.cbbMaDocGia)
        Me.dtbNgayMuon.Controls.Add(Me.Label1)
        Me.dtbNgayMuon.Controls.Add(Me.Panel3)
        Me.dtbNgayMuon.Controls.Add(Me.btnRmvMuonTra)
        Me.dtbNgayMuon.Controls.Add(Me.btnAddSachDangMuon)
        Me.dtbNgayMuon.Controls.Add(Me.txtSoNgayTraQuaHan)
        Me.dtbNgayMuon.Controls.Add(Me.Label11)
        Me.dtbNgayMuon.Controls.Add(Me.dtpNgayToiHan)
        Me.dtbNgayMuon.Controls.Add(Me.dtpNgayMuon)
        Me.dtbNgayMuon.Controls.Add(Me.txtTinhTrangThe)
        Me.dtbNgayMuon.Controls.Add(Me.txtSoSachDangMuon)
        Me.dtbNgayMuon.Controls.Add(Me.txtTenDocGia)
        Me.dtbNgayMuon.Controls.Add(Me.Label10)
        Me.dtbNgayMuon.Controls.Add(Me.Label6)
        Me.dtbNgayMuon.Controls.Add(Me.Label5)
        Me.dtbNgayMuon.Controls.Add(Me.Label2)
        Me.dtbNgayMuon.Controls.Add(Me.Label4)
        Me.dtbNgayMuon.Controls.Add(Me.Label7)
        Me.dtbNgayMuon.Location = New System.Drawing.Point(66, 80)
        Me.dtbNgayMuon.Name = "dtbNgayMuon"
        Me.dtbNgayMuon.Size = New System.Drawing.Size(1028, 447)
        Me.dtbNgayMuon.TabIndex = 1
        Me.dtbNgayMuon.TabStop = False
        Me.dtbNgayMuon.Text = "Thông tin trả sách:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.lstSachMuonTra)
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
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sách Muốn Trả"
        '
        'lstSachMuonTra
        '
        Me.lstSachMuonTra.FormattingEnabled = True
        Me.lstSachMuonTra.ItemHeight = 16
        Me.lstSachMuonTra.Location = New System.Drawing.Point(0, 40)
        Me.lstSachMuonTra.Name = "lstSachMuonTra"
        Me.lstSachMuonTra.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSachMuonTra.Size = New System.Drawing.Size(376, 164)
        Me.lstSachMuonTra.TabIndex = 4
        '
        'cbbMaPhieuMuon
        '
        Me.cbbMaPhieuMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMaPhieuMuon.FormattingEnabled = True
        Me.cbbMaPhieuMuon.Location = New System.Drawing.Point(223, 79)
        Me.cbbMaPhieuMuon.Name = "cbbMaPhieuMuon"
        Me.cbbMaPhieuMuon.Size = New System.Drawing.Size(178, 24)
        Me.cbbMaPhieuMuon.TabIndex = 1
        '
        'cbbMaDocGia
        '
        Me.cbbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMaDocGia.FormattingEnabled = True
        Me.cbbMaDocGia.Location = New System.Drawing.Point(223, 34)
        Me.cbbMaDocGia.Name = "cbbMaDocGia"
        Me.cbbMaDocGia.Size = New System.Drawing.Size(178, 24)
        Me.cbbMaDocGia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã độc giả:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.lstSachDangMuon)
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
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sách Đang Mượn"
        '
        'lstSachDangMuon
        '
        Me.lstSachDangMuon.FormattingEnabled = True
        Me.lstSachDangMuon.ItemHeight = 16
        Me.lstSachDangMuon.Location = New System.Drawing.Point(0, 40)
        Me.lstSachDangMuon.Name = "lstSachDangMuon"
        Me.lstSachDangMuon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSachDangMuon.Size = New System.Drawing.Size(376, 164)
        Me.lstSachDangMuon.TabIndex = 4
        '
        'btnRmvMuonTra
        '
        Me.btnRmvMuonTra.BackColor = System.Drawing.Color.LightCyan
        Me.btnRmvMuonTra.Image = CType(resources.GetObject("btnRmvMuonTra.Image"), System.Drawing.Image)
        Me.btnRmvMuonTra.Location = New System.Drawing.Point(479, 361)
        Me.btnRmvMuonTra.Name = "btnRmvMuonTra"
        Me.btnRmvMuonTra.Size = New System.Drawing.Size(104, 40)
        Me.btnRmvMuonTra.TabIndex = 5
        Me.btnRmvMuonTra.UseVisualStyleBackColor = False
        '
        'btnAddSachDangMuon
        '
        Me.btnAddSachDangMuon.BackColor = System.Drawing.Color.LightCyan
        Me.btnAddSachDangMuon.Image = CType(resources.GetObject("btnAddSachDangMuon.Image"), System.Drawing.Image)
        Me.btnAddSachDangMuon.Location = New System.Drawing.Point(479, 298)
        Me.btnAddSachDangMuon.Name = "btnAddSachDangMuon"
        Me.btnAddSachDangMuon.Size = New System.Drawing.Size(104, 40)
        Me.btnAddSachDangMuon.TabIndex = 5
        Me.btnAddSachDangMuon.UseVisualStyleBackColor = False
        '
        'txtSoNgayTraQuaHan
        '
        Me.txtSoNgayTraQuaHan.Enabled = False
        Me.txtSoNgayTraQuaHan.Location = New System.Drawing.Point(801, 170)
        Me.txtSoNgayTraQuaHan.Name = "txtSoNgayTraQuaHan"
        Me.txtSoNgayTraQuaHan.Size = New System.Drawing.Size(178, 22)
        Me.txtSoNgayTraQuaHan.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(608, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Số ngày trả quá hạn:"
        '
        'dtpNgayToiHan
        '
        Me.dtpNgayToiHan.Enabled = False
        Me.dtpNgayToiHan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayToiHan.Location = New System.Drawing.Point(802, 77)
        Me.dtpNgayToiHan.Name = "dtpNgayToiHan"
        Me.dtpNgayToiHan.Size = New System.Drawing.Size(178, 22)
        Me.dtpNgayToiHan.TabIndex = 3
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.Enabled = False
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayMuon.Location = New System.Drawing.Point(802, 32)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(178, 22)
        Me.dtpNgayMuon.TabIndex = 3
        '
        'txtTinhTrangThe
        '
        Me.txtTinhTrangThe.Enabled = False
        Me.txtTinhTrangThe.Location = New System.Drawing.Point(223, 173)
        Me.txtTinhTrangThe.Name = "txtTinhTrangThe"
        Me.txtTinhTrangThe.Size = New System.Drawing.Size(178, 22)
        Me.txtTinhTrangThe.TabIndex = 2
        '
        'txtSoSachDangMuon
        '
        Me.txtSoSachDangMuon.Enabled = False
        Me.txtSoSachDangMuon.Location = New System.Drawing.Point(801, 123)
        Me.txtSoSachDangMuon.Name = "txtSoSachDangMuon"
        Me.txtSoSachDangMuon.Size = New System.Drawing.Size(178, 22)
        Me.txtSoSachDangMuon.TabIndex = 2
        '
        'txtTenDocGia
        '
        Me.txtTenDocGia.Enabled = False
        Me.txtTenDocGia.Location = New System.Drawing.Point(223, 121)
        Me.txtTenDocGia.Name = "txtTenDocGia"
        Me.txtTenDocGia.Size = New System.Drawing.Size(178, 22)
        Me.txtTenDocGia.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tình trạng thẻ ĐG:"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngày tới hạn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã phiếu mượn:"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tên độc giả:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 35)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nhận Trả Sách"
        '
        'dgvSachDangMuonByDG
        '
        Me.dgvSachDangMuonByDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSachDangMuonByDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvSachDangMuonByDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvSachDangMuonByDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvSachDangMuonByDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSachDangMuonByDG.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvSachDangMuonByDG.Location = New System.Drawing.Point(66, 567)
        Me.dgvSachDangMuonByDG.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSachDangMuonByDG.MultiSelect = False
        Me.dgvSachDangMuonByDG.Name = "dgvSachDangMuonByDG"
        Me.dgvSachDangMuonByDG.ReadOnly = True
        Me.dgvSachDangMuonByDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSachDangMuonByDG.RowHeadersVisible = False
        Me.dgvSachDangMuonByDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSachDangMuonByDG.RowTemplate.ReadOnly = True
        Me.dgvSachDangMuonByDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSachDangMuonByDG.Size = New System.Drawing.Size(1028, 185)
        Me.dgvSachDangMuonByDG.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(67, 543)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sách độc giả đang mượn:"
        '
        'btnTraSach
        '
        Me.btnTraSach.BackColor = System.Drawing.Color.Snow
        Me.btnTraSach.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraSach.ForeColor = System.Drawing.Color.IndianRed
        Me.btnTraSach.Image = CType(resources.GetObject("btnTraSach.Image"), System.Drawing.Image)
        Me.btnTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTraSach.Location = New System.Drawing.Point(802, 781)
        Me.btnTraSach.Name = "btnTraSach"
        Me.btnTraSach.Size = New System.Drawing.Size(292, 62)
        Me.btnTraSach.TabIndex = 32
        Me.btnTraSach.Text = "TRẢ SÁCH"
        Me.btnTraSach.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(66, 778)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(292, 62)
        Me.btnThoat.TabIndex = 32
        Me.btnThoat.Text = "THOÁT"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmNhanTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1181, 874)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTraSach)
        Me.Controls.Add(Me.dgvSachDangMuonByDG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtbNgayMuon)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNhanTraSach"
        Me.Text = "frmNhanTraSach"
        Me.dtbNgayMuon.ResumeLayout(False)
        Me.dtbNgayMuon.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSachDangMuonByDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtbNgayMuon As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lstSachMuonTra As ListBox
    Friend WithEvents cbbMaPhieuMuon As ComboBox
    Friend WithEvents cbbMaDocGia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lstSachDangMuon As ListBox
    Friend WithEvents btnRmvMuonTra As Button
    Friend WithEvents btnAddSachDangMuon As Button
    Friend WithEvents txtSoNgayTraQuaHan As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpNgayToiHan As DateTimePicker
    Friend WithEvents dtpNgayMuon As DateTimePicker
    Friend WithEvents txtTinhTrangThe As TextBox
    Friend WithEvents txtSoSachDangMuon As TextBox
    Friend WithEvents txtTenDocGia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSachDangMuonByDG As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents btnTraSach As Button
    Friend WithEvents btnThoat As Button
End Class
