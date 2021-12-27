Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class TacGiaDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT [matacgia], [tentacgia]"
        query &= " FROM [tblTacGia]"


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
                        listTacGia.Clear()
                        While reader.Read()
                            listTacGia.Add(New TacGiaDTO(reader("matacgia"), reader("tentacgia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()

                    Return New Result(False, "Lấy tất cả tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function



    Public Function getNextID(ByRef nextID As String) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [matacgia] "
        query &= "From [tbltacgia] "
        query &= "Order By [matacgia] DESC "

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
                            idOnDB = reader("matacgia")
                        End While
                    Else
                        nextID = "TG001"
                        Return New Result(True)
                    End If
                    idOnDB = (Integer.Parse(idOnDB.Remove(0, 2)) + 1).ToString()

                    While (idOnDB.Length() < 3)
                        idOnDB = "0" + idOnDB
                    End While

                    nextID = "TG" + idOnDB
                    ' new ID = current ID + 1
                    ' nextID = idOnDB + 1

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = "TG001"
                    Return New Result(False, "Lấy ID kế tiếp của tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert_tacgia(ldg As TacGiaDTO) As Integer
        Dim query As String = String.Empty
        query &= "INSERT INTO [tbltacgia] ([matacgia], [tentacgia])"
        query &= "VALUES (@matacgia,@tentacgia)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", ldg.maTacGia)
                    .Parameters.AddWithValue("@tentacgia", ldg.tenTacGia)
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

    Public Function insert(ldg As TacGiaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tbltacgia] ([matacgia], [tentacgia])"
        query &= "VALUES (@matacgia,@tentacgia)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", ldg.maTacGia)
                    .Parameters.AddWithValue("@tentacgia", ldg.tenTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update_tacgia(ldg As TacGiaDTO) As Integer
        Dim query As String = String.Empty
        query &= " UPDATE [tbltacgia] SET"
        query &= " [tentacgia] = @tentacgia "
        query &= "WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", ldg.maTacGia)
                    .Parameters.AddWithValue("@tentacgia", ldg.tenTacGia)
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

    Public Function update(ldg As TacGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tbltacgia] SET"
        query &= " [tentacgia] = @tentacgia "
        query &= "WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", ldg.maTacGia)
                    .Parameters.AddWithValue("@tentacgia", ldg.tenTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maLoai As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbltacgia]  "
        query &= " WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectCount() As Integer
        Dim query As String = String.Empty
        query &= " SELECT COUNT([matacgia]) "
        query &= " FROM [tbltacgia] "

        Dim count As Integer
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    count = comm.ExecuteScalar()

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return 101 ' them that bai!!!
                End Try
            End Using
        End Using
        Return count ' thanh cong

    End Function
End Class
