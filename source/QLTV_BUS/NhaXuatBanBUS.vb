Imports QLTV_DTO
Imports QLTV_DAL
Imports Utility

Public Class NhaXuatBanBUS

    Private nhaXuatBanDAL As NhaXuatBanDAL
    Public Sub New()
        nhaXuatBanDAL = New NhaXuatBanDAL()
    End Sub
    Public Sub New(connectionString As String)
        nhaXuatBanDAL = New NhaXuatBanDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listNhaXuatBan As List(Of NhaXuatBanDTO)) As Result

        Return nhaXuatBanDAL.selectAll(listNhaXuatBan)
    End Function

    Public Function isValidName(nxb As NhaXuatBanDTO) As Boolean

        If (nxb.TenNhaXuatBan.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(nxb As NhaXuatBanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nhaXuatBanDAL.insert(nxb)
    End Function
    Public Function update(lhs As NhaXuatBanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nhaXuatBanDAL.update(lhs)
    End Function
    Public Function delete(maLoai As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nhaXuatBanDAL.delete(maLoai)
    End Function

    Public Function getNextID(ByRef nextID As String) As Result
        Return nhaXuatBanDAL.getNextID(nextID)
    End Function
End Class
