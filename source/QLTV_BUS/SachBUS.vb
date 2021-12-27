Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility


Public Class SachBUS
    Private qdDTO As QuyDinhDTO
    Private qdBUS As QuyDinhBUS
    Private sachDAL As SachDAL
    Public Sub New()
        sachDAL = New SachDAL()
        qdBUS = New QuyDinhBUS()
        Dim result As Result
        result = qdBUS.selectQuyDinh(qdDTO)
        If (result.FlagResult = False) Then
            qdDTO = New QuyDinhDTO(18, 55, 6, 8, 5, 4)
        End If
    End Sub
    Public Sub New(connectionString As String)
        qdBUS = New QuyDinhBUS()
        Dim result As Result
        result = qdBUS.selectQuyDinh(qdDTO)
        If (result.FlagResult = False) Then
            qdDTO = New QuyDinhDTO(18, 55, 6, 8, 5, 4)
        End If
        sachDAL = New SachDAL(connectionString)
    End Sub

    Public Function BuildMS(ByRef nextMS As String) As Result

        Return sachDAL.buildMS(nextMS)
    End Function

    Public Function checkName(sDTO As SachDTO) As Boolean
        If (sDTO.tenSach = String.Empty) Then
            Return False
        End If
        Return True
    End Function

    Public Function isDifferent(sDTO1 As SachDTO, sDTO2 As SachDTO) As Boolean

        If (sDTO1.maSach <> sDTO2.maSach) Then
            Return True
        End If
        If (sDTO1.tenSach <> sDTO2.tenSach) Then
            Return True
        End If
        If (sDTO1.maLoaiSach <> sDTO2.maLoaiSach) Then
            Return True
        End If
        If (sDTO1.maNhaXuatBan <> sDTO2.maNhaXuatBan) Then
            Return True
        End If
        If (sDTO1.namXuatBan <> sDTO2.namXuatBan) Then
            Return True
        End If
        If (sDTO1.ngayNhap <> sDTO2.ngayNhap) Then
            Return True
        End If
        If (sDTO1.triGia <> sDTO2.triGia) Then
            Return True
        End If

        Return False
    End Function
    Public Function isValid(sach As SachDTO) As Boolean

        If (sach.maLoaiSach.Length < 1) Then
            Return False
        End If

        If (sach.maSach.Length < 1) Then
            Return False
        End If

        If (sach.maTacGia.Length < 1) Then
            Return False
        End If

        If (sach.maNhaXuatBan.Length < 1) Then
            Return False
        End If
        If (sach.tenSach.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(sachDTO As SachDTO) As Result

        Return sachDAL.insert(sachDTO)
    End Function

    Public Function delete(maSach As String) As Result

        Return sachDAL.delete(maSach)
    End Function

    Public Function deleteAll() As Result

        Return sachDAL.deleteAll()
    End Function

    Public Function update(sDTO As SachDTO) As Result

        Return sachDAL.update(sDTO)
    End Function

    Public Function load(masach As String, ByRef sach As SachDTO) As Result

        Return sachDAL.load(masach, sach)
    End Function

    Public Function selectAll(ByRef listSach As List(Of SachDTO)) As Result

        Return sachDAL.selectAll(listSach)
    End Function

    Public Function selectAll(ByRef tableSach As DataTable) As Result

        Return sachDAL.selectAll(tableSach)
    End Function

    Public Function selectAllByStatus(strMaTT As String, ByRef listSach As List(Of SachDTO)) As Result

        Return sachDAL.selectAllByStatus(strMaTT, listSach)
    End Function

    Public Function checkNamXuatBan(sach As SachDTO) As Boolean
        If (Integer.Parse(DateTime.Now.Year.ToString) - Integer.Parse(sach.namXuatBan.Year.ToString) <= qdDTO.khoangNamXuatBan) Then
            Return True
        End If
        Return False
    End Function

    Public Function selectWithFilter(ByRef listsach As List(Of SachDTO), column As String, filter As String) As Result

        Return sachDAL.selectWithFilter(listsach, column, filter)
    End Function
    'Update 30/06/2018 -- QLPMS
    Public Function update_TT(mas As String, maTT As String) As Result
        Return sachDAL.update_TT(mas, maTT)
    End Function
End Class
