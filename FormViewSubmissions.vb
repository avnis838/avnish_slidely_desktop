Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private enableEditMode As Boolean = False
    Private stopwatch As Stopwatch = New Stopwatch()
    Private Const PlaceholderText As String = "Enter Email ID to Search"



    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf FormViewSubmissions_KeyDown


        Await LoadSubmission(currentIndex)
        ToggleEditMode(enableEditMode)

        InitializePlaceholder()
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                DisplaySubmission(submission)
            Else
                MessageBox.Show($"Failed to retrieve submission at index {index}.")
            End If
        End Using
    End Function

    Private Async Function LoadSubmissionByEmail(email As String) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/readByEmail?email={email}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                DisplaySubmission(submission)
            Else
                MessageBox.Show($"No submission found for email {email}.")
            End If
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        txtName.Text = submission.name
        txtEmail.Text = submission.email
        txtPhoneNumber.Text = submission.phone
        txtGitHubLink.Text = submission.github_link
        lblStopwatch.Text = submission.stopwatch_time
    End Sub

    Private Sub ToggleEditMode(enable As Boolean)
        txtName.Enabled = enable
        txtEmail.Enabled = enable
        txtPhoneNumber.Enabled = enable
        txtGitHubLink.Enabled = enable
        lblStopwatch.Enabled = enable ' Assuming lblStopwatch is editable if needed
        btnUpdate.Enabled = enable
        btnDelete.Enabled = enable
        btnStartStop.Visible = enable
        btnStartStop.Enabled = enable
        lblwatch.Enabled = Not enable



        If enable Then
            btnEdit.Text = "Cancel Edit"
        Else
            btnEdit.Text = "Edit (CTRL + E)"
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        Else
            MessageBox.Show("This is the first submission.")
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("No more submissions.")
                currentIndex -= 1 ' Reset index to the previous valid submission
            End If
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enableEditMode = Not enableEditMode
        ToggleEditMode(enableEditMode)
    End Sub

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhoneNumber.Text,
            .github_link = txtGitHubLink.Text,
            .stopwatch_time = lblStopwatch.Text
        }

        Using client As New HttpClient()
            Dim content As StringContent = New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/update?index={currentIndex}", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully!")
                enableEditMode = False
                ToggleEditMode(enableEditMode)
            Else
                MessageBox.Show($"{response.Content}")
            End If
        End Using
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully!")
                currentIndex -= 1 ' Adjust index to show the previous submission
                If currentIndex < 0 Then currentIndex = 0
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Failed to delete submission.")
            End If
        End Using


    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop()
        Else
            stopwatch.Start()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss\.ff}", Stopwatch.Elapsed)
    End Sub

    Private Sub FormViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.E
                    btnEdit.PerformClick()
                Case Keys.U
                    btnUpdate.PerformClick()
                Case Keys.D
                    btnDelete.PerformClick()
                Case Keys.N
                    btnNext.PerformClick()
                Case Keys.P
                    btnPrevious.PerformClick()
                Case Keys.T
                    btnStartStop.PerformClick()
            End Select
        End If
    End Sub

    Private Async Sub txtSearchEmailId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEmailId.KeyDown
        If e.KeyCode = Keys.Enter Then
            Await LoadSubmissionByEmail(txtSearchEmailId.Text)
            InitializePlaceholder()
        End If
    End Sub

    Private Sub InitializePlaceholder()
        txtSearchEmailId.ForeColor = Color.Gray
        txtSearchEmailId.Text = PlaceholderText
        AddHandler txtSearchEmailId.GotFocus, AddressOf RemovePlaceholder
        AddHandler txtSearchEmailId.LostFocus, AddressOf SetPlaceholder
    End Sub

    Private Sub RemovePlaceholder(sender As Object, e As EventArgs)
        If txtSearchEmailId.Text = PlaceholderText Then
            txtSearchEmailId.Text = ""
            txtSearchEmailId.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SetPlaceholder(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtSearchEmailId.Text) Then
            txtSearchEmailId.ForeColor = Color.Gray
            txtSearchEmailId.Text = PlaceholderText
        End If
    End Sub


End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
