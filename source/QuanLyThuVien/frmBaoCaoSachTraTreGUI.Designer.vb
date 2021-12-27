<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCaoSachTraTreGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCaoSachTraTreGUI))
        Me.dgvBaoCaoSachTraTre = New System.Windows.Forms.DataGridView()
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXuatExcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvBaoCaoSachTraTre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBaoCaoSachTraTre
        '
        Me.dgvBaoCaoSachTraTre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBaoCaoSachTraTre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvBaoCaoSachTraTre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBaoCaoSachTraTre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvBaoCaoSachTraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoSachTraTre.Location = New System.Drawing.Point(83, 226)
        Me.dgvBaoCaoSachTraTre.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBaoCaoSachTraTre.MultiSelect = False
        Me.dgvBaoCaoSachTraTre.Name = "dgvBaoCaoSachTraTre"
        Me.dgvBaoCaoSachTraTre.ReadOnly = True
        Me.dgvBaoCaoSachTraTre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBaoCaoSachTraTre.RowHeadersVisible = False
        Me.dgvBaoCaoSachTraTre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBaoCaoSachTraTre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBaoCaoSachTraTre.Size = New System.Drawing.Size(997, 400)
        Me.dgvBaoCaoSachTraTre.TabIndex = 4
        '
        'dtpNgay
        '
        Me.dtpNgay.CustomFormat = ""
        Me.dtpNgay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgay.Location = New System.Drawing.Point(450, 37)
        Me.dtpNgay.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(194, 27)
        Me.dtpNgay.TabIndex = 47
        Me.dtpNgay.Value = New Date(2018, 5, 28, 7, 28, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Ngày"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(847, 40)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Báo Cáo Thống Kê Tình Hình Mượn Sách Trả Trễ"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Snow
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.IndianRed
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(83, 645)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(207, 66)
        Me.btnThoat.TabIndex = 50
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnXuatExcel
        '
        Me.btnXuatExcel.BackColor = System.Drawing.Color.Snow
        Me.btnXuatExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXuatExcel.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnXuatExcel.Image = CType(resources.GetObject("btnXuatExcel.Image"), System.Drawing.Image)
        Me.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXuatExcel.Location = New System.Drawing.Point(873, 645)
        Me.btnXuatExcel.Name = "btnXuatExcel"
        Me.btnXuatExcel.Size = New System.Drawing.Size(207, 66)
        Me.btnXuatExcel.TabIndex = 50
        Me.btnXuatExcel.Text = "Xuất EXCEL"
        Me.btnXuatExcel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dtpNgay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(997, 88)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bộ lọc:"
        '
        'frmBaoCaoSachTraTreGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1151, 732)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnXuatExcel)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBaoCaoSachTraTre)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBaoCaoSachTraTreGUI"
        Me.Text = "Báo cáo Sách trả trễ"
        CType(Me.dgvBaoCaoSachTraTre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBaoCaoSachTraTre As DataGridView
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXuatExcel As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
