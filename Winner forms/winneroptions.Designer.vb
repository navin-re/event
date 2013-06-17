<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winnersoptions
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
        Me.winnerbyevent = New System.Windows.Forms.Button()
        Me.winnerbycollege = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'winnerbyevent
        '
        Me.winnerbyevent.Location = New System.Drawing.Point(81, 71)
        Me.winnerbyevent.Name = "winnerbyevent"
        Me.winnerbyevent.Size = New System.Drawing.Size(127, 43)
        Me.winnerbyevent.TabIndex = 0
        Me.winnerbyevent.Text = "Winner by event"
        Me.winnerbyevent.UseVisualStyleBackColor = True
        '
        'winnerbycollege
        '
        Me.winnerbycollege.Location = New System.Drawing.Point(81, 170)
        Me.winnerbycollege.Name = "winnerbycollege"
        Me.winnerbycollege.Size = New System.Drawing.Size(126, 43)
        Me.winnerbycollege.TabIndex = 1
        Me.winnerbycollege.Text = "Winner by college"
        Me.winnerbycollege.UseVisualStyleBackColor = True
        '
        'winnersoptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 270)
        Me.Controls.Add(Me.winnerbycollege)
        Me.Controls.Add(Me.winnerbyevent)
        Me.Name = "winnersoptions"
        Me.Text = "winneroptions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents winnerbyevent As System.Windows.Forms.Button
    Friend WithEvents winnerbycollege As System.Windows.Forms.Button
End Class
