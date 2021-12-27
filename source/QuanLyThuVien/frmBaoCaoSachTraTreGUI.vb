Imports QLTV_BUS
Imports Utility
Imports OfficeExcel = Microsoft.Office.Interop.Excel

Public Class frmBaoCaoSachTraTreGUI
    Dim bcstrBUS As New BaoCaoBUS
    Private dataLoaded As DataTable
    Dim result As Result

    Private Sub frmBaoCaoSachTraTreGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNgay.Value = DateTime.Now
        dataLoaded = New DataTable

        result = New Result

        dgvBaoCaoSachTraTre.AllowUserToAddRows = False



    End Sub

    Private Function loadDgvBaoCaoSachTraTre(ngay As DateTime)


        dataLoaded = Nothing
        dataLoaded = New DataTable


        result = bcstrBUS.loadBaoCaoTraTre(ngay, dataLoaded)
        If (result.FlagResult = False) Then
            MessageBox.Show("không load được danh sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        dataLoaded.Columns("tensach").ColumnName = "Tên Sách"
        dataLoaded.Columns("ngaymuon").ColumnName = "Ngày Mượn"
        dataLoaded.Columns("songaytratre").ColumnName = "Số Ngày Trả Trể"
        dgvBaoCaoSachTraTre.DataSource = New BindingSource(dataLoaded, String.Empty)
        For i = 0 To dgvBaoCaoSachTraTre.Rows.Count - 1
            If dgvBaoCaoSachTraTre.Rows(i).Cells(3).Value < 0 Then
                dgvBaoCaoSachTraTre.Rows(i).Cells(3).Value = 0
            End If
        Next



        Return True
    End Function

    Private Sub dtpNgay_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgay.ValueChanged
        loadDgvBaoCaoSachTraTre(dtpNgay.Value)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.Filter = "Excel|*.xlsx"
        sfd.Title = "Save file Báo Cáo"
        sfd.FileName = "BaoCaoThongKeSachTraTre-" + dtpNgay.Value.Day.ToString() + "-" + dtpNgay.Value.Month.ToString() + "-" + dtpNgay.Value.Year.ToString() + ".xlsx"
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
        btnXuatExcel.Enabled = False
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
        wSheet.Range("a1").Value = "Báo Cáo Thóng Kê Sách Trả Trễ Ngày " + dtpNgay.Value.Day.ToString() + "-" + dtpNgay.Value.Month.ToString() + "-" + dtpNgay.Value.Year.ToString()
        'Dim LR As String = "d" + (dataLoaded.Rows.Count + 3 + 2).ToString


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
        btnXuatExcel.Enabled = True
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

End Class