<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.filePathTbox = New System.Windows.Forms.TextBox()
        Me.GetFilePath = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.convertPathTBox = New System.Windows.Forms.TextBox()
        Me.ConvertPathBtn = New System.Windows.Forms.Button()
        Me.ConvertBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'filePathTbox
        '
        Me.filePathTbox.Location = New System.Drawing.Point(28, 22)
        Me.filePathTbox.Name = "filePathTbox"
        Me.filePathTbox.Size = New System.Drawing.Size(444, 20)
        Me.filePathTbox.TabIndex = 0
        '
        'GetFilePath
        '
        Me.GetFilePath.Location = New System.Drawing.Point(478, 22)
        Me.GetFilePath.Name = "GetFilePath"
        Me.GetFilePath.Size = New System.Drawing.Size(95, 23)
        Me.GetFilePath.TabIndex = 1
        Me.GetFilePath.Text = "Open File Path"
        Me.GetFilePath.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'convertPathTBox
        '
        Me.convertPathTBox.Location = New System.Drawing.Point(28, 70)
        Me.convertPathTBox.Name = "convertPathTBox"
        Me.convertPathTBox.Size = New System.Drawing.Size(444, 20)
        Me.convertPathTBox.TabIndex = 2
        '
        'ConvertPathBtn
        '
        Me.ConvertPathBtn.Location = New System.Drawing.Point(478, 68)
        Me.ConvertPathBtn.Name = "ConvertPathBtn"
        Me.ConvertPathBtn.Size = New System.Drawing.Size(95, 23)
        Me.ConvertPathBtn.TabIndex = 3
        Me.ConvertPathBtn.Text = "Convert File"
        Me.ConvertPathBtn.UseVisualStyleBackColor = True
        '
        'ConvertBtn
        '
        Me.ConvertBtn.Location = New System.Drawing.Point(288, 105)
        Me.ConvertBtn.Name = "ConvertBtn"
        Me.ConvertBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConvertBtn.TabIndex = 4
        Me.ConvertBtn.Text = "Convert"
        Me.ConvertBtn.UseVisualStyleBackColor = True
        '
        'ConvertToXml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 149)
        Me.Controls.Add(Me.ConvertBtn)
        Me.Controls.Add(Me.ConvertPathBtn)
        Me.Controls.Add(Me.convertPathTBox)
        Me.Controls.Add(Me.GetFilePath)
        Me.Controls.Add(Me.filePathTbox)
        Me.Name = "ConvertToXml"
        Me.Text = "Convert To XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents filePathTbox As System.Windows.Forms.TextBox
    Friend WithEvents GetFilePath As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents convertPathTBox As System.Windows.Forms.TextBox
    Friend WithEvents ConvertPathBtn As System.Windows.Forms.Button
    Friend WithEvents ConvertBtn As System.Windows.Forms.Button

End Class
