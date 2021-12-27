Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class NhaXuatBanDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function SelectAll(listNhaXuatBan As List(Of NhaXuatBanDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [manhaxuatban], [tennhaxuatban]"
        query &= " FROM [tblNhaXuatBan]"


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
                        listNhaXuatBan.Clear()
                        While reader.Read()
                            listNhaXuatBan.Add(New NhaXuatBanDTO(reader("manhaxuatban"), reader("tennhaxuatban")))
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



    Public Function getNextID(ByRef nextID As String) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [manhaxuatban] "
        query &= "From [tblnhaxuatban] "
        query &= "Order By [manhaxuatban] DESC "

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
                    Dim idOnDB As String
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("manhaxuatban")
                        End While
                    Else
                        nextID = "NXB001"
                        Return New Result(True)
                    End If
                    idOnDB = (Integer.Parse(idOnDB.Remove(0, 3)) + 1).ToString()

                    While (idOnDB.Length() < 3)
                        idOnDB = "0" + idOnDB
                    End While

                    nextID = "NXB" + idOnDB

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = "NXB001"
                    Return New Result(False, "Lấy ID kế tiếp của nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert_nhaxuatban(nxb As NhaXuatBanDTO) As Integer
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblnhaxuatban] ([manhaxuatban], [tennhaxuatban])"
        query &= "VALUES (@manhaxuatban,@tennhaxuatban)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", nxb.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", nxb.TenNhaXuatBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function

    Public Function insert(nxb As NhaXuatBanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblnhaxuatban] ([manhaxuatban], [tennhaxuatban])"
        query &= "VALUES (@manhaxuatban,@tennhaxuatban)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", nxb.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", nxb.TenNhaXuatBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update_nhaxuatban(nxb As NhaXuatBanDTO) As Integer
        Dim query As String = String.Empty
        query &= " UPDATE [tblnhaxuatban] SET"
        query &= " [tennhaxuatban] = @tennhaxuatban "
        query &= "WHERE "
        query &= " [manhaxuatban] = @manhaxuatban "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", nxb.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", nxb.TenNhaXuatBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function

    Public Function update(nxb As NhaXuatBanDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblnhaxuatban] SET"
        query &= " [tennhaxuatban] = @tennhaxuatban "
        query &= "WHERE "
        query &= " [manhaxuatban] = @manhaxuatban "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", nxb.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", nxb.TenNhaXuatBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maLoai As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblnhaxuatban]  "
        query &= " WHERE "
        query &= " [manhaxuatban] = @manhaxuatban "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
