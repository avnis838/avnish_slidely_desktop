<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(217, 260)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(377, 63)
        Me.btnCreateSubmission.TabIndex = 0
        Me.btnCreateSubmission.Text = "Create New Submission (CTRL + C)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Khaki
        Me.btnViewSubmissions.Location = New System.Drawing.Point(217, 161)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(377, 56)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "View Submissions  (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(553, 44)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "John Doe, Slidely Task 2 - Form App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
