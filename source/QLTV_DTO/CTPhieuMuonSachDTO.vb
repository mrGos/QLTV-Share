Public Class CTPhieuMuonSachDTO
    Private strMaCTPhieuMuonSach As String
    Private strMaPhieuMuonSach As String
    Private strMaSach As String
    Private strGhiChu As String

    Public Sub New()

    End Sub

    Public Sub New(strMaCTPhieuMuonSach As String, strMaPhieuMuonSach As String, strMaSach As String)
        Me.strMaCTPhieuMuonSach = strMaCTPhieuMuonSach
        Me.strMaPhieuMuonSach = strMaPhieuMuonSach
        Me.strMaSach = strMaSach
    End Sub

    Public Sub New(strMaCTPhieuMuonSach As String, strMaPhieuMuonSach As String, strMaSach As String, strGhiChu As String)
        Me.strMaCTPhieuMuonSach = strMaCTPhieuMuonSach
        Me.strMaPhieuMuonSach = strMaPhieuMuonSach
        Me.strMaSach = strMaSach
        Me.strGhiChu = strGhiChu
    End Sub

    Public Property MaCTPhieuMuonSach As String
        Get
            Return strMaCTPhieuMuonSach
        End Get
        Set(value As String)
            strMaCTPhieuMuonSach = value
        End Set
    End Property

    Public Property MaPhieuMuonSach As String
        Get
            Return strMaPhieuMuonSach
        End Get
        Set(value As String)
            strMaPhieuMuonSach = value
        End Set
    End Property

    Public Property MaSach As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property GhiChu As String
        Get
            Return strGhiChu
        End Get
        Set(value As String)
            strGhiChu = value
        End Set
    End Property
End Class
