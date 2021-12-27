Public Class PhieuMuonSachDTO
    Private strMaPhieuMuon As String
    Private strMaDocGia As String
    Private dateNgayMuon As DateTime
    Private dateNgayTra As DateTime

    Public Sub New()

    End Sub
    Public Sub New(strMaPhieuMuon As String, strMaDocGia As String, dateNgayMuon As Date, dateNgayTra As Date)
        Me.strMaPhieuMuon = strMaPhieuMuon
        Me.strMaDocGia = strMaDocGia
        Me.dateNgayMuon = dateNgayMuon
        Me.dateNgayTra = dateNgayTra
    End Sub

    Public Property MaPhieuMuonSach As String
        Get
            Return strMaPhieuMuon
        End Get
        Set(value As String)
            strMaPhieuMuon = value
        End Set
    End Property

    Public Property MaDocGia As String
        Get
            Return strMaDocGia
        End Get
        Set(value As String)
            strMaDocGia = value
        End Set
    End Property

    Public Property NgayMuon As Date
        Get
            Return dateNgayMuon
        End Get
        Set(value As Date)
            dateNgayMuon = value
        End Set
    End Property

    Public Property NgayTra As Date
        Get
            Return dateNgayTra
        End Get
        Set(value As Date)
            dateNgayTra = value
        End Set
    End Property
End Class
