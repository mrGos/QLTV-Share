Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class CTPhieuMuonSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMS(ByRef nextMS As String) As Result 'ex: S18222229

        nextMS = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMS = "C" + x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [maCTPhieuMuonSach]  "
        query &= "From [tblCTPhieuMuonSach]  "
        query &= "Order By [maCTPhieuMuonSach] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("maCTPhieuMuonSach")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        If (msOnDB.Length >= 9) Then
                            Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                            Dim iCurrentYear = Integer.Parse(currentYear)
                            Dim currentYearOnDB = msOnDB.Substring(0, 3).Remove(0, 1)
                            Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                            Dim year = iCurrentYear
                            If (year < icurrentYearOnDB) Then
                                year = icurrentYearOnDB
                            End If
                            nextMS = "C" + year.ToString()
                            msOnDB = msOnDB.Remove(0, 1)
                            Dim v = msOnDB.Substring(2)
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                            nextMS = nextMS + tmp
                            System.Console.WriteLine(nextMS)
                        End If
                    End If


                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã phiếu mượn sách kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(s As CTPhieuMuonSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCTPhieuMuonSach] ([maCTPhieuMuonSach],[maphieumuonsach],[masach],[ghichu])"
        query &= "VALUES (@maCTPhieuMuonSach,@maphieumuonsach,@masach,@ghichu)"

        ''get MSdg
        'Dim nextMS = "1"
        'buildMS(nextMS)
        's.maCTPhieuMuonSach = nextMS

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maCTPhieuMuonSach", s.MaCTPhieuMuonSach)
                    .Parameters.AddWithValue("@maphieumuonsach", s.MaPhieuMuonSach)
                    .Parameters.AddWithValue("@masach", s.MaSach)
                    .Parameters.AddWithValue("@ghichu", s.GhiChu)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Console.WriteLine("0")
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm ct pm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maCTPhieuMuonSach As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblCTPhieuMuonSach] "
        query &= " WHERE "
        query &= " [maCTPhieuMuonSach] = @maCTPhieuMuonSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maCTPhieuMuonSach", maCTPhieuMuonSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa mã pm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listCTPhieuMuonSach As List(Of CTPhieuMuonSachDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [maCTPhieuMuonSach], [maphieumuonsach],[masach],[ghichu]"
        query &= "FROM [tblCTPhieuMuonSach]"


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
                        listCTPhieuMuonSach.Clear()
                        While reader.Read()
                            listCTPhieuMuonSach.Add(New CTPhieuMuonSachDTO(reader("maCTPhieuMuonSach"), reader("maphieumuonsach"), reader("masach"), reader("ghichu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả CTPM Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
    Public Function selectAll_ByMaPM(mpm As String, ByRef listCTPhieuMuonSach As List(Of CTPhieuMuonSachDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [maCTPhieuMuonSach], [maphieumuonsach],[masach],[ghichu] "
        query &= " FROM [tblCTPhieuMuonSach] "
        query &= " WHERE maphieumuonsach = @mpm "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mpm", mpm)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTPhieuMuonSach.Clear()
                        While reader.Read()
                            listCTPhieuMuonSach.Add(New CTPhieuMuonSachDTO(reader("maCTPhieuMuonSach"), reader("maphieumuonsach"), reader("masach"), reader("ghichu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả CTPM Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function UpdateCTPMS(ct As CTPhieuMuonSachDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblCTPhieuMuonSach]"
        query &= " SET ghichu = @gc "
        query &= " WHERE maCTphieumuonsach = @mactpm AND maphieumuonsach = @mapms "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@gc", ct.GhiChu)
                    .Parameters.AddWithValue("@mactpm", ct.MaCTPhieuMuonSach)
                    .Parameters.AddWithValue("@mapms", ct.MaPhieuMuonSach)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm CT PMS không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
