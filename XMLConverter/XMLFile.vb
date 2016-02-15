Option Strict On

Imports System.Xml

Public Class XMLFile
    Public record As String = ""
    Public sections As New List(Of section)
End Class

Public Class section
    Public records As New List(Of entry)
End Class

Public Class entry
    Public cellHeader As ArrayList
    Public cellContent As ArrayList
End Class
