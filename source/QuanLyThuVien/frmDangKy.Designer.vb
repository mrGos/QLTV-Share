<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDangKy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangKy))
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.lbMatKhau = New System.Windows.Forms.Label()
        Me.txtBoxTenDangNhap = New System.Windows.Forms.TextBox()
        Me.lbTenDangNhap = New System.Windows.Forms.Label()
        Me.txtBoxNhapLaiMatKhau = New System.Windows.Forms.TextBox()
        Me.lbNhapLaiMatKhau = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(252, 100)
        Me.txtMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(255, 30)
        Me.txtMatKhau.TabIndex = 8
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'lbMatKhau
        '
        Me.lbMatKhau.AutoSize = True
        Me.lbMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMatKhau.Location = New System.Drawing.Point(38, 104)
        Me.lbMatKhau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMatKhau.Name = "lbMatKhau"
        Me.lbMatKhau.Size = New System.Drawing.Size(99, 25)
        Me.lbMatKhau.TabIndex = 7
        Me.lbMatKhau.Text = "Mật khẩu:"
        '
        'txtBoxTenDangNhap
        '
        Me.txtBoxTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTenDangNhap.Location = New System.Drawing.Point(252, 44)
        Me.txtBoxTenDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxTenDangNhap.Name = "txtBoxTenDangNhap"
        Me.txtBoxTenDangNhap.Size = New System.Drawing.Size(255, 30)
        Me.txtBoxTenDangNhap.TabIndex = 6
        '
        'lbTenDangNhap
        '
        Me.lbTenDangNhap.AutoSize = True
        Me.lbTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenDangNhap.Location = New System.Drawing.Point(38, 47)
        Me.lbTenDangNhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenDangNhap.Name = "lbTenDangNhap"
        Me.lbTenDangNhap.Size = New System.Drawing.Size(151, 25)
        Me.lbTenDangNhap.TabIndex = 5
        Me.lbTenDangNhap.Text = "Tên đăng nhập:"
        '
        'txtBoxNhapLaiMatKhau
        '
        Me.txtBoxNhapLaiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxNhapLaiMatKhau.Location = New System.Drawing.Point(252, 153)
        Me.txtBoxNhapLaiMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxNhapLaiMatKhau.Name = "txtBoxNhapLaiMatKhau"
        Me.txtBoxNhapLaiMatKhau.Size = New System.Drawing.Size(255, 30)
        Me.txtBoxNhapLaiMatKhau.TabIndex = 11
        Me.txtBoxNhapLaiMatKhau.UseSystemPasswordChar = True
        '
        'lbNhapLaiMatKhau
        '
        Me.lbNhapLaiMatKhau.AutoSize = True
        Me.lbNhapLaiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNhapLaiMatKhau.Location = New System.Drawing.Point(38, 157)
        Me.lbNhapLaiMatKhau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau"
        Me.lbNhapLaiMatKhau.Size = New System.Drawing.Size(174, 25)
        Me.lbNhapLaiMatKhau.TabIndex = 10
        Me.lbNhapLaiMatKhau.Text = "Nhập lại mật khẩu:"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(286, 32)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(143, 35)
        Me.lblTieuDe.TabIndex = 51
        Me.lblTieuDe.Text = "Đăng Ký"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtBoxTenDangNhap)
        Me.GroupBox1.Controls.Add(Me.lbTenDangNhap)
        Me.GroupBox1.Controls.Add(Me.txtBoxNhapLaiMatKhau)
        Me.GroupBox1.Controls.Add(Me.lbMatKhau)
        Me.GroupBox1.Controls.Add(Me.lbNhapLaiMatKhau)
        Me.GroupBox1.Controls.Add(Me.txtMatKhau)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 206)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin đăng ký"
        '
        'btnDangKy
        '
        Me.btnDangKy.BackColor = System.Drawing.Color.Snow
        Me.btnDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangKy.ForeColor = System.Drawing.Color.IndianRed
        Me.btnDangKy.Image = CType(resources.GetObject("btnDangKy.Image"), System.Drawing.Image)
        Me.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDangKy.Location = New System.Drawing.Point(452, 308)
        Me.btnDangKy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(179, 74)
        Me.btnDangKy.TabIndex = 9
        Me.btnDangKy.Text = "Nhập"
        Me.btnDangKy.UseVisualStyleBackColor = False
        '
        'frmDangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(662, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnDangKy)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDangKy"
        Me.Text = "Đăng kí"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDangKy As Button
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents lbMatKhau As Label
    Friend WithEvents txtBoxTenDangNhap As TextBox
    Friend WithEvents lbTenDangNhap As Label
    Friend WithEvents txtBoxNhapLaiMatKhau As TextBox
    Friend WithEvents lbNhapLaiMatKhau As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
