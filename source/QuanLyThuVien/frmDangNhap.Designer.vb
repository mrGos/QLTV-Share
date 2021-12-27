<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.lbTenDangNhap = New System.Windows.Forms.Label()
        Me.txtBoxTenDangNhap = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.lbMatKhau = New System.Windows.Forms.Label()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTenDangNhap
        '
        Me.lbTenDangNhap.AutoSize = True
        Me.lbTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenDangNhap.Location = New System.Drawing.Point(55, 60)
        Me.lbTenDangNhap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTenDangNhap.Name = "lbTenDangNhap"
        Me.lbTenDangNhap.Size = New System.Drawing.Size(151, 25)
        Me.lbTenDangNhap.TabIndex = 0
        Me.lbTenDangNhap.Text = "Tên đăng nhập:"
        '
        'txtBoxTenDangNhap
        '
        Me.txtBoxTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTenDangNhap.Location = New System.Drawing.Point(236, 56)
        Me.txtBoxTenDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxTenDangNhap.Name = "txtBoxTenDangNhap"
        Me.txtBoxTenDangNhap.Size = New System.Drawing.Size(255, 30)
        Me.txtBoxTenDangNhap.TabIndex = 1
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(236, 113)
        Me.txtMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(255, 30)
        Me.txtMatKhau.TabIndex = 2
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'lbMatKhau
        '
        Me.lbMatKhau.AutoSize = True
        Me.lbMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMatKhau.Location = New System.Drawing.Point(55, 116)
        Me.lbMatKhau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMatKhau.Name = "lbMatKhau"
        Me.lbMatKhau.Size = New System.Drawing.Size(99, 25)
        Me.lbMatKhau.TabIndex = 2
        Me.lbMatKhau.Text = "Mật khẩu:"
        '
        'btnDangNhap
        '
        Me.btnDangNhap.BackColor = System.Drawing.Color.Snow
        Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.ForeColor = System.Drawing.Color.IndianRed
        Me.btnDangNhap.Image = CType(resources.GetObject("btnDangNhap.Image"), System.Drawing.Image)
        Me.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDangNhap.Location = New System.Drawing.Point(408, 306)
        Me.btnDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(177, 79)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "        Đăng Nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = False
        '
        'btnDangKy
        '
        Me.btnDangKy.BackColor = System.Drawing.Color.Snow
        Me.btnDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangKy.ForeColor = System.Drawing.Color.IndianRed
        Me.btnDangKy.Image = CType(resources.GetObject("btnDangKy.Image"), System.Drawing.Image)
        Me.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDangKy.Location = New System.Drawing.Point(63, 305)
        Me.btnDangKy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(180, 79)
        Me.btnDangKy.TabIndex = 4
        Me.btnDangKy.Text = "    Đăng Ký"
        Me.btnDangKy.UseVisualStyleBackColor = False
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Century", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Black
        Me.lblTieuDe.Location = New System.Drawing.Point(240, 35)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(181, 35)
        Me.lblTieuDe.TabIndex = 50
        Me.lblTieuDe.Text = "Đăng Nhập"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbTenDangNhap)
        Me.GroupBox1.Controls.Add(Me.txtBoxTenDangNhap)
        Me.GroupBox1.Controls.Add(Me.lbMatKhau)
        Me.GroupBox1.Controls.Add(Me.txtMatKhau)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 190)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin đăng nhập"
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 413)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnDangKy)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDangNhap"
        Me.Text = "Đăng nhập"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTenDangNhap As Label
    Friend WithEvents txtBoxTenDangNhap As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents lbMatKhau As Label
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnDangKy As Button
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
