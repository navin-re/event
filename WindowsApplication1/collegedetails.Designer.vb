<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class collegedetails
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
        Me.Collegeiddisp = New System.Windows.Forms.TextBox()
        Me.collegenamedisp = New System.Windows.Forms.TextBox()
        Me.cpointsdisp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "College name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Points Obtained:"
        '
        'Collegeiddisp
        '
        Me.Collegeiddisp.Location = New System.Drawing.Point(116, 13)
        Me.Collegeiddisp.Name = "Collegeiddisp"
        Me.Collegeiddisp.Size = New System.Drawing.Size(147, 20)
        Me.Collegeiddisp.TabIndex = 3
        '
        'collegenamedisp
        '
        Me.collegenamedisp.Location = New System.Drawing.Point(116, 46)
        Me.collegenamedisp.Name = "collegenamedisp"
        Me.collegenamedisp.Size = New System.Drawing.Size(146, 20)
        Me.collegenamedisp.TabIndex = 4
        '
        'cpointsdisp
        '
        Me.cpointsdisp.Location = New System.Drawing.Point(116, 82)
        Me.cpointsdisp.Name = "cpointsdisp"
        Me.cpointsdisp.Size = New System.Drawing.Size(145, 20)
        Me.cpointsdisp.TabIndex = 5
        '
        'collegedetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 128)
        Me.Controls.Add(Me.cpointsdisp)
        Me.Controls.Add(Me.collegenamedisp)
        Me.Controls.Add(Me.Collegeiddisp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "collegedetails"
        Me.Text = "collegedetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Collegeiddisp As System.Windows.Forms.TextBox
    Friend WithEvents collegenamedisp As System.Windows.Forms.TextBox
    Friend WithEvents cpointsdisp As System.Windows.Forms.TextBox
End Class
