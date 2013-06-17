<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winnerdisplay
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
        Me.winner1disp = New System.Windows.Forms.TextBox()
        Me.winner2disp = New System.Windows.Forms.TextBox()
        Me.winner3disp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Winner 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Winner 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Winner 3"
        '
        'winner1disp
        '
        Me.winner1disp.Location = New System.Drawing.Point(120, 50)
        Me.winner1disp.Name = "winner1disp"
        Me.winner1disp.Size = New System.Drawing.Size(143, 20)
        Me.winner1disp.TabIndex = 5
        '
        'winner2disp
        '
        Me.winner2disp.Location = New System.Drawing.Point(120, 110)
        Me.winner2disp.Name = "winner2disp"
        Me.winner2disp.Size = New System.Drawing.Size(142, 20)
        Me.winner2disp.TabIndex = 6
        '
        'winner3disp
        '
        Me.winner3disp.Location = New System.Drawing.Point(120, 169)
        Me.winner3disp.Name = "winner3disp"
        Me.winner3disp.Size = New System.Drawing.Size(141, 20)
        Me.winner3disp.TabIndex = 7
        '
        'winnerdisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 270)
        Me.Controls.Add(Me.winner3disp)
        Me.Controls.Add(Me.winner2disp)
        Me.Controls.Add(Me.winner1disp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "winnerdisplay"
        Me.Text = "viewwinners"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents winner1disp As System.Windows.Forms.TextBox
    Friend WithEvents winner2disp As System.Windows.Forms.TextBox
    Friend WithEvents winner3disp As System.Windows.Forms.TextBox
End Class
