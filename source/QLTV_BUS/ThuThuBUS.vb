Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class ThuThuBUS
    Private ttDAL As ThuThuDAL
    Public Sub New()
        ttDAL = New ThuThuDAL()
    End Sub
    Public Sub New(connectionString As String)
        ttDAL = New ThuThuDAL(connectionString)
    End Sub

    Public Function checkSignIn(strTK, strMK, strReMK) As Boolean
        If (strTK = String.Empty) Then
            Return False
        End If

        If (strMK = String.Empty) Then
            Return False
        End If

        If (strReMK <> strMK) Then
            Return False
        End If
        Return True
    End Function

    Public Function insert(ThuThu As ThuThuDTO)
        Return ttDAL.insert(ThuThu)
    End Function

    Public Function selectALL(ThuThu As ThuThuDTO)
        Return ttDAL.selectALL(ThuThu)
    End Function

    Public Function checkValidThuThu(tt As ThuThuDTO) As Boolean
        If (tt.TaiKhoan = String.Empty) Then
            Return False
        End If

        If (tt.MatKhau = String.Empty) Then
            Return False
        End If

        Return True
    End Function
End Class
