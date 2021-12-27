<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyLoaiSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyLoaiSach))
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachLoaiSach = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDanhSachLoaiSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Snow
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.IndianRed
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(423, 476)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(145, 51)
        Me.btnXoa.TabIndex = 45
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.Snow
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnCapNhat.Image = CType(resources.GetObject("btnCapNhat.Image"), System.Drawing.Image)
        Me.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapNhat.Location = New System.Drawing.Point(226, 476)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(151, 51)
        Me.btnCapNhat.TabIndex = 44
        Me.btnCapNhat.Text = "      Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = False
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(130, 32)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(176, 22)
        Me.txtMaLoai.TabIndex = 43
        Me.txtMaLoai.Text = "LS001"
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Mã Thể Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(130, 89)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tên Thể  Loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Danh sách Loại Sách:"
        '
        'dgvDanhSachLoaiSach
        '
        Me.dgvDanhSachLoaiSach.AllowUserToAddRows = False
        Me.dgvDanhSachLoaiSach.AllowUserToDeleteRows = False
        Me.dgvDanhSachLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachLoaiSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachLoaiSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvDanhSachLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachLoaiSach.Location = New System.Drawing.Point(41, 112)
        Me.dgvDanhSachLoaiSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDanhSachLoaiSach.MultiSelect = False
        Me.dgvDanhSachLoaiSach.Name = "dgvDanhSachLoaiSach"
        Me.dgvDanhSachLoaiSach.ReadOnly = True
        Me.dgvDanhSachLoaiSach.RowHeadersVisible = False
        Me.dgvDanhSachLoaiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachLoaiSach.Size = New System.Drawing.Size(515, 185)
        Me.dgvDanhSachLoaiSach.TabIndex = 38
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Snow
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(595, 112)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(170, 77)
        Me.btnThem.TabIndex = 46
        Me.btnThem.Text = "  Thêm Mới"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(208, 28)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(360, 35)
        Me.lblTieuDe.TabIndex = 47
        Me.lblTieuDe.Text = "Quản Lý Thể Loại Sách"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(38, 476)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(147, 51)
        Me.btnThoat.TabIndex = 48
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMaLoai)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTenLoai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 319)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 138)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'frmQuanLyLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachLoaiSach)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmQuanLyLoaiSach"
        Me.Text = "Quản lý thể loại sách"
        CType(Me.dgvDanhSachLoaiSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachLoaiSach As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
