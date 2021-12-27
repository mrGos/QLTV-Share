Public Class LoaiSachDTO
    Private strMaLoai As String
    Private strTenLoai As String
    Public Sub New()

    End Sub

    Public Sub New(iMaLoai As String, strTenLoai As String)
        Me.strMaLoai = iMaLoai
        Me.strTenLoai = strTenLoai
    End Sub

    Public Property MaLoai As String
        Get
            Return strMaLoai
        End Get
        Set(value As String)
            strMaLoai = value
        End Set
    End Property

    Public Property TenLoai As String
        Get
            Return strTenLoai
        End Get
        Set(value As String)
            strTenLoai = value
        End Set
    End Property
End Class
