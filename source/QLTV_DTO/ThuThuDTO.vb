Public Class ThuThuDTO

    Private strTaiKhoan As String
    Private strMatKhau As String

    Public Sub New()

    End Sub
    Public Sub New(strTaiKhoan As String, strMatKhau As String)
        Me.strTaiKhoan = strTaiKhoan
        Me.strMatKhau = strMatKhau
    End Sub

    Public Property TaiKhoan As String
        Get
            Return strTaiKhoan
        End Get
        Set(value As String)
            strTaiKhoan = value
        End Set
    End Property

    Public Property MatKhau As String
        Get
            Return strMatKhau
        End Get
        Set(value As String)
            strMatKhau = value
        End Set
    End Property
End Class
