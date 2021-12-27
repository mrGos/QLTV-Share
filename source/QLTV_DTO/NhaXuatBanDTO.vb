Public Class NhaXuatBanDTO
    Private strMaNhaXuatBan As String
    Private strTenNhaXuatBan As String
    Public Sub New()

    End Sub
    Public Sub New(strmNxb As String, strNxb As String)
        Me.strMaNhaXuatBan = strmNxb
        Me.strTenNhaXuatBan = strNxb
    End Sub

    Public Property MaNhaXuatBan As String
        Get
            Return strMaNhaXuatBan
        End Get
        Set(value As String)
            strMaNhaXuatBan = value
        End Set
    End Property

    Public Property TenNhaXuatBan As String
        Get
            Return strTenNhaXuatBan
        End Get
        Set(value As String)
            strTenNhaXuatBan = value
        End Set
    End Property
End Class
