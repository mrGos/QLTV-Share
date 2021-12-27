Imports System.Configuration
Imports System.Data.SqlClient
Imports Utility
Imports QLTV_DTO
Public Class NhanTraSachDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub


    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function loadDSSachDangMuonByMaDocGia(mdg As String, ByRef dataPrim As DataTable) As Result
        dataPrim.Clear()
        Dim dt = New DataTable
        dt.Clear()
        Dim col As New DataColumn("STT", System.Type.GetType("System.Int32"))
        col.AutoIncrement = True
        col.AutoIncrementSeed = 1
        col.AutoIncrementStep = 1
        'col.SetOrdinal(0)
        dt.Columns.Add(col)

        Dim query As String = String.Empty

        query &= "LoadSachDGDangMuon {0} "

        query = String.Format(query, mdg)


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

    Public Function loadListPMSDangMuonByMaDG(mdg As String, ByRef listPMS As List(Of PhieuMuonSachDTO)) As Result
        Dim query As String = String.Empty

        query &= "PMS_DGDangMuon {0} "

        query = String.Format(query, mdg)

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPMS.Clear()
                        While reader.Read()
                            listPMS.Add(New PhieuMuonSachDTO(reader("mapms"), mdg, reader("ngaymuon"), reader("ngaytra")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function loadListSachDM(mdg As String, mpm As String, ByRef listSachDM As List(Of SachDTO)) As Result
        Dim query As String = String.Empty

        query &= "spLoadlistSachDM {0},{1} "

        query = String.Format(query, mdg, mpm)

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listSachDM.Clear()
                        While reader.Read()
                            listSachDM.Add(New SachDTO(reader("masach"), reader("tensach"), reader("maloaisach"), reader("matacgia"), reader("manhaxuatban"), reader("namxuatban"), reader("ngaynhap"), reader("trigia"), reader("matinhtrangsach")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Sách đang mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function TraSachUpdate(mdg As String, mpm As String, ms As String, gc As String) As Result

        Dim query As String = String.Empty

        query &= " UPDATE tblCTPhieuMuonSach"
        query &= " SET ghichu = @gc"
        query &= " WHERE tblCTPhieuMuonSach.maphieumuonsach = (SELECT pms.maphieumuonsach"
        query &= " FROM tblPhieuMuonSach pms"
        query &= "  WHERE pms.maphieumuonsach = @mpm and pms.madocgia = @madocgia) and tblCTPhieuMuonSach.masach = @ms"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", mdg)
                    .Parameters.AddWithValue("@mpm", mpm)
                    .Parameters.AddWithValue("@ms", ms)
                    .Parameters.AddWithValue("@gc", gc)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
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
