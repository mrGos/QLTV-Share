Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class PhieuMuonSachDAL
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
        nextMS = "P" + x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [maPhieuMuonSach]  "
        query &= "From [tblPhieuMuonSach]  "
        query &= "Order By [maPhieuMuonSach] DESC "

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
                            msOnDB = reader("maPhieuMuonSach")
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
                            nextMS = "P" + year.ToString()
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

    Public Function insert(s As PhieuMuonSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuMuonSach] ([maPhieuMuonSach],[madocgia],[ngaymuon],[ngaytra])"
        query &= "VALUES (@maPhieuMuonSach,@madocgia,@ngaymuon,@ngaytra)"

        'get MSdg
        'Dim nextMS = "1"
        'buildMS(nextMS)
        's.maPhieuMuonSach = nextMS

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuMuonSach", s.MaPhieuMuonSach)
                    .Parameters.AddWithValue("@madocgia", s.MaDocGia)
                    .Parameters.AddWithValue("@ngaymuon", s.NgayMuon)
                    .Parameters.AddWithValue("@ngaytra", s.NgayTra)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Console.WriteLine("0")
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm pm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maPhieuMuonSach As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblPhieuMuonSach] "
        query &= " WHERE "
        query &= " [maPhieuMuonSach] = @maPhieuMuonSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuMuonSach", maPhieuMuonSach)
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

    Public Function selectAll(ByRef listPhieuMuonSach As List(Of PhieuMuonSachDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [maPhieuMuonSach], [madocgia],[ngaymuon],[ngaytra]"
        query &= "FROM [tblPhieuMuonSach]"


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
                        listPhieuMuonSach.Clear()
                        While reader.Read()
                            listPhieuMuonSach.Add(New PhieuMuonSachDTO(reader("maPhieuMuonSach"), reader("madocgia"), reader("ngaymuon"), reader("ngaytra")))

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả PM Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAllForTraCuu(ByRef data As DataTable) As Result

        data.Clear()

        Dim query As String = String.Empty

        query &= "loadPhieuMuonSach"

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
    Public Function update(pm As PhieuMuonSachDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuMuonSach] "
        query &= " SET ngaymuon = @nm, ngaytra = @ntoihan"
        query &= " WHERE [maPhieuMuonSach] = @maPhieuMuonSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maPhieuMuonSach", pm.MaPhieuMuonSach)
                    .Parameters.AddWithValue("@nm", pm.NgayMuon)
                    .Parameters.AddWithValue("@ntoihan", pm.NgayTra)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Update pm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function checkSachTraTre(day As DateTime, ByRef dataPrim As DataTable) As Result
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

    Public Function isSachTraTre() As Boolean
        Dim query As String = String.Empty
        query &= " select pms.maphieumuonsach  "
        query &= " from tblPhieuMuonSach pms, tblCTPhieuMuonSach ct "
        query &= " where pms.maphieumuonsach = ct.maphieumuonsach and ct.ghichu Like N'%Mượn%'  "
        query &= " group by pms.maphieumuonsach,ngaytra "
        query &= " having isnull(DATEDIFF(day,ngaytra,GETDATE()),0)>0 "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim Reader As SqlDataReader
                    Reader = comm.ExecuteReader
                    If Reader.HasRows Then
                        Return True
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return False
                End Try
            End Using
        End Using
        Return False ' k thanh cong
    End Function


End Class
