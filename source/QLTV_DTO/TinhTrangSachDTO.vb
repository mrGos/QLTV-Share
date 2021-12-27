Public Class TinhTrangSachDTO
    Private strMaTinhTrangSach As String
    Private strTenTinhTrangSach As String

    Public Sub New()

    End Sub
    Public Sub New(strMaTinhTrangSach As String, strTenTinhTrangSach As String)
        Me.strMaTinhTrangSach = strMaTinhTrangSach
        Me.strTenTinhTrangSach = strTenTinhTrangSach
    End Sub

    Public Property MaTinhTrangSach As String
        Get
            Return strMaTinhTrangSach
        End Get
        Set(value As String)
            strMaTinhTrangSach = value
        End Set
    End Property

    Public Property TenTinhTrangSach As String
        Get
            Return strTenTinhTrangSach
        End Get
        Set(value As String)
            strTenTinhTrangSach = value
        End Set
    End Property
End Class
