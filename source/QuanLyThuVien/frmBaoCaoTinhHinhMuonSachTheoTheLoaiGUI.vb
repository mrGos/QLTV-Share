Imports QLTV_BUS
Imports Utility
'Imports OfficeExcel = Microsoft.Office.Interop.Excel
Imports OfficeExcel = Microsoft.Office.Interop.Excel

Public Class frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI
    Private bcthmsttlBUS As BaoCaoBUS
    Private dataLoaded As DataTable
    Private chkIfFormIsOpened As Boolean = False
    Private chkIfYearHadChanged As Boolean = False

    Private Sub frmBaoCaoTinhHinhMuonSachTheoTheLoaiGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkIfFormIsOpened = True
        dgvBaoCaoTHMSTTL.AllowUserToAddRows = False
        dataLoaded = New DataTable()
        bcthmsttlBUS = New BaoCaoBUS()

        nudThang.Value = DateTime.Now.Month
        nudNam.Maximum = DateTime.Now.Year
        nudNam.Value = DateTime.Now.Year
    End Sub

    Private Function loadDgvBaoCaoTHMSTTL() As Boolean

        dataLoaded = Nothing
        dataLoaded = New DataTable
        Dim result As Result
        result = bcthmsttlBUS.loadDTBaoCaoTHMSTTL(nudThang.Value, nudNam.Value, dataLoaded)
        If (result.FlagResult = False) Then
            MessageBox.Show("không load được danh sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        dataLoaded.Columns("tenloaisach").ColumnName = "Tên Thể Loại"
        dataLoaded.Columns("demmasach").ColumnName = "Số Lượt Mượn"
        dataLoaded.Columns("tile").ColumnName = "Tỉ Lệ"
        dgvBaoCaoTHMSTTL.DataSource = New BindingSource(dataLoaded, String.Empty)



        Dim sum As Integer = 0
        Dim i As Integer
        For i = 0 To dgvBaoCaoTHMSTTL.Rows.Count - 1
            sum = sum + Integer.Parse(dgvBaoCaoTHMSTTL.Rows(i).Cells(2).Value.ToString())
        Next
        txtTong.Text = sum.ToString()

        Return True
    End Function

    Private Sub nudThang_ValueChanged(sender As Object, e As EventArgs) Handles nudThang.ValueChanged
        If chkIfFormIsOpened = False Then
            Return
        End If
        If chkIfYearHadChanged = False Then
            Return
        End If
        loadDgvBaoCaoTHMSTTL()
    End Sub

    Private Sub nudNam_ValueChanged(sender As Object, e As EventArgs) Handles nudNam.ValueChanged
        If chkIfFormIsOpened = False Then
            Return
        End If
        chkIfYearHadChanged = True
        loadDgvBaoCaoTHMSTTL()
    End Sub

    Private Sub ButtonXuatExcel_Click(sender As Object, e As EventArgs) Handles ButtonXuatExcel.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.Filter = "Excel|*.xlsx"
        sfd.Title = "Save file Báo Cáo"
        sfd.FileName = "BaoCaoTinhHinhMuonSach-" + nudThang.Value.ToString + "-" + nudNam.Value.ToString + ".xlsx"
        sfd.RestoreDirectory = True
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim sfdr As DialogResult = sfd.ShowDialog()
        If (sfdr = System.Windows.Forms.DialogResult.OK) Then
            ExportDataToExcel(dataLoaded, sfd.FileName)
        Else
            Return
        End If
    End Sub


    Private Sub ExportDataToExcel(dt As DataTable, name As String)
        ButtonXuatExcel.Enabled = False
        If System.IO.File.Exists(name) Then
            If (MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                System.IO.File.Delete(name)
            Else
                Return
            End If
        End If

        Dim _excel As New OfficeExcel.Application
        Dim wBook As OfficeExcel.Workbook
        Dim wSheet As OfficeExcel.Worksheet
        Dim formatRange As OfficeExcel.Range

        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        'formatRange = wSheet.Range("a1", "d1")
        'formatRange = wSheet.UsedRange
        'formatRange.Borders.ColorIndex = OfficeExcel.XlColorIndex.xlColorIndexAutomatic
        'formatRange.BorderAround(OfficeExcel.XlLineStyle.xlContinuous, OfficeExcel.XlBorderWeight.xlMedium, OfficeExcel.XlColorIndex.xlColorIndexAutomatic, OfficeExcel.XlColorIndex.xlColorIndexAutomatic)

        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 3


        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(rowIndex + 1, colIndex) = dataLoaded.Columns(colIndex - 1).ColumnName
        Next

        For Each dr In dataLoaded.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dataLoaded.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next

        Dim cellRang As OfficeExcel.Range


        formatRange = wSheet.UsedRange
        formatRange.Borders.ColorIndex = OfficeExcel.XlColorIndex.xlColorIndexAutomatic
        formatRange.BorderAround(OfficeExcel.XlLineStyle.xlContinuous, OfficeExcel.XlBorderWeight.xlMedium, OfficeExcel.XlColorIndex.xlColorIndexAutomatic, OfficeExcel.XlColorIndex.xlColorIndexAutomatic)


        cellRang = wSheet.Range("a1", "d3")
        cellRang.Merge(False)
        cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter
        cellRang.VerticalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter
        cellRang.Font.Size = 12
        wSheet.Range("a1").Value = "Báo Cáo tình hình mượn sách theo thể loại Tháng " + nudThang.Value.ToString + "-" + nudNam.Value.ToString
        Dim LR As String = "d" + (dataLoaded.Rows.Count + 3 + 2).ToString
        wSheet.Range(LR).Value = "Tổng: " + txtTong.Text

        wSheet.Range("A4").ColumnWidth = 7
        wSheet.Range("B4").ColumnWidth = 25
        wSheet.Range("C4").ColumnWidth = 20
        wSheet.Range("D4").ColumnWidth = 10
        wBook.SaveAs(name)

        ReleaseObject(wSheet)
        wBook.Close(False)
        ReleaseObject(wBook)
        _excel.Quit()
        ReleaseObject(_excel)
        GC.Collect()

        MessageBox.Show("File Export Successfully!")
        ButtonXuatExcel.Enabled = True
    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class