<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhaXuatBanGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhaXuatBanGUI))
        Me.btnNhapVanDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.txtMaNhaXuatBan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenNhaXuatBan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNhapVanDong
        '
        Me.btnNhapVanDong.BackColor = System.Drawing.Color.Snow
        Me.btnNhapVanDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhapVanDong.ForeColor = System.Drawing.Color.IndianRed
        Me.btnNhapVanDong.Image = CType(resources.GetObject("btnNhapVanDong.Image"), System.Drawing.Image)
        Me.btnNhapVanDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhapVanDong.Location = New System.Drawing.Point(484, 361)
        Me.btnNhapVanDong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNhapVanDong.Name = "btnNhapVanDong"
        Me.btnNhapVanDong.Size = New System.Drawing.Size(173, 48)
        Me.btnNhapVanDong.TabIndex = 40
        Me.btnNhapVanDong.Text = "        Nhập và Đóng"
        Me.btnNhapVanDong.UseVisualStyleBackColor = False
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.Snow
        Me.btnNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap.ForeColor = System.Drawing.Color.IndianRed
        Me.btnNhap.Image = CType(resources.GetObject("btnNhap.Image"), System.Drawing.Image)
        Me.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhap.Location = New System.Drawing.Point(260, 361)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(186, 48)
        Me.btnNhap.TabIndex = 39
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'txtMaNhaXuatBan
        '
        Me.txtMaNhaXuatBan.Location = New System.Drawing.Point(267, 70)
        Me.txtMaNhaXuatBan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan"
        Me.txtMaNhaXuatBan.ReadOnly = True
        Me.txtMaNhaXuatBan.Size = New System.Drawing.Size(176, 22)
        Me.txtMaNhaXuatBan.TabIndex = 38
        Me.txtMaNhaXuatBan.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Mã Nhà Xuất Bản:"
        '
        'txtTenNhaXuatBan
        '
        Me.txtTenNhaXuatBan.Location = New System.Drawing.Point(267, 124)
        Me.txtTenNhaXuatBan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan"
        Me.txtTenNhaXuatBan.Size = New System.Drawing.Size(233, 22)
        Me.txtTenNhaXuatBan.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tên Nhà Xuất Bản:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMaNhaXuatBan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTenNhaXuatBan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 217)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin nhà xuất bản"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(40, 361)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(181, 48)
        Me.btnThoat.TabIndex = 51
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(262, 44)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(225, 35)
        Me.lblTieuDe.TabIndex = 52
        Me.lblTieuDe.Text = "Nhà Xuất Bản"
        '
        'frmNhaXuatBanGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(704, 442)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNhapVanDong)
        Me.Controls.Add(Me.btnNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmNhaXuatBanGUI"
        Me.Text = "Nhà xuất bản"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhapVanDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents txtMaNhaXuatBan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenNhaXuatBan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnThoat As Button
    Friend WithEvents lblTieuDe As Label
End Class
