Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class TinhTrangSachBUS
    Private ttDAL As TinhTrangSachDAL
    Public Sub New()
        ttDAL = New TinhTrangSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        ttDAL = New TinhTrangSachDAL(connectionString)
    End Sub

    Public Function isValidName(tt As TinhTrangSachDTO) As Boolean

        If (tt.TenTinhTrangSach.Length < 1) Then
            Return False
        End If

        Return True

    End Function



    Public Function insert(ls As TinhTrangSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttDAL.insert(ls)
    End Function
    Public Function update(ls As TinhTrangSachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttDAL.update(ls)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoais As List(Of TinhTrangSachDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ttDAL.selectALL(listLoais)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return ttDAL.getNextID(nextID)
    End Function
End Class
