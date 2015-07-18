Option Strict On
Imports Excel = Microsoft.Office.Interop.Excel

Public Class XML

    Public APP As New Excel.Application
    Public Workbook As Excel.Workbook
    Public worksheet As Excel.Worksheet

    Public worksheetNames() As String
    Sub startRecord()
        getSheetNames()

    End Sub

    Sub getSheetNames()

        Workbook = APP.ActiveWorkbook

        For i = 1 To Workbook.Sheets.Count
            worksheetNames(i) = Workbook.Name.ToString
        Next

    End Sub

End Class