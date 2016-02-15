Option Strict Off

Imports Excel = Microsoft.Office.Interop.Excel

Public Class XMLConverter

    Private APP As New Excel.Application
    Private Workbook As Excel.Workbook
    Private worksheet As Excel.Worksheet

    Private worksheetNames As New ArrayList

    Public Sub startRecord(ByVal path As String)
        Workbook = APP.Workbooks.Open(path)
        getSheetNames()

    End Sub

    Public Sub getSheetNames()
        Dim sheet As Excel.Worksheet = Nothing
        Dim sheetRows As Integer = getRecordCount()
        Dim colCount As Integer = getColumnCount()

        Try
            For i = 1 To Workbook.Sheets.Count
                Dim record As String = ""
                ' Dim sections As section
                Dim headers As New List(Of String)
                Dim entry As New entry

                sheet = DirectCast(Workbook.Sheets(i), Excel.Worksheet)

                For rows = 1 To sheetRows
                    For cells = 1 To colCount
                        If sheet.Cells(rows, cells).ToString <> "" Then
                            If rows = 1 Then
                                headers.Add(CStr(sheet.Cells(rows, cells).value))
                            Else
                                entry.cellHeader.Add(headers(i))
                                entry.cellContent.Add(CStr(sheet.Cells(rows, cells).value))
                            End If
                        End If
                    Next
                Next
            Next

            Console.WriteLine(worksheetNames)

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Function getRecordCount() As Integer
        Dim sheet As Excel.Worksheet = Nothing
        Dim rowCount As Integer = 0
        Try
            sheet = DirectCast(Workbook.Sheets(1), Excel.Worksheet)

            For i = 1 To sheet.Rows.Count
                If CStr(sheet.Cells(i, 1).value) <> "" Then
                    rowCount += 1
                Else
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "An Error has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return rowCount
    End Function

    Private Function getColumnCount() As Integer
        Dim sheet As Excel.Worksheet = Nothing
        Dim colCount As Integer = 0
        Try
            sheet = DirectCast(Workbook.Sheets(1), Excel.Worksheet)

            For i = 1 To sheet.Columns.Count
                If CStr(sheet.Cells(1, i).value) <> "" Then
                    colCount += 1
                Else
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "An Error has Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return colCount
    End Function


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class