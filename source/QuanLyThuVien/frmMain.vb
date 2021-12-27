Public Class frmMain
    Private WithEvents m_MdiClient As MdiClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                m_MdiClient = DirectCast(ctrl, MdiClient)
                Exit For
            End If
        Next ctrl

        m_MdiClient.BackgroundImage = QuanLyThuVien.My.Resources.bg
        m_MdiClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch

        LưuToolStripMenuItem.Enabled = False
        BáoCáoToolStripMenuItem.Enabled = False
        ĐăngXuấtToolStripMenuItem.Enabled = False
        QuyĐịnhToolStripMenuItem.Enabled = False

    End Sub

    Private Sub LậpThẻĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpThẻĐộcGiảToolStripMenuItem.Click
        Dim frm As frmLapTheDocGia = New frmLapTheDocGia
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NhậpSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpSáchToolStripMenuItem.Click
        Dim frm As frmNhapSach = New frmNhapSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ChoMuonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChoMuonToolStripMenuItem.Click
        Dim frm As frmPhieuMuonSach = New frmPhieuMuonSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LoaiSachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSachToolStripMenuItem.Click
        Dim frm As frmQuanLyLoaiSach = New frmQuanLyLoaiSach()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TacGiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TacGiaToolStripMenuItem.Click
        Dim frm As frmQuanLyTacGia = New frmQuanLyTacGia()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NhaXuâtBanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhaXuâtBanToolStripMenuItem.Click
        Dim frm As frmQuanLyNhaXuatBan = New frmQuanLyNhaXuatBan()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SachTraTrễToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SachTraTrễToolStripMenuItem.Click
        Dim frm As frmBaoCaoSachTraTreGUI = New frmBaoCaoSachTraTreGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TinhHinhMươnSachTheoThêLoaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TinhHinhMươnSachTheoThêLoaiToolStripMenuItem.Click
        Dim frm As frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI = New frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyĐịnhToolStripMenuItem.Click
        Dim frm As frmQuyDinh = New frmQuyDinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NhậnTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậnTrảSáchToolStripMenuItem.Click
        Dim frm As frmNhanTraSach = New frmNhanTraSach()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TraCứuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuToolStripMenuItem.Click
        Dim frm As frmTraCuu = New frmTraCuu()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýPhiếuMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuMượnSáchToolStripMenuItem.Click
        Dim frm As frmQuanLyPhieuMuonSach = New frmQuanLyPhieuMuonSach
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThôngTinNhómVàPhầnMềmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinNhómVàPhầnMềmToolStripMenuItem.Click
        Dim frm As frmGiupDo = New frmGiupDo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        Dim frm As frmDangNhap = New frmDangNhap
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        ĐăngNhậpToolStripMenuItem.Enabled = True
        ĐăngXuấtToolStripMenuItem.Enabled = False
        LưuToolStripMenuItem.Enabled = False
        BáoCáoToolStripMenuItem.Enabled = False
        ĐăngXuấtToolStripMenuItem.Enabled = False
        QuyĐịnhToolStripMenuItem.Enabled = False
    End Sub
End Class
