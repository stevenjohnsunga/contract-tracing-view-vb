Imports System.IO
Public Class Form1

    Dim table As New DataTable()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mypath() As Object = Directory.GetFiles("C:\Users\User\source\repos\contract tracing viewer\contract tracing viewer\bin\Debug", "*.txt")
        For Each item As String In mypath
            Dim rslt As String = Path.GetFileName(item)
            lbl1.Items.Add(rslt)

        Next


        table.Columns.Add("name", Type.GetType("System.String"))
        table.Columns.Add("covid", Type.GetType("System.String"))
        table.Columns.Add("gender", Type.GetType("System.String"))
        table.Columns.Add("age", Type.GetType("System.String"))


        DataGridView1.DataSource = table

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim myreader As System.IO.StreamReader
        Dim src As String = txtmybox.Text + ".txt"

        If File.Exists(src) Then
            myreader = My.Computer.FileSystem.OpenTextFileReader(src)
            txtmybox.Text = myreader.ReadToEnd()
        End If



        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Label1.Text = OpenFileDialog1.FileName
        End If

        Dim lines() As String
        Dim vals() As String

        lines = File.ReadAllLines(Label1.Text)

        For i As Integer = 0 To lines.Length - 1 Step +1
            vals = lines(i).ToString().Split("|")
            Dim row(vals.Length - 1) As String

            For j As Integer = 0 To vals.Length - 1 Step +1
                row(j) = vals(j).Trim()

            Next j
            table.Rows.Add(row)
        Next i

    End Sub
End Class
