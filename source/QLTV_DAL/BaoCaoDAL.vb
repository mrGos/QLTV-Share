Imports System.Configuration
Imports System.Data.SqlClient
Imports Utility

Public Class BaoCaoDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub


    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function loadDTBaoCaoSachTraTre(ByRef data As DataTable) As Result
        data.Clear()
        Dim query As String = String.Empty
        query &= "select tblSach.masach, ngaymuon, DATEDIFF(day, ngaytra,ngaymuon) - ( select top 1 songaymuontoida from tblQuyDinh) as ngaytratre "
        query &= "From tblSach "
        query &= "Left Join tblCTPhieuMuonSach on tblCTPhieuMuonSach.masach = tblSach.masach "
        query &= "Left Join tblPhieuMuonSach on tblPhieuMuonSach.maphieumuonsach = tblCTPhieuMuonSach.maphieumuonsach "
        query &= "where DateDiff(Day, ngaytra, ngaymuon) > ( select top 1 songaymuontoida from tblQuyDinh) "

        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Using dad As New SqlDataAdapter(query, cnn)
                    dad.Fill(data)
                End Using
                cnn.Close()
            End Using
        Catch ex As Exception
            Return New Result(False)
        End Try
        Return New Result(True)
    End Function
    Public Function loadDTBaoCaoTinhHinhMuonSachTheoTheLoai(mm As Integer, yy As Integer, ByRef dataPrim As DataTable) As Result
        dataPrim.Clear()
        Dim dt = New DataTable
        Dim col As New DataColumn("STT", System.Type.GetType("System.Int32"))
        col.AutoIncrement = True
        col.AutoIncrementSeed = 1
        col.AutoIncrementStep = 1
        'col.SetOrdinal(0)
        dt.Columns.Add(col)

        Dim query As String = String.Empty

        query &= "spGetDataBaoCaoBaoCaoTHMSTTL {0}, {1} "

        query = String.Format(query, mm, yy)


        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Using dad As New SqlDataAdapter(query, cnn)
                    dad.Fill(dt)
                    dataPrim.Merge(dt)
                End Using
                cnn.Close()
            End Using
        Catch ex As Exception
            Return New Result(False)
        End Try
        Return New Result(True)
    End Function

    Public Function loadBaoCaoTraTreTheoNgay(day As DateTime, ByRef dataPrim As DataTable) As Result
        dataPrim.Clear()
        Dim dt = New DataTable
        Dim col As New DataColumn("STT", System.Type.GetType("System.Int32"))
        col.AutoIncrement = True
        col.AutoIncrementSeed = 1
        col.AutoIncrementStep = 1
        'col.SetOrdinal(0)
        dt.Columns.Add(col)

        Dim query As String = String.Empty

        query &= "select tensach, ngaymuon,  isnull(DATEDIFF(day,ngaytra,@DKngayxembc),0) as songaytratre
                  from tblSach s,tblCTPhieuMuonSach ctpms, tblPhieuMuonSach pms
                  where s.masach = ctpms.masach and ctpms.maphieumuonsach = pms.maphieumuonsach and ctpms.ghichu Like N'%Trễ%'
                  group by tensach,ngaymuon,ngaytra
                  having DATEDIFF(day,ngaytra,@DKngayxembc) >0
                  order by tensach asc "




        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@DKngayxembc", day)
                End With
                Try
                    conn.Open()
                    Using dad As New SqlDataAdapter(comm)
                        dad.Fill(dt)
                        dataPrim.Merge(dt)
                    End Using
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
