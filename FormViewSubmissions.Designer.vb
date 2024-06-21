<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblwatch = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearchEmailId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNext.Location = New System.Drawing.Point(505, 476)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(237, 60)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Phone num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Github Link for Task 2"
        '
        'lblwatch
        '
        Me.lblwatch.AutoSize = True
        Me.lblwatch.Location = New System.Drawing.Point(142, 388)
        Me.lblwatch.Name = "lblwatch"
        Me.lblwatch.Size = New System.Drawing.Size(124, 20)
        Me.lblwatch.TabIndex = 28
        Me.lblwatch.Text = "stopWatch Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(399, 213)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(309, 26)
        Me.txtEmail.TabIndex = 25
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(399, 267)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(309, 26)
        Me.txtPhoneNumber.TabIndex = 24
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(399, 323)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.Size = New System.Drawing.Size(309, 26)
        Me.txtGitHubLink.TabIndex = 23
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Location = New System.Drawing.Point(399, 382)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(309, 26)
        Me.lblStopwatch.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(399, 162)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(309, 26)
        Me.txtName.TabIndex = 21
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Khaki
        Me.btnPrevious.Location = New System.Drawing.Point(167, 476)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(215, 60)
        Me.btnPrevious.TabIndex = 20
        Me.btnPrevious.Text = "Previous (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.OliveDrab
        Me.btnUpdate.Location = New System.Drawing.Point(44, 557)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(208, 64)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update (CTRL + U)"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.Location = New System.Drawing.Point(654, 557)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(209, 64)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEdit.Location = New System.Drawing.Point(338, 557)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(225, 64)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "Edit (CTRL + E)"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.Turquoise
        Me.btnStartStop.Location = New System.Drawing.Point(114, 374)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(191, 48)
        Me.btnStartStop.TabIndex = 35
        Me.btnStartStop.Text = "Toggle (CTRL + T)"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(678, 44)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "John Doe, Slidely Task 2 - View Submissions"
        '
        'txtSearchEmailId
        '
        Me.txtSearchEmailId.Location = New System.Drawing.Point(146, 95)
        Me.txtSearchEmailId.Name = "txtSearchEmailId"
        Me.txtSearchEmailId.Size = New System.Drawing.Size(596, 26)
        Me.txtSearchEmailId.TabIndex = 37
        '
        'FormViewSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 663)
        Me.Controls.Add(Me.txtSearchEmailId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblwatch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "FormViewSubmissions"
        Me.Text = "FormViewSubmissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblwatch As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents lblStopwatch As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStartStop As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearchEmailId As TextBox
End Class
