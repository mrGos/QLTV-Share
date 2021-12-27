<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSachGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoaiSachGUI))
        Me.btnNhapVaDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNhapVaDong
        '
        Me.btnNhapVaDong.BackColor = System.Drawing.Color.Snow
        Me.btnNhapVaDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhapVaDong.ForeColor = System.Drawing.Color.IndianRed
        Me.btnNhapVaDong.Image = CType(resources.GetObject("btnNhapVaDong.Image"), System.Drawing.Image)
        Me.btnNhapVaDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhapVaDong.Location = New System.Drawing.Point(416, 283)
        Me.btnNhapVaDong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNhapVaDong.Name = "btnNhapVaDong"
        Me.btnNhapVaDong.Size = New System.Drawing.Size(174, 48)
        Me.btnNhapVaDong.TabIndex = 34
        Me.btnNhapVaDong.Text = "        Nhập và Đóng"
        Me.btnNhapVaDong.UseVisualStyleBackColor = False
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.Snow
        Me.btnNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap.ForeColor = System.Drawing.Color.IndianRed
        Me.btnNhap.Image = CType(resources.GetObject("btnNhap.Image"), System.Drawing.Image)
        Me.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhap.Location = New System.Drawing.Point(229, 283)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(170, 48)
        Me.btnNhap.TabIndex = 33
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(177, 46)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(176, 22)
        Me.txtMaLoai.TabIndex = 32
        Me.txtMaLoai.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Mã  Thể Loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(177, 99)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(295, 22)
        Me.txtTenLoai.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tên Thể Loại:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtMaLoai)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTenLoai)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 172)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin loại sách"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(206, 28)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(225, 35)
        Me.lblTieuDe.TabIndex = 48
        Me.lblTieuDe.Text = "Thể Loại Sách"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(33, 283)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(170, 48)
        Me.btnThoat.TabIndex = 33
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmLoaiSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(622, 361)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNhapVaDong)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLoaiSachGUI"
        Me.Text = "Thể loại sách"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNhapVaDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents btnThoat As Button
End Class
