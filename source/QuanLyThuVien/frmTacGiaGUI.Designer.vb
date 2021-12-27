<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTacGiaGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTacGiaGUI))
        Me.btnNhapVanDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.txtMaTacGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenTacGia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
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
        Me.btnNhapVanDong.Location = New System.Drawing.Point(402, 300)
        Me.btnNhapVanDong.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhapVanDong.Name = "btnNhapVanDong"
        Me.btnNhapVanDong.Size = New System.Drawing.Size(166, 48)
        Me.btnNhapVanDong.TabIndex = 34
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
        Me.btnNhap.Location = New System.Drawing.Point(207, 300)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(167, 48)
        Me.btnNhap.TabIndex = 33
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'txtMaTacGia
        '
        Me.txtMaTacGia.Location = New System.Drawing.Point(221, 49)
        Me.txtMaTacGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.ReadOnly = True
        Me.txtMaTacGia.Size = New System.Drawing.Size(176, 22)
        Me.txtMaTacGia.TabIndex = 32
        Me.txtMaTacGia.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Mã Tác Giả:"
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(221, 104)
        Me.txtTenTacGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(232, 22)
        Me.txtTenTacGia.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tên Tác Giải:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMaTacGia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTenTacGia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 175)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tác giả"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(230, 39)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(128, 35)
        Me.lblTieuDe.TabIndex = 49
        Me.lblTieuDe.Text = "Tác Giả"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(15, 300)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(170, 48)
        Me.btnThoat.TabIndex = 50
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmTacGiaGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(588, 381)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNhapVanDong)
        Me.Controls.Add(Me.btnNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTacGiaGUI"
        Me.Text = "Tác giả"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhapVanDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents txtMaTacGia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenTacGia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents btnThoat As Button
End Class
