<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmission
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
        Me.components = New System.ComponentModel.Container()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnToogleStopwatch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(356, 153)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(368, 26)
        Me.txtEmail.TabIndex = 13
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(356, 210)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(368, 26)
        Me.txtPhoneNumber.TabIndex = 12
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(356, 265)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.Size = New System.Drawing.Size(368, 26)
        Me.txtGitHubLink.TabIndex = 11
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Location = New System.Drawing.Point(540, 379)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(233, 26)
        Me.lblStopwatch.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(356, 99)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(368, 26)
        Me.txtName.TabIndex = 9
        '
        'btnToogleStopwatch
        '
        Me.btnToogleStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.btnToogleStopwatch.Location = New System.Drawing.Point(48, 362)
        Me.btnToogleStopwatch.Name = "btnToogleStopwatch"
        Me.btnToogleStopwatch.Size = New System.Drawing.Size(432, 60)
        Me.btnToogleStopwatch.TabIndex = 7
        Me.btnToogleStopwatch.Text = "Toogle Stopwatch (CTRL + T)"
        Me.btnToogleStopwatch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Github Link for Task 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Phone num"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(292, 481)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(296, 57)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(681, 44)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "John Doe, Slidely Task 2 - Create Submission"
        '
        'FormCreateSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 623)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnToogleStopwatch)
        Me.Name = "FormCreateSubmission"
        Me.Text = "FormCreateSubmission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents lblStopwatch As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnToogleStopwatch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
End Class
