Public Class DocGiaDTO
    Private strMaDocGia As String
    Private strHoTen As String
    Private strMaLoaiDocGia As String
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgaySinh As DateTime
    Private dateNgayLapThe As DateTime
    Private dateNgayHetHan As DateTime
    Private iSoSachDangMuon As Integer
    Private strTinhTrangThe As String
    Public Sub New()
    End Sub

    Public Sub New(iMaDocGia As String, strHoTen As String, strMaLoaiDocGia As String, strDiaChi As String, strEmail As String, dateNgaySinh As Date, dateNgayLapThe As Date, dateNgayHetHan As DateTime, iSoSachDangMuon As Integer, strTinhTrangThe As String)
        Me.strMaDocGia = iMaDocGia
        Me.strHoTen = strHoTen
        Me.strMaLoaiDocGia = strMaLoaiDocGia
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgaySinh = dateNgaySinh
        Me.dateNgayLapThe = dateNgayLapThe
        Me.dateNgayHetHan = dateNgayHetHan
        Me.iSoSachDangMuon = iSoSachDangMuon
        Me.strTinhTrangThe = strTinhTrangThe
    End Sub

    Public Property MaDocGia As String
        Get
            Return strMaDocGia
        End Get
        Set(value As String)
            strMaDocGia = value
        End Set
    End Property

    Public Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property MaLoaiDocGia As String
        Get
            Return strMaLoaiDocGia
        End Get
        Set(value As String)
            strMaLoaiDocGia = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property NgaySinh As Date
        Get
            Return dateNgaySinh
        End Get
        Set(value As Date)
            dateNgaySinh = value
        End Set
    End Property

    Public Property NgayLapThe As Date
        Get
            Return dateNgayLapThe
        End Get
        Set(value As Date)
            dateNgayLapThe = value
        End Set
    End Property

    Public Property NgayHetHan As Date
        Get
            Return dateNgayHetHan
        End Get
        Set(value As Date)
            dateNgayHetHan = value
        End Set
    End Property

    Public Property SoSachDangMuon As Integer
        Get
            Return iSoSachDangMuon
        End Get
        Set(value As Integer)
            iSoSachDangMuon = value
        End Set
    End Property

    Public Property TinhTrangThe As String
        Get
            Return strTinhTrangThe
        End Get
        Set(value As String)
            strTinhTrangThe = value
        End Set
    End Property
End Class
