<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraCuu))
        Me.tabControlTraCuu = New System.Windows.Forms.TabControl()
        Me.tabPageDocGia = New System.Windows.Forms.TabPage()
        Me.btnRefreshDocGia = New System.Windows.Forms.Button()
        Me.txtBoxDGFilter = New System.Windows.Forms.TextBox()
        Me.cbThuocTinhDG = New System.Windows.Forms.ComboBox()
        Me.dgvListDG = New System.Windows.Forms.DataGridView()
        Me.tabPageSach = New System.Windows.Forms.TabPage()
        Me.btnRefreshSach = New System.Windows.Forms.Button()
        Me.txtBoxSachFilter = New System.Windows.Forms.TextBox()
        Me.cbThuocTinhSach = New System.Windows.Forms.ComboBox()
        Me.dgvQuanLySach = New System.Windows.Forms.DataGridView()
        Me.tabPAgePhieuMuonSach = New System.Windows.Forms.TabPage()
        Me.cbThuocTinhSort = New System.Windows.Forms.ComboBox()
        Me.lbSapXep = New System.Windows.Forms.Label()
        Me.btnRefreshPhieu = New System.Windows.Forms.Button()
        Me.txtBoxPhieuMuonFilter = New System.Windows.Forms.TextBox()
        Me.cbThuocTinhPhieuMuon = New System.Windows.Forms.ComboBox()
        Me.dgvPhieuMuon = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.tabControlTraCuu.SuspendLayout()
        Me.tabPageDocGia.SuspendLayout()
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageSach.SuspendLayout()
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPAgePhieuMuonSach.SuspendLayout()
        CType(Me.dgvPhieuMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControlTraCuu
        '
        Me.tabControlTraCuu.Controls.Add(Me.tabPageDocGia)
        Me.tabControlTraCuu.Controls.Add(Me.tabPageSach)
        Me.tabControlTraCuu.Controls.Add(Me.tabPAgePhieuMuonSach)
        Me.tabControlTraCuu.Location = New System.Drawing.Point(29, 120)
        Me.tabControlTraCuu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabControlTraCuu.Name = "tabControlTraCuu"
        Me.tabControlTraCuu.SelectedIndex = 0
        Me.tabControlTraCuu.Size = New System.Drawing.Size(1096, 507)
        Me.tabControlTraCuu.TabIndex = 0
        '
        'tabPageDocGia
        '
        Me.tabPageDocGia.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tabPageDocGia.Controls.Add(Me.GroupBox1)
        Me.tabPageDocGia.Controls.Add(Me.dgvListDG)
        Me.tabPageDocGia.Location = New System.Drawing.Point(4, 25)
        Me.tabPageDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPageDocGia.Name = "tabPageDocGia"
        Me.tabPageDocGia.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPageDocGia.Size = New System.Drawing.Size(1088, 478)
        Me.tabPageDocGia.TabIndex = 0
        Me.tabPageDocGia.Text = "Độc Giả"
        '
        'btnRefreshDocGia
        '
        Me.btnRefreshDocGia.BackColor = System.Drawing.Color.Snow
        Me.btnRefreshDocGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshDocGia.ForeColor = System.Drawing.Color.IndianRed
        Me.btnRefreshDocGia.Image = CType(resources.GetObject("btnRefreshDocGia.Image"), System.Drawing.Image)
        Me.btnRefreshDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefreshDocGia.Location = New System.Drawing.Point(906, 21)
        Me.btnRefreshDocGia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshDocGia.Name = "btnRefreshDocGia"
        Me.btnRefreshDocGia.Size = New System.Drawing.Size(137, 42)
        Me.btnRefreshDocGia.TabIndex = 3
        Me.btnRefreshDocGia.Text = "    Tải lại"
        Me.btnRefreshDocGia.UseVisualStyleBackColor = False
        '
        'txtBoxDGFilter
        '
        Me.txtBoxDGFilter.Location = New System.Drawing.Point(194, 31)
        Me.txtBoxDGFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxDGFilter.Name = "txtBoxDGFilter"
        Me.txtBoxDGFilter.Size = New System.Drawing.Size(355, 22)
        Me.txtBoxDGFilter.TabIndex = 2
        '
        'cbThuocTinhDG
        '
        Me.cbThuocTinhDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThuocTinhDG.FormattingEnabled = True
        Me.cbThuocTinhDG.Location = New System.Drawing.Point(24, 31)
        Me.cbThuocTinhDG.Margin = New System.Windows.Forms.Padding(4)
        Me.cbThuocTinhDG.Name = "cbThuocTinhDG"
        Me.cbThuocTinhDG.Size = New System.Drawing.Size(160, 24)
        Me.cbThuocTinhDG.TabIndex = 1
        '
        'dgvListDG
        '
        Me.dgvListDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDG.Location = New System.Drawing.Point(8, 95)
        Me.dgvListDG.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListDG.Name = "dgvListDG"
        Me.dgvListDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListDG.Size = New System.Drawing.Size(1069, 372)
        Me.dgvListDG.TabIndex = 0
        '
        'tabPageSach
        '
        Me.tabPageSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tabPageSach.Controls.Add(Me.GroupBox2)
        Me.tabPageSach.Controls.Add(Me.dgvQuanLySach)
        Me.tabPageSach.Location = New System.Drawing.Point(4, 25)
        Me.tabPageSach.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPageSach.Name = "tabPageSach"
        Me.tabPageSach.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPageSach.Size = New System.Drawing.Size(1088, 478)
        Me.tabPageSach.TabIndex = 1
        Me.tabPageSach.Text = "Sách"
        '
        'btnRefreshSach
        '
        Me.btnRefreshSach.BackColor = System.Drawing.Color.Snow
        Me.btnRefreshSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshSach.ForeColor = System.Drawing.Color.IndianRed
        Me.btnRefreshSach.Image = CType(resources.GetObject("btnRefreshSach.Image"), System.Drawing.Image)
        Me.btnRefreshSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefreshSach.Location = New System.Drawing.Point(910, 21)
        Me.btnRefreshSach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshSach.Name = "btnRefreshSach"
        Me.btnRefreshSach.Size = New System.Drawing.Size(137, 42)
        Me.btnRefreshSach.TabIndex = 6
        Me.btnRefreshSach.Text = "    Tải lại"
        Me.btnRefreshSach.UseVisualStyleBackColor = False
        '
        'txtBoxSachFilter
        '
        Me.txtBoxSachFilter.Location = New System.Drawing.Point(192, 31)
        Me.txtBoxSachFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxSachFilter.Name = "txtBoxSachFilter"
        Me.txtBoxSachFilter.Size = New System.Drawing.Size(355, 22)
        Me.txtBoxSachFilter.TabIndex = 5
        '
        'cbThuocTinhSach
        '
        Me.cbThuocTinhSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThuocTinhSach.FormattingEnabled = True
        Me.cbThuocTinhSach.Location = New System.Drawing.Point(23, 31)
        Me.cbThuocTinhSach.Margin = New System.Windows.Forms.Padding(4)
        Me.cbThuocTinhSach.Name = "cbThuocTinhSach"
        Me.cbThuocTinhSach.Size = New System.Drawing.Size(160, 24)
        Me.cbThuocTinhSach.TabIndex = 4
        '
        'dgvQuanLySach
        '
        Me.dgvQuanLySach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLySach.Location = New System.Drawing.Point(8, 93)
        Me.dgvQuanLySach.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvQuanLySach.Name = "dgvQuanLySach"
        Me.dgvQuanLySach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQuanLySach.Size = New System.Drawing.Size(1069, 374)
        Me.dgvQuanLySach.TabIndex = 1
        '
        'tabPAgePhieuMuonSach
        '
        Me.tabPAgePhieuMuonSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tabPAgePhieuMuonSach.Controls.Add(Me.GroupBox3)
        Me.tabPAgePhieuMuonSach.Controls.Add(Me.dgvPhieuMuon)
        Me.tabPAgePhieuMuonSach.Location = New System.Drawing.Point(4, 25)
        Me.tabPAgePhieuMuonSach.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPAgePhieuMuonSach.Name = "tabPAgePhieuMuonSach"
        Me.tabPAgePhieuMuonSach.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPAgePhieuMuonSach.Size = New System.Drawing.Size(1088, 478)
        Me.tabPAgePhieuMuonSach.TabIndex = 2
        Me.tabPAgePhieuMuonSach.Text = "Phiếu mượn sách"
        '
        'cbThuocTinhSort
        '
        Me.cbThuocTinhSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThuocTinhSort.FormattingEnabled = True
        Me.cbThuocTinhSort.Location = New System.Drawing.Point(706, 36)
        Me.cbThuocTinhSort.Margin = New System.Windows.Forms.Padding(4)
        Me.cbThuocTinhSort.Name = "cbThuocTinhSort"
        Me.cbThuocTinhSort.Size = New System.Drawing.Size(160, 24)
        Me.cbThuocTinhSort.TabIndex = 9
        '
        'lbSapXep
        '
        Me.lbSapXep.AutoSize = True
        Me.lbSapXep.Location = New System.Drawing.Point(604, 39)
        Me.lbSapXep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSapXep.Name = "lbSapXep"
        Me.lbSapXep.Size = New System.Drawing.Size(91, 17)
        Me.lbSapXep.TabIndex = 8
        Me.lbSapXep.Text = "Sắp xếp theo"
        '
        'btnRefreshPhieu
        '
        Me.btnRefreshPhieu.BackColor = System.Drawing.Color.Snow
        Me.btnRefreshPhieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshPhieu.ForeColor = System.Drawing.Color.IndianRed
        Me.btnRefreshPhieu.Image = CType(resources.GetObject("btnRefreshPhieu.Image"), System.Drawing.Image)
        Me.btnRefreshPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefreshPhieu.Location = New System.Drawing.Point(912, 22)
        Me.btnRefreshPhieu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshPhieu.Name = "btnRefreshPhieu"
        Me.btnRefreshPhieu.Size = New System.Drawing.Size(137, 42)
        Me.btnRefreshPhieu.TabIndex = 6
        Me.btnRefreshPhieu.Text = "    Tải lại"
        Me.btnRefreshPhieu.UseVisualStyleBackColor = False
        '
        'txtBoxPhieuMuonFilter
        '
        Me.txtBoxPhieuMuonFilter.Location = New System.Drawing.Point(199, 36)
        Me.txtBoxPhieuMuonFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxPhieuMuonFilter.Name = "txtBoxPhieuMuonFilter"
        Me.txtBoxPhieuMuonFilter.Size = New System.Drawing.Size(355, 22)
        Me.txtBoxPhieuMuonFilter.TabIndex = 5
        '
        'cbThuocTinhPhieuMuon
        '
        Me.cbThuocTinhPhieuMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThuocTinhPhieuMuon.FormattingEnabled = True
        Me.cbThuocTinhPhieuMuon.Location = New System.Drawing.Point(30, 36)
        Me.cbThuocTinhPhieuMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.cbThuocTinhPhieuMuon.Name = "cbThuocTinhPhieuMuon"
        Me.cbThuocTinhPhieuMuon.Size = New System.Drawing.Size(160, 24)
        Me.cbThuocTinhPhieuMuon.TabIndex = 4
        '
        'dgvPhieuMuon
        '
        Me.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuMuon.Location = New System.Drawing.Point(8, 91)
        Me.dgvPhieuMuon.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPhieuMuon.Name = "dgvPhieuMuon"
        Me.dgvPhieuMuon.Size = New System.Drawing.Size(1069, 376)
        Me.dgvPhieuMuon.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnRefreshDocGia)
        Me.GroupBox1.Controls.Add(Me.cbThuocTinhDG)
        Me.GroupBox1.Controls.Add(Me.txtBoxDGFilter)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1069, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bộ lọc Độc giả"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cbThuocTinhSach)
        Me.GroupBox2.Controls.Add(Me.btnRefreshSach)
        Me.GroupBox2.Controls.Add(Me.txtBoxSachFilter)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1069, 79)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bộ lọc Sách"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cbThuocTinhSort)
        Me.GroupBox3.Controls.Add(Me.cbThuocTinhPhieuMuon)
        Me.GroupBox3.Controls.Add(Me.lbSapXep)
        Me.GroupBox3.Controls.Add(Me.txtBoxPhieuMuonFilter)
        Me.GroupBox3.Controls.Add(Me.btnRefreshPhieu)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1069, 77)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bộ lọc Phiếu mượn sách"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(497, 51)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(160, 35)
        Me.lblTieuDe.TabIndex = 50
        Me.lblTieuDe.Text = "TRA CỨU"
        '
        'frmTraCuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1156, 652)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.tabControlTraCuu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTraCuu"
        Me.Text = "Tra Cứu"
        Me.tabControlTraCuu.ResumeLayout(False)
        Me.tabPageDocGia.ResumeLayout(False)
        CType(Me.dgvListDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageSach.ResumeLayout(False)
        CType(Me.dgvQuanLySach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPAgePhieuMuonSach.ResumeLayout(False)
        CType(Me.dgvPhieuMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabControlTraCuu As TabControl
    Friend WithEvents tabPageDocGia As TabPage
    Friend WithEvents tabPageSach As TabPage
    Friend WithEvents tabPAgePhieuMuonSach As TabPage
    Friend WithEvents dgvListDG As DataGridView
    Friend WithEvents dgvQuanLySach As DataGridView
    Friend WithEvents dgvPhieuMuon As DataGridView
    Friend WithEvents cbThuocTinhDG As ComboBox
    Friend WithEvents btnRefreshDocGia As Button
    Friend WithEvents txtBoxDGFilter As TextBox
    Friend WithEvents btnRefreshSach As Button
    Friend WithEvents txtBoxSachFilter As TextBox
    Friend WithEvents cbThuocTinhSach As ComboBox
    Friend WithEvents btnRefreshPhieu As Button
    Friend WithEvents txtBoxPhieuMuonFilter As TextBox
    Friend WithEvents cbThuocTinhPhieuMuon As ComboBox
    Friend WithEvents cbThuocTinhSort As ComboBox
    Friend WithEvents lbSapXep As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTieuDe As Label
End Class
