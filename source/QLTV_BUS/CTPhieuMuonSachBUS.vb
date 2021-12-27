Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility
Public Class CTPhieuMuonSachBUS
    Private ctPMSDAL As CTPhieuMuonSachDAL
    Public Sub New()
        ctPMSDAL = New CTPhieuMuonSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctPMSDAL = New CTPhieuMuonSachDAL(connectionString)
    End Sub

    Public Function BuildMS(ByRef nextMS As String) As Result

        Return ctPMSDAL.buildMS(nextMS)
    End Function
    Public Function insert(CTPhieuMuonSachDTO As CTPhieuMuonSachDTO) As Result

        Return ctPMSDAL.insert(CTPhieuMuonSachDTO)
    End Function
    Public Function update(ct As CTPhieuMuonSachDTO) As Result

        Return ctPMSDAL.UpdateCTPMS(ct)
    End Function
    Public Function delete(maCTPhieuMuonSach As String) As Result

        Return ctPMSDAL.delete(maCTPhieuMuonSach)
    End Function


    Public Function selectAll(ByRef listCTPhieuMuonSach As List(Of CTPhieuMuonSachDTO)) As Result

        Return ctPMSDAL.selectAll(listCTPhieuMuonSach)
    End Function

    Public Function selectAll_ByMaPM(mpm As String, ByRef listCTPhieuMuonSach As List(Of CTPhieuMuonSachDTO)) As Result
        Return ctPMSDAL.selectAll_ByMaPM(mpm, listCTPhieuMuonSach)
    End Function


End Class
