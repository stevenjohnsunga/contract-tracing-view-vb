Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mypath() As Object = Directory.GetFiles("C:\Users\User\source\repos\contract tracing viewer\contract tracing viewer\bin\Debug")
        For Each item As String In mypath
            Dim rslt As String = Path.GetFileName(item)
            lbl1.Items.Add(rslt)

        Next
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim myreader As System.IO.StreamReader
        Dim src As String = txtmybox.Text + ".txt"

        If File.Exists(src) Then
            myreader = My.Computer.FileSystem.OpenTextFileReader(src)
            txtmybox.Text = myreader.ReadToEnd()
        End If
    End Sub
End Class
