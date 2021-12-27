<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI))
        Me.dgvBaoCaoTHMSTTL = New System.Windows.Forms.DataGridView()
        Me.nudThang = New System.Windows.Forms.NumericUpDown()
        Me.labelThang = New System.Windows.Forms.Label()
        Me.nudNam = New System.Windows.Forms.NumericUpDown()
        Me.ButtonXuatExcel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTong = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvBaoCaoTHMSTTL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBaoCaoTHMSTTL
        '
        Me.dgvBaoCaoTHMSTTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBaoCaoTHMSTTL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvBaoCaoTHMSTTL.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBaoCaoTHMSTTL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBaoCaoTHMSTTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoTHMSTTL.Location = New System.Drawing.Point(113, 204)
        Me.dgvBaoCaoTHMSTTL.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBaoCaoTHMSTTL.MultiSelect = False
        Me.dgvBaoCaoTHMSTTL.Name = "dgvBaoCaoTHMSTTL"
        Me.dgvBaoCaoTHMSTTL.ReadOnly = True
        Me.dgvBaoCaoTHMSTTL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBaoCaoTHMSTTL.RowHeadersVisible = False
        Me.dgvBaoCaoTHMSTTL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBaoCaoTHMSTTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBaoCaoTHMSTTL.Size = New System.Drawing.Size(960, 299)
        Me.dgvBaoCaoTHMSTTL.TabIndex = 3
        '
        'nudThang
        '
        Me.nudThang.Location = New System.Drawing.Point(431, 30)
        Me.nudThang.Margin = New System.Windows.Forms.Padding(4)
        Me.nudThang.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudThang.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudThang.Name = "nudThang"
        Me.nudThang.Size = New System.Drawing.Size(52, 22)
        Me.nudThang.TabIndex = 5
        Me.nudThang.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'labelThang
        '
        Me.labelThang.AutoSize = True
        Me.labelThang.Location = New System.Drawing.Point(372, 32)
        Me.labelThang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelThang.Name = "labelThang"
        Me.labelThang.Size = New System.Drawing.Size(49, 17)
        Me.labelThang.TabIndex = 6
        Me.labelThang.Text = "Tháng"
        '
        'nudNam
        '
        Me.nudNam.Location = New System.Drawing.Point(491, 30)
        Me.nudNam.Margin = New System.Windows.Forms.Padding(4)
        Me.nudNam.Maximum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.nudNam.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.nudNam.Name = "nudNam"
        Me.nudNam.Size = New System.Drawing.Size(131, 22)
        Me.nudNam.TabIndex = 7
        Me.nudNam.Value = New Decimal(New Integer() {1980, 0, 0, 0})
        '
        'ButtonXuatExcel
        '
        Me.ButtonXuatExcel.BackColor = System.Drawing.Color.Snow
        Me.ButtonXuatExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXuatExcel.ForeColor = System.Drawing.Color.ForestGreen
        Me.ButtonXuatExcel.Image = CType(resources.GetObject("ButtonXuatExcel.Image"), System.Drawing.Image)
        Me.ButtonXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonXuatExcel.Location = New System.Drawing.Point(860, 565)
        Me.ButtonXuatExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonXuatExcel.Name = "ButtonXuatExcel"
        Me.ButtonXuatExcel.Size = New System.Drawing.Size(213, 68)
        Me.ButtonXuatExcel.TabIndex = 8
        Me.ButtonXuatExcel.Text = "Xuất Excel"
        Me.ButtonXuatExcel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(986, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tổng:"
        '
        'txtTong
        '
        Me.txtTong.AutoSize = True
        Me.txtTong.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTong.Location = New System.Drawing.Point(1049, 516)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Size = New System.Drawing.Size(21, 22)
        Me.txtTong.TabIndex = 10
        Me.txtTong.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(841, 35)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Báo Cáo Thống Kê Tình Hình Mượn Sách Theo Thể Loại"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(113, 565)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(211, 68)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.labelThang)
        Me.GroupBox1.Controls.Add(Me.nudThang)
        Me.GroupBox1.Controls.Add(Me.nudNam)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 75)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bộ lọc"
        '
        'frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1140, 662)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTong)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonXuatExcel)
        Me.Controls.Add(Me.dgvBaoCaoTHMSTTL)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI"
        Me.Text = "Báo cáo mượn theo thể loại"
        CType(Me.dgvBaoCaoTHMSTTL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBaoCaoTHMSTTL As DataGridView
    Friend WithEvents nudThang As NumericUpDown
    Friend WithEvents labelThang As Label
    Friend WithEvents nudNam As NumericUpDown
    Friend WithEvents ButtonXuatExcel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTong As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
