<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiupDo
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
        Me.gbNhom = New System.Windows.Forms.GroupBox()
        Me.lbMember1 = New System.Windows.Forms.Label()
        Me.lbChiTiet = New System.Windows.Forms.Label()
        Me.lbEnDoAn = New System.Windows.Forms.Label()
        Me.gbGVHD = New System.Windows.Forms.GroupBox()
        Me.lbGVHD1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbNhom.SuspendLayout()
        Me.gbGVHD.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbNhom
        '
        Me.gbNhom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbNhom.Controls.Add(Me.lbMember1)
        Me.gbNhom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNhom.Location = New System.Drawing.Point(374, 234)
        Me.gbNhom.Name = "gbNhom"
        Me.gbNhom.Size = New System.Drawing.Size(338, 208)
        Me.gbNhom.TabIndex = 0
        Me.gbNhom.TabStop = False
        Me.gbNhom.Text = "Nhóm thực hiện"
        '
        'lbMember1
        '
        Me.lbMember1.AutoSize = True
        Me.lbMember1.Location = New System.Drawing.Point(6, 33)
        Me.lbMember1.Name = "lbMember1"
        Me.lbMember1.Size = New System.Drawing.Size(246, 20)
        Me.lbMember1.TabIndex = 1
        Me.lbMember1.Text = "Trương Hoàng Khang - 16520570"
        '
        'lbChiTiet
        '
        Me.lbChiTiet.AutoSize = True
        Me.lbChiTiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChiTiet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbChiTiet.Location = New System.Drawing.Point(370, 215)
        Me.lbChiTiet.Name = "lbChiTiet"
        Me.lbChiTiet.Size = New System.Drawing.Size(185, 16)
        Me.lbChiTiet.TabIndex = 1
        Me.lbChiTiet.Text = "Để biết thêm chi tiết, xin liên hệ"
        '
        'lbEnDoAn
        '
        Me.lbEnDoAn.AutoSize = True
        Me.lbEnDoAn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnDoAn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbEnDoAn.Location = New System.Drawing.Point(12, 16)
        Me.lbEnDoAn.Name = "lbEnDoAn"
        Me.lbEnDoAn.Size = New System.Drawing.Size(305, 48)
        Me.lbEnDoAn.TabIndex = 2
        Me.lbEnDoAn.Text = "ĐỒ ÁN MÔN HỌC" & Global.Microsoft.VisualBasic.ChrW(13) & "PHƯƠNG PHÁP MÔ HÌNH HÓA"
        '
        'gbGVHD
        '
        Me.gbGVHD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbGVHD.Controls.Add(Me.lbGVHD1)
        Me.gbGVHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGVHD.Location = New System.Drawing.Point(16, 234)
        Me.gbGVHD.Name = "gbGVHD"
        Me.gbGVHD.Size = New System.Drawing.Size(338, 208)
        Me.gbGVHD.TabIndex = 3
        Me.gbGVHD.TabStop = False
        Me.gbGVHD.Text = "Giảng viên hướng dẫn"
        '
        'lbGVHD1
        '
        Me.lbGVHD1.AutoSize = True
        Me.lbGVHD1.Location = New System.Drawing.Point(34, 43)
        Me.lbGVHD1.Name = "lbGVHD1"
        Me.lbGVHD1.Size = New System.Drawing.Size(174, 20)
        Me.lbGVHD1.TabIndex = 1
        Me.lbGVHD1.Text = "Thầy Vũ Thanh Nguyên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(232, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ĐỀ TÀI: QUẢN LÝ THƯ VIỆN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lớp: SE101.J12.PMCL"
        '
        'frmGiupDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 496)
        Me.Controls.Add(Me.gbGVHD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbEnDoAn)
        Me.Controls.Add(Me.lbChiTiet)
        Me.Controls.Add(Me.gbNhom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGiupDo"
        Me.Text = "Giúp đỡ"
        Me.gbNhom.ResumeLayout(False)
        Me.gbNhom.PerformLayout()
        Me.gbGVHD.ResumeLayout(False)
        Me.gbGVHD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbNhom As GroupBox
    Friend WithEvents lbMember1 As Label
    Friend WithEvents lbChiTiet As Label
    Friend WithEvents lbEnDoAn As Label
    Friend WithEvents gbGVHD As GroupBox
    Friend WithEvents lbGVHD1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
