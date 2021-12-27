Imports QLTV_DAL
Imports Utility
Public Class BaoCaoBUS
    Private bcDAL As BaoCaoDAL
    Public Sub New()
        bcDAL = New BaoCaoDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcDAL = New BaoCaoDAL(connectionString)
    End Sub

    Public Function loadDTBaoCaoSachTraTre(ByRef data As DataTable) As Result

        Return bcDAL.loadDTBaoCaoSachTraTre(data)
    End Function

    Public Function loadDTBaoCaoTHMSTTL(mm As Integer, yy As Integer, ByRef data As DataTable) As Result

        Return bcDAL.loadDTBaoCaoTinhHinhMuonSachTheoTheLoai(mm, yy, data)
    End Function

    Public Function loadBaoCaoTraTre(day As DateTime, ByRef dataPrim As DataTable) As Result
        Return bcDAL.loadBaoCaoTraTreTheoNgay(day, dataPrim)
    End Function

End Class
