<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoCheck
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
        Me.topcolleges = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.participantID = New System.Windows.Forms.TextBox()
        Me.Cstatus = New System.Windows.Forms.Button()
        Me.Pstatus = New System.Windows.Forms.Button()
        Me.topparticipants = New System.Windows.Forms.LinkLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'topcolleges
        '
        Me.topcolleges.AutoSize = True
        Me.topcolleges.Location = New System.Drawing.Point(96, 157)
        Me.topcolleges.Name = "topcolleges"
        Me.topcolleges.Size = New System.Drawing.Size(91, 13)
        Me.topcolleges.TabIndex = 6
        Me.topcolleges.TabStop = True
        Me.topcolleges.Text = "TOP COLLEGES "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Participant ID:"
        '
        'participantID
        '
        Me.participantID.Location = New System.Drawing.Point(114, 72)
        Me.participantID.Name = "participantID"
        Me.participantID.Size = New System.Drawing.Size(107, 20)
        Me.participantID.TabIndex = 3
        '
        'Cstatus
        '
        Me.Cstatus.Location = New System.Drawing.Point(247, 18)
        Me.Cstatus.Name = "Cstatus"
        Me.Cstatus.Size = New System.Drawing.Size(75, 23)
        Me.Cstatus.TabIndex = 4
        Me.Cstatus.Text = "Status"
        Me.Cstatus.UseVisualStyleBackColor = True
        '
        'Pstatus
        '
        Me.Pstatus.Location = New System.Drawing.Point(247, 69)
        Me.Pstatus.Name = "Pstatus"
        Me.Pstatus.Size = New System.Drawing.Size(75, 23)
        Me.Pstatus.TabIndex = 5
        Me.Pstatus.Text = "Status"
        Me.Pstatus.UseVisualStyleBackColor = True
        '
        'topparticipants
        '
        Me.topparticipants.AutoSize = True
        Me.topparticipants.Location = New System.Drawing.Point(86, 204)
        Me.topparticipants.Name = "topparticipants"
        Me.topparticipants.Size = New System.Drawing.Size(110, 13)
        Me.topparticipants.TabIndex = 7
        Me.topparticipants.TabStop = True
        Me.topparticipants.Text = "TOP PARTICIPANTS"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'InfoCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 263)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.topparticipants)
        Me.Controls.Add(Me.topcolleges)
        Me.Controls.Add(Me.Pstatus)
        Me.Controls.Add(Me.Cstatus)
        Me.Controls.Add(Me.participantID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InfoCheck"
        Me.Text = "InfoCheck"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents participantID As System.Windows.Forms.TextBox
    Friend WithEvents Cstatus As System.Windows.Forms.Button
    Friend WithEvents Pstatus As System.Windows.Forms.Button
    Friend WithEvents topparticipants As System.Windows.Forms.LinkLabel
    Friend WithEvents topcolleges As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
