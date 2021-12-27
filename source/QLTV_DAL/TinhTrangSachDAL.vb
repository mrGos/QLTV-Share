Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class TinhTrangSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function getNextID() As Integer
        Dim id As Integer
        id = 1

        Dim query As String = String.Empty
        query &= "Select TOP 1 [matinhtrangsach] "
        query &= "From [tbltinhtrangSach] "
        query &= "Order By [matinhtrangsach] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("matinhtrangsach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    id = idOnDB + 1
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return id ' thanh cong
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "Select TOP 1 [matinhtrangsach] "
        query &= "From [tbltinhtrangSach] "
        query &= "Order By [matinhtrangsach] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("matinhtrangsach")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert_tinhtrangsach(ldg As TinhTrangSachDTO) As Integer
        Dim query As String = String.Empty
        query &= "INSERT INTO [tbltinhtrangsach] ([matinhtrangsach], [tentinhtrangsach])"
        query &= "VALUES (@matinhtrangsach,@tentinhtrangsach)"

        ldg.MaTinhTrangSach = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrangsach", ldg.MaTinhTrangSach)
                    .Parameters.AddWithValue("@tentinhtrangsach", ldg.TenTinhTrangSach)
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
    Public Function insert(ldg As TinhTrangSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tbltinhtrangsach] ([matinhtrangsach], [tentinhtrangsach])"
        query &= "VALUES (@matinhtrangsach,@tentinhtrangsach)"

        ldg.MaTinhTrangSach = getNextID()
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrangsach", ldg.MaTinhTrangSach)
                    .Parameters.AddWithValue("@tentinhtrangsach", ldg.TenTinhTrangSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update_tinhtrangsach(ls As TinhTrangSachDTO) As Integer
        Dim query As String = String.Empty
        query &= " UPDATE [tbltinhtrangsach] SET"
        query &= " [tentinhtrangsach] = @tentinhtrangsach "
        query &= "WHERE "
        query &= " [matinhtrangsach] = @matinhtrangsach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrangsach", ls.MaTinhTrangSach)
                    .Parameters.AddWithValue("@tentinhtrangsach", ls.TenTinhTrangSach)
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
    Public Function update(ls As TinhTrangSachDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tbltinhtrangsach] SET"
        query &= " [tentinhtrangsach] = @tentinhtrangsach "
        query &= "WHERE "
        query &= " [matinhtrangsach] = @matinhtrangsach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrangsach", ls.MaTinhTrangSach)
                    .Parameters.AddWithValue("@tentinhtrangsach", ls.TenTinhTrangSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL_tinhtrangsach() As List(Of TinhTrangSachDTO)

        Dim listtinhtrangsach = New List(Of TinhTrangSachDTO)
        Dim query As String = String.Empty
        query &= " SELECT [matinhtrangsach], [tentinhtrangsach]"
        query &= " FROM [tbltinhtrangsach]"


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
                        While reader.Read()
                            listtinhtrangsach.Add(New TinhTrangSachDTO(reader("matinhtrangsach"), reader("tentinhtrangsach")))
                        End While
                    End If

                Catch
                    conn.Close()
                    Return Nothing  ' that bai!!!
                End Try
            End Using
        End Using
        Return listtinhtrangsach ' thanh cong
    End Function
    Public Function selectALL(ByRef listtinhtrangsach As List(Of TinhTrangSachDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT TOP 3 [matinhtrangsach], [tentinhtrangsach]"
        query &= " FROM [tbltinhtrangsach]"


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
                        listtinhtrangsach.Clear()
                        While reader.Read()
                            listtinhtrangsach.Add(New TinhTrangSachDTO(reader("matinhtrangsach"), reader("tentinhtrangsach")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete_tinhtrangsach(matinhtrang As Integer) As Integer

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbltinhtrangsach]  "
        query &= " WHERE "
        query &= " [matinhtrangsach] = @matinhtrangsach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrangsach", matinhtrang)
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
    Public Function delete(matinhtrang As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbltinhtrangsach]  "
        query &= " WHERE "
        query &= " [matinhtrangsach] = @matinhtrangsach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrangsach", matinhtrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loại sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
