Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class PhieuMuonSachBUS
    Private PMSDAL As PhieuMuonSachDAL
    Public Sub New()
        PMSDAL = New PhieuMuonSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        PMSDAL = New PhieuMuonSachDAL(connectionString)
    End Sub

    Public Function BuildMS(ByRef nextMS As String) As Result

        Return PMSDAL.buildMS(nextMS)
    End Function
    Public Function insert(PhieuMuonSachDTO As PhieuMuonSachDTO) As Result

        Return PMSDAL.insert(PhieuMuonSachDTO)
    End Function

    Public Function delete(maPhieuMuonSach As String) As Result

        Return PMSDAL.delete(maPhieuMuonSach)
    End Function


    Public Function selectAll(ByRef listPhieuMuonSach As List(Of PhieuMuonSachDTO)) As Result

        Return PMSDAL.selectAll(listPhieuMuonSach)
    End Function

    Public Function selectAllForTraCuu(ByRef pm As DataTable) As Result

        Return PMSDAL.selectAllForTraCuu(pm)
    End Function
    Public Function update(pm As PhieuMuonSachDTO) As Result

        Return PMSDAL.update(pm)
    End Function
    'Update 1/7/2018
    Public Function checkSameText(txtOne As String, txtTwo As String) As Boolean
        If (txtOne = txtTwo) Then
            Return True
        End If
        Return False
    End Function

    Public Function checkValidGhiChu(txtInput As String, txtCompare1 As String, txtCompare2 As String, txtCompare3 As String) As Boolean
        If (txtInput = txtCompare1) Then
            Return True
        End If

        If (txtInput = txtCompare2) Then
            Return True
        End If

        If (txtInput = txtCompare3) Then
            Return True
        End If

        Return False
    End Function


    Public Function isSachTraTre() As Boolean
        Return PMSDAL.isSachTraTre()
    End Function

    Public Function isNgayTraHopLe(ngaytra As DateTime, ngaymuon As DateTime, qd As QuyDinhDTO) As Boolean
        Dim span As New TimeSpan
        span = ngaytra.Subtract(ngaymuon)
        Dim songay = Convert.ToInt32(span.TotalDays)
        If (songay <= qd.SoNgayMuonToiDa And songay > 0) Then
            Return True
        End If
    End Function

    Public Function NTGreaterThanNM(ngaytra As DateTime, ngaymuon As DateTime) As Boolean
        Dim span As New TimeSpan
        span = ngaytra.Subtract(ngaymuon)
        Dim songay = Convert.ToInt32(span.TotalDays)
        If (songay > 0) Then
            Return True
        End If
    End Function
End Class
