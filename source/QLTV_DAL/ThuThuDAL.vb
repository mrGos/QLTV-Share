Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class ThuThuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(ThuThu As ThuThuDTO)
        Dim query As String = String.Empty
        query &= " INSERT INTO [tblThuThu] ([taikhoan], [matkhau])"
        query &= " VALUES (@taikhoan,@matkhau)"



        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", ThuThu.TaiKhoan)
                    .Parameters.AddWithValue("@matkhau", ThuThu.MatKhau)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm tài khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ThuThu As ThuThuDTO)
        Dim query As String = String.Empty
        query &= " Select [taikhoan], [matkhau] "
        query &= " From [tblThuThu] "
        query &= " Where [taikhoan] = @taikhoan And [matkhau] = @matkhau"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@taikhoan", ThuThu.TaiKhoan)
                    .Parameters.AddWithValue("@matkhau", ThuThu.MatKhau)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Return New Result(True)
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm tài khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(False) ' thanh cong
    End Function
End Class
