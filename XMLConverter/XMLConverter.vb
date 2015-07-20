Option Strict On
Imports Excel = Microsoft.Office.Interop.Excel

Public Class XMLConverter

    Private APP As New Excel.Application
    Private Workbook As Excel.Workbook
    Private worksheet As Excel.Worksheet

    Private worksheetNames() As String

    Public Sub startRecord(ByVal path As String)
        Workbook = APP.Workbooks.Open(path)
        getSheetNames()

    End Sub

    Public Sub getSheetNames()

        Workbook = APP.ActiveWorkbook

        For i = 1 To Workbook.Sheets.Count
            worksheetNames(i) = Workbook.Name.ToString
            Console.WriteLine(Workbook.Name.ToString)
        Next
    End Sub

End Class