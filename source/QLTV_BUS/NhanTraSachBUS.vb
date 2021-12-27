Imports QLTV_DAL
Imports Utility
Imports QLTV_DTO
Public Class NhanTraSachBUS
    Private tsDAL As NhanTraSachDAL
    Public Sub New()
        tsDAL = New NhanTraSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        tsDAL = New NhanTraSachDAL(connectionString)
    End Sub

    Public Function loadDSSachDangMuonByMaDocGia(mdg As String, ByRef data As DataTable) As Result
        Return tsDAL.loadDSSachDangMuonByMaDocGia(mdg, data)
    End Function
    Public Function loadListPMSDangMuonByMaDG(mdg As String, ByRef listPMS As List(Of PhieuMuonSachDTO)) As Result
        Return tsDAL.loadListPMSDangMuonByMaDG(mdg, listPMS)
    End Function
    Public Function loadListSachDM(mdg As String, mpm As String, ByRef listSachDM As List(Of SachDTO)) As Result
        Return tsDAL.loadListSachDM(mdg, mpm, listSachDM)
    End Function
    Public Function TraSachUpdate(mdg As String, mpm As String, ms As String, gc As String) As Result
        Return tsDAL.TraSachUpdate(mdg, mpm, ms, gc)
    End Function

End Class
