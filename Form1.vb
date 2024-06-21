Imports Newtonsoft.Json
Imports System.Net.Http

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New FormViewSubmissions()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New FormCreateSubmission()
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    btnViewSubmissions.PerformClick()
                Case Keys.C
                    btnCreateSubmission.PerformClick()

            End Select
        End If
    End Sub


End Class
