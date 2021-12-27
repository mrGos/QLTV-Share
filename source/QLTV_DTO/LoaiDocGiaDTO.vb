Public Class LoaiDocGiaDTO
    Private srtMaLoaiDocGia As String
    Private strTenLoaiDocGia As String
    Public Sub New()
    End Sub

    Public Sub New(srtMaLoaiDocGia As String, strTenLoaiDocGia As String)
        Me.srtMaLoaiDocGia = srtMaLoaiDocGia
        Me.strTenLoaiDocGia = strTenLoaiDocGia
    End Sub

    Public Property MaLoaiDocGia As String
        Get
            Return srtMaLoaiDocGia
        End Get
        Set(value As String)
            srtMaLoaiDocGia = value
        End Set
    End Property

    Public Property TenLoaiDocGia As String
        Get
            Return strTenLoaiDocGia
        End Get
        Set(value As String)
            strTenLoaiDocGia = value
        End Set
    End Property
End Class
