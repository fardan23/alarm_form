
Imports System.IO
Public Class Form1

    Dim s As Integer = 0
    Dim d As Path

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        DateTimePicker1.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub SetWaktu_Click_1(sender As Object, e As EventArgs) Handles SetWaktu.Click
        Timer1.Enabled = True
    End Sub

    Private Sub carinada_Click_1(sender As Object, e As EventArgs) Handles carinada.Click
        If OpenFileDialog1.ShowDialog = DialogResult Then
        End If
        TextBox1.Text = ""
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        End
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If TimeOfDay = DateTimePicker1.Text Then
                If s = 1 Then
                    AxWindowsMediaPlayer1.URL = TextBox1.Text.ToString
                Else
                    MsgBox(DateTimePicker1.Value)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class