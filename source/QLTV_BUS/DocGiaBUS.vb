Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL

    Public Sub New()

        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValid(dg As DocGiaDTO) As Boolean

        If (dg.HoTen.Length < 1) Then
            Return False
        End If

        If (dg.DiaChi.Length < 1) Then
            Return False
        End If

        If (dg.Email.Length < 1) Then
            Return False
        End If

        If (dg.TinhTrangThe.Length < 1) Then
            Return False
        End If


        Return True
    End Function

    Public Function insert(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(dg)
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(dg)
    End Function
    Public Function delete(maLoai As String) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaidg As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(listLoaidg)
    End Function

    Public Function selectAll(ByRef data As DataTable) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(data)
    End Function
    Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL_ByType(maLoai, listHocSinh)
    End Function
    Public Function selectDG_ByMa(maLoai As String, docgia As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectDG_ByMa(maLoai, docgia)
    End Function
    Public Function buildMSdg(ByRef nextMsdg As String) As Result
        Return dgDAL.buildMSDG(nextMsdg)
    End Function

    Public Function checkAge(docgia As DocGiaDTO, qd As QuyDinhDTO) As Boolean
        Dim tuoi As Integer = DateTime.Now.Year - docgia.NgaySinh.Year

        If (tuoi <= qd.TuoiToiDa) Then
            If (tuoi >= qd.TuoiToiThieu) Then
                Return True
            End If
        End If
        Return False
    End Function


    'Add 30/06/2018 QLMS
    Public Function updateReduceNumberOfBook(madg As String) As Result
        Return dgDAL.updateReduceNumberOfBook(madg)
    End Function
    Public Function updateIncreaseNumberOfBook(madg As String) As Result
        Return dgDAL.updateIncreaseNumberOfBook(madg)
    End Function

    Public Function MonthDifference(lValue As DateTime, rValue As DateTime) As Integer
        Return (lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year)
    End Function

    Public Function checkEXP(docgia As DocGiaDTO, qd As QuyDinhDTO) As Boolean
        Dim span As New TimeSpan
        span = docgia.NgayHetHan.Subtract(docgia.NgayLapThe)
        Dim sothang = (Convert.ToInt32(span.TotalDays / 30.436875))
        If (sothang <= qd.thoiHang And sothang > 0) Then
            Return True
        End If
        Return False
    End Function
End Class
