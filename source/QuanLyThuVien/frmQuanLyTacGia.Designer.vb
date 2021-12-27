<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTacGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyTacGia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaTacGia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenTacGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTaiLai = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTG = New System.Windows.Forms.DataGridView()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDanhSachTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMaTacGia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTenTacGia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(579, 179)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(320, 185)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tác giả:"
        '
        'txtMaTacGia
        '
        Me.txtMaTacGia.Location = New System.Drawing.Point(115, 55)
        Me.txtMaTacGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.ReadOnly = True
        Me.txtMaTacGia.Size = New System.Drawing.Size(176, 22)
        Me.txtMaTacGia.TabIndex = 27
        Me.txtMaTacGia.Text = "1"
        Me.txtMaTacGia.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tên Tác Giả:"
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(115, 113)
        Me.txtTenTacGia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(176, 22)
        Me.txtTenTacGia.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mã Tác Giả"
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Snow
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.IndianRed
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(757, 404)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(169, 47)
        Me.btnXoa.TabIndex = 43
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Snow
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(714, 115)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(185, 50)
        Me.btnThem.TabIndex = 40
        Me.btnThem.Text = "Thêm Tác Giả"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnTaiLai
        '
        Me.btnTaiLai.BackColor = System.Drawing.Color.Snow
        Me.btnTaiLai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaiLai.ForeColor = System.Drawing.Color.IndianRed
        Me.btnTaiLai.Image = CType(resources.GetObject("btnTaiLai.Image"), System.Drawing.Image)
        Me.btnTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTaiLai.Location = New System.Drawing.Point(302, 403)
        Me.btnTaiLai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(169, 48)
        Me.btnTaiLai.TabIndex = 41
        Me.btnTaiLai.Text = "Tải lại"
        Me.btnTaiLai.UseVisualStyleBackColor = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.Snow
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnCapNhat.Image = CType(resources.GetObject("btnCapNhat.Image"), System.Drawing.Image)
        Me.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapNhat.Location = New System.Drawing.Point(547, 403)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(172, 48)
        Me.btnCapNhat.TabIndex = 42
        Me.btnCapNhat.Text = "      Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Danh sách Tác giả:"
        '
        'dgvDanhSachTG
        '
        Me.dgvDanhSachTG.AllowUserToAddRows = False
        Me.dgvDanhSachTG.AllowUserToDeleteRows = False
        Me.dgvDanhSachTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvDanhSachTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTG.Location = New System.Drawing.Point(26, 179)
        Me.dgvDanhSachTG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDanhSachTG.MultiSelect = False
        Me.dgvDanhSachTG.Name = "dgvDanhSachTG"
        Me.dgvDanhSachTG.ReadOnly = True
        Me.dgvDanhSachTG.RowHeadersVisible = False
        Me.dgvDanhSachTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTG.Size = New System.Drawing.Size(515, 185)
        Me.dgvDanhSachTG.TabIndex = 38
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(337, 23)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(263, 35)
        Me.lblTieuDe.TabIndex = 50
        Me.lblTieuDe.Text = "Quản Lý Tác Giả"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(26, 403)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(170, 48)
        Me.btnThoat.TabIndex = 51
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmQuanLyTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 509)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnTaiLai)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachTG)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmQuanLyTacGia"
        Me.Text = "Quản lý tác giả"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDanhSachTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMaTacGia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenTacGia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTaiLai As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachTG As DataGridView
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents btnThoat As Button
End Class
