Imports System.Collections.Generic ' Ensure you have the correct imports

Public Class ViewSubmissionsForm
    Private submissions As New List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add some sample data for demonstration
        submissions.Add(New Submission With {.Name = "John Doe", .Email = "john@example.com", .Phone = "123-456-7890", .GitHub = "github.com/johndoe"})
        submissions.Add(New Submission With {.Name = "Jane Smith", .Email = "jane@example.com", .Phone = "987-654-3210", .GitHub = "github.com/janesmith"})

        ' Load the first submission if available
        If submissions.Count > 0 Then
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub DisplaySubmission(submission As Submission)
        ' Display the submission details
        TextBox1.Text = submission.Name
        TextBox2.Text = submission.Email
        TextBox3.Text = submission.Phone
        TextBox4.Text = submission.GitHub
    End Sub

    ' Keyboard Shortcuts
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub
End Class

