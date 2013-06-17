<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class participantdetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.iddisp = New System.Windows.Forms.TextBox()
        Me.partnamedisp = New System.Windows.Forms.TextBox()
        Me.collegedisp = New System.Windows.Forms.TextBox()
        Me.phnodisp = New System.Windows.Forms.TextBox()
        Me.yeardisp = New System.Windows.Forms.TextBox()
        Me.deptdisp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Participant ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Participants Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "College:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Year:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Department:"
        '
        'iddisp
        '
        Me.iddisp.Location = New System.Drawing.Point(154, 15)
        Me.iddisp.Name = "iddisp"
        Me.iddisp.Size = New System.Drawing.Size(101, 20)
        Me.iddisp.TabIndex = 6
        '
        'partnamedisp
        '
        Me.partnamedisp.Location = New System.Drawing.Point(154, 50)
        Me.partnamedisp.Name = "partnamedisp"
        Me.partnamedisp.Size = New System.Drawing.Size(101, 20)
        Me.partnamedisp.TabIndex = 7
        '
        'collegedisp
        '
        Me.collegedisp.Location = New System.Drawing.Point(154, 78)
        Me.collegedisp.Name = "collegedisp"
        Me.collegedisp.Size = New System.Drawing.Size(101, 20)
        Me.collegedisp.TabIndex = 8
        '
        'phnodisp
        '
        Me.phnodisp.Location = New System.Drawing.Point(154, 118)
        Me.phnodisp.Name = "phnodisp"
        Me.phnodisp.Size = New System.Drawing.Size(101, 20)
        Me.phnodisp.TabIndex = 9
        '
        'yeardisp
        '
        Me.yeardisp.Location = New System.Drawing.Point(154, 160)
        Me.yeardisp.Name = "yeardisp"
        Me.yeardisp.Size = New System.Drawing.Size(101, 20)
        Me.yeardisp.TabIndex = 10
        '
        'deptdisp
        '
        Me.deptdisp.Location = New System.Drawing.Point(154, 201)
        Me.deptdisp.Name = "deptdisp"
        Me.deptdisp.Size = New System.Drawing.Size(101, 20)
        Me.deptdisp.TabIndex = 11
        '
        'participantdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.deptdisp)
        Me.Controls.Add(Me.yeardisp)
        Me.Controls.Add(Me.phnodisp)
        Me.Controls.Add(Me.collegedisp)
        Me.Controls.Add(Me.partnamedisp)
        Me.Controls.Add(Me.iddisp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "participantdetails"
        Me.Text = "participantdetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents iddisp As System.Windows.Forms.TextBox
    Friend WithEvents partnamedisp As System.Windows.Forms.TextBox
    Friend WithEvents collegedisp As System.Windows.Forms.TextBox
    Friend WithEvents phnodisp As System.Windows.Forms.TextBox
    Friend WithEvents yeardisp As System.Windows.Forms.TextBox
    Friend WithEvents deptdisp As System.Windows.Forms.TextBox
End Class
