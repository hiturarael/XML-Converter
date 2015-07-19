Public Class Form1

    Private Sub GetFilePath_Click(sender As Object, e As EventArgs) Handles GetFilePath.Click
        Dim directory As New OpenFileDialog
        Dim apppath As String = ""

        If apppath = "" Then
            directory.Title = "Select file to convert"
            directory.InitialDirectory = "C:\"
            directory.Filter = "All Files (*.*)|*.*|All Files (*.*)|*.*"
            directory.FilterIndex = 2
            directory.RestoreDirectory = True

            If directory.ShowDialog() = Windows.Forms.DialogResult.OK Then
                apppath = directory.FileName
            End If
            filePathTbox.Text = apppath
        End If

    End Sub


    Private Sub ConvertPathBtn_Click(sender As Object, e As EventArgs) Handles ConvertPathBtn.Click
        Dim directory As New FolderBrowserDialog
        Dim apppath As String = ""

        If apppath = "" Then
            Dim dialog As New FolderBrowserDialog()
            dialog.RootFolder = Environment.SpecialFolder.Desktop
            dialog.SelectedPath = "C:\"
            dialog.Description = "Select Application Configeration Files Path"
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                apppath = dialog.SelectedPath
            End If
            convertPathTBox.Text = apppath
        End If
    End Sub
End Class
