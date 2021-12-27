Public Class SachDTO
    Private strMaSach As String
    Private strTenSach As String
    Private strMaLoaiSach As String
    Private strMaTacGia As String
    Private strMaNhaXuatBan As String
    Private dtNamXuatBan As DateTime
    Private dtNgayNhap As DateTime
    Private intTriGia As Integer
    Private strMaTinhTrangSach As String

    Public Sub New()

    End Sub

    Public Sub New(strMaSach As String, strTenSach As String, strMaLoaiSach As String, strMaTacGia As String, strMaNhaXuatBan As String, dtNamXuatBan As Date, dtNgayNhap As Date, intTriGia As Integer, strMaTinhTrangSach As String)
        Me.strMaSach = strMaSach
        Me.strTenSach = strTenSach
        Me.strMaLoaiSach = strMaLoaiSach
        Me.strMaTacGia = strMaTacGia
        Me.strMaNhaXuatBan = strMaNhaXuatBan
        Me.dtNamXuatBan = dtNamXuatBan
        Me.dtNgayNhap = dtNgayNhap
        Me.intTriGia = intTriGia
        Me.strMaTinhTrangSach = strMaTinhTrangSach
    End Sub



    Public Property maSach As String
        Get
            Return strMaSach
        End Get
        Set(value As String)
            strMaSach = value
        End Set
    End Property

    Public Property tenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property maLoaiSach As String
        Get
            Return strMaLoaiSach
        End Get
        Set(value As String)
            strMaLoaiSach = value
        End Set
    End Property

    Public Property maNhaXuatBan As String
        Get
            Return strMaNhaXuatBan
        End Get
        Set(value As String)
            strMaNhaXuatBan = value
        End Set
    End Property

    Public Property namXuatBan As DateTime
        Get
            Return dtNamXuatBan
        End Get
        Set(value As DateTime)
            dtNamXuatBan = value
        End Set
    End Property

    Public Property ngayNhap As Date
        Get
            Return dtNgayNhap
        End Get
        Set(value As Date)
            dtNgayNhap = value
        End Set
    End Property

    Public Property triGia As Integer
        Get
            Return intTriGia
        End Get
        Set(value As Integer)
            intTriGia = value
        End Set
    End Property

    Public Property MaTinhTrangSach As String
        Get
            Return strMaTinhTrangSach
        End Get
        Set(value As String)
            strMaTinhTrangSach = value
        End Set
    End Property



    Public Property maTacGia As String
        Get
            Return strMaTacGia
        End Get
        Set(value As String)
            strMaTacGia = value
        End Set
    End Property
End Class
