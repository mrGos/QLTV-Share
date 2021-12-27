Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class SachDAL
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
        nextMS = "S" + x + "000000"

        Dim query As String = String.Empty
        query &= "Select TOP 1 [masach]  "
        query &= "From [tblSach]  "
        query &= "Order By [masach] DESC "

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
                            msOnDB = reader("masach")
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
                            nextMS = "S" + year.ToString()
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
                    Return New Result(False, "Lấy tự động Mã sách kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(s As SachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblSach] ([masach], [tensach],[maloaisach] ,[matacgia],[manhaxuatban], [namxuatban], [ngaynhap],[trigia],[matinhtrangsach])"
        query &= "VALUES (@masach, @tensach, @maloaisach,@matacgia, @manhaxuatban, @namxuatban, @ngaynhap, @trigia, @matinhtrangsach)"

        ''get MSdg
        'Dim nextMS = "1"
        'buildMS(nextMS)
        's.maSach = nextMS

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", s.maSach)
                    .Parameters.AddWithValue("@tensach", s.tenSach)
                    .Parameters.AddWithValue("@maloaisach", s.maLoaiSach)
                    .Parameters.AddWithValue("@manhaxuatban", s.maNhaXuatBan)
                    .Parameters.AddWithValue("@namxuatban", s.namXuatBan)
                    .Parameters.AddWithValue("@ngaynhap", s.ngayNhap)
                    .Parameters.AddWithValue("@trigia", s.triGia)
                    .Parameters.AddWithValue("@matinhtrangsach", s.MaTinhTrangSach)
                    .Parameters.AddWithValue("@matacgia", s.maTacGia)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Console.WriteLine("0")
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectWithFilter(listsach As List(Of SachDTO), column As String, filter As String) As Result
        Dim query As String = String.Empty
        'query &= "SELECT [masach], [tensach], [maloaisach],[matacgia], [manhaxuatban], [namxuatban], [ngaynhap], [trigia], [matinhtrangsach]"
        'query &= " FROM [tblSach] "
        'query &= "where " + column + " like '%" + filter + "%' "
        query &= "spSelectAllWithFilter {0}, '%{1}%' "

        query = String.Format(query, column, filter)

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
                        listsach.Clear()
                        While reader.Read()
                            'listsach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("maloaisach"), reader("matacgia"), reader("manhaxuatban"), reader("namxuatban"), reader("ngaynhap"), reader("trigia"), reader("matinhtrangsach"))
                            listsach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("tenloaisach"), reader("tentacgia"), reader("tennhaxuatban"), reader("namxuatban"), reader("ngaynhap"), reader("trigia"), reader("tentinhtrangsach")))

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(maSach As String) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [tblSach] "
        query &= " WHERE "
        query &= " [masach] = @masach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", maSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function deleteAll() As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM tblSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "xóa tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True)
    End Function

    Public Function update(sachDTO As SachDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET"
        query &= " [tensach] = @tensach "
        query &= " ,[maloaisach] = @maloaisach "
        query &= " ,[matacgia] = @matacgia "
        query &= " ,[namxuatban] = @namxuatban "
        query &= " ,[ngaynhap] = @ngaynhap "
        query &= " ,[manhaxuatban] = @manhaxuatban "
        query &= " ,[trigia] = @trigia "
        query &= " ,[matinhtrangsach] = @matinhtrangsach "
        query &= " WHERE "
        query &= " [maSach] = @maSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", sachDTO.maSach)
                    .Parameters.AddWithValue("@tensach", sachDTO.tenSach)
                    .Parameters.AddWithValue("@maloaisach", sachDTO.maLoaiSach)
                    .Parameters.AddWithValue("@matacgia", sachDTO.maTacGia)
                    .Parameters.AddWithValue("@namxuatban", sachDTO.namXuatBan)
                    .Parameters.AddWithValue("@ngaynhap", sachDTO.ngayNhap)
                    .Parameters.AddWithValue("@manhaxuatban", sachDTO.maNhaXuatBan)
                    .Parameters.AddWithValue("@trigia", sachDTO.triGia)
                    .Parameters.AddWithValue("@matinhtrangsach", sachDTO.MaTinhTrangSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef tableSach As DataTable) As Result
        Dim query As String = String.Empty
        'query &= "SELECT [masach], [tensach], [maloaisach],[matacgia], [manhaxuatban], [namxuatban], [ngaynhap], [trigia], [matinhtrangsach]"
        'query &= "FROM [tblSach]"
        query &= "loadlistSach"
        tableSach.Clear()

        Try
            Using cnn As New SqlConnection(connectionString)
                cnn.Open()
                Using dad As New SqlDataAdapter(query, cnn)
                    dad.Fill(tableSach)
                End Using
                cnn.Close()
            End Using
        Catch ex As Exception
            Return New Result(False)
        End Try

        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listSach As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [masach], [tensach], [maloaisach],[matacgia], [manhaxuatban], [namxuatban], [ngaynhap], [trigia], [matinhtrangsach]"
        query &= "FROM [tblSach]"


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
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("maloaisach"), reader("matacgia"), reader("manhaxuatban"), reader("namxuatban"), reader("ngaynhap"), reader("trigia"), reader("matinhtrangsach")))

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAllByStatus(strMaTT As String, ByRef listSach As List(Of SachDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [masach], [tensach], [maloaisach],[matacgia], [manhaxuatban], [namxuatban], [ngaynhap], [trigia], [matinhtrangsach]"
        query &= "FROM [tblSach]"
        query &= "WHERE [matinhtrangsach] = "
        query &= strMaTT


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
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("maloaisach"), reader("matacgia"), reader("manhaxuatban"), reader("namxuatban"), reader("ngaynhap"), reader("trigia"), reader("matinhtrangsach")))

                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã Sách và Tên Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function



    Public Function load(maSach As String, ByRef sach As SachDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT [masach], [tensach], [maloaisach], [manhaxuatban], [namxuatban], [ngaynhap], [trigia], [matinhtrangsach] "
        query &= "FROM [tblSach] "
        query &= "WHERE [masach] = @masach"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", maSach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    'If reader.HasRows = True Then
                    If (reader.Read()) Then
                        sach.maSach = reader("masach")
                        sach.tenSach = reader("tensach")
                        sach.maLoaiSach = reader("maloaisach")
                        sach.maNhaXuatBan = reader("manhaxuatban")
                        sach.namXuatBan = reader("namxuatban")
                        sach.ngayNhap = reader("ngaynhap")
                        sach.triGia = reader("trigia")
                        sach.MaTinhTrangSach = reader("matinhtrangsach")

                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Load sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    ' update for QLMS
    Public Function update_TT(mas As String, maTT As String) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblSach] SET"
        query &= " [matinhtrangsach] = @matinhtrangsach "
        query &= " WHERE "
        query &= " [maSach] = @maSach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maSach", mas)
                    .Parameters.AddWithValue("@matinhtrangsach", maTT)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhập sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
