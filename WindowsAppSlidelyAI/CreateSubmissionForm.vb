Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newSubmission As New Submission With {
            .Name = TextBox1.Text,
            .Email = TextBox2.Text,
            .Phone = TextBox3.Text,
            .GitHub = TextBox4.Text
        }
        ' Save the submission
        ' Add newSubmission to the list or save to a file
    End Sub
End Class
Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub As String
End Class
