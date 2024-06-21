Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class FormCreateSubmission
    Private stopwatch As Stopwatch = New Stopwatch()



    Private Sub FormCreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf FormCreateSubmission_KeyDown
    End Sub
    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnToogleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        Else
            stopwatch.Start()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss\.ff}", stopwatch.Elapsed)
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhoneNumber.Text,
            .github_link = txtGitHubLink.Text,
            .stopwatch_time = lblStopwatch.Text
        }

        Using client As New HttpClient()
            Dim content As StringContent = New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed.")
            End If
        End Using


    End Sub

    Private Sub FormCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    btnToogleStopwatch.PerformClick()
                Case Keys.S
                    btnSubmit.PerformClick()

            End Select
        End If
    End Sub


End Class

