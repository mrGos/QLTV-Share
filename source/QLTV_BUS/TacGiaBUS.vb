Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class TacGiaBUS
    Private tacGiaDAL As TacGiaDAL
    Public Sub New()
        tacGiaDAL = New TacGiaDAL()
    End Sub

    Public Sub New(connectString As String)
        tacGiaDAL = New TacGiaDAL(connectString)
    End Sub

    Public Function selectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result

        Return tacGiaDAL.selectAll(listTacGia)
    End Function


    Public Function isValidName(tg As TacGiaDTO) As Boolean

        If (tg.tenTacGia.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidCount() As Boolean

        If (count() >= 100) Then
            Return False
        End If

        Return True

    End Function

    Public Function count() As Integer
        Return tacGiaDAL.selectCount()
    End Function
    Public Function insert(tg As TacGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tacGiaDAL.insert(tg)
    End Function
    Public Function update(lhs As TacGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tacGiaDAL.update(lhs)
    End Function
    Public Function delete(maLoai As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tacGiaDAL.delete(maLoai)
    End Function

    Public Function getNextID(ByRef nextID As String) As Result
        Return tacGiaDAL.getNextID(nextID)
    End Function
End Class
