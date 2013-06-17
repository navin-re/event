<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class collegeselect
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
        Me.collegelist = New System.Windows.Forms.ComboBox()
        Me.collegeview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College"
        '
        'collegelist
        '
        Me.collegelist.FormattingEnabled = True
        Me.collegelist.Location = New System.Drawing.Point(101, 60)
        Me.collegelist.Name = "collegelist"
        Me.collegelist.Size = New System.Drawing.Size(155, 21)
        Me.collegelist.TabIndex = 1
        '
        'collegeview
        '
        Me.collegeview.Location = New System.Drawing.Point(101, 131)
        Me.collegeview.Name = "collegeview"
        Me.collegeview.Size = New System.Drawing.Size(100, 27)
        Me.collegeview.TabIndex = 2
        Me.collegeview.Text = "View"
        Me.collegeview.UseVisualStyleBackColor = True
        '
        'collegeselect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 204)
        Me.Controls.Add(Me.collegeview)
        Me.Controls.Add(Me.collegelist)
        Me.Controls.Add(Me.Label1)
        Me.Name = "collegeselect"
        Me.Text = "collegeselect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents collegelist As System.Windows.Forms.ComboBox
    Friend WithEvents collegeview As System.Windows.Forms.Button
End Class
