<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winnersearch
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
        Me.WINNERSVIEW = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eventcombo = New System.Windows.Forms.ComboBox()
        Me.winnerview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WINNERSVIEW
        '
        Me.WINNERSVIEW.AutoSize = True
        Me.WINNERSVIEW.Location = New System.Drawing.Point(88, 36)
        Me.WINNERSVIEW.Name = "WINNERSVIEW"
        Me.WINNERSVIEW.Size = New System.Drawing.Size(90, 13)
        Me.WINNERSVIEW.TabIndex = 0
        Me.WINNERSVIEW.Text = "WINNERS VIEW"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select event"
        '
        'eventcombo
        '
        Me.eventcombo.FormattingEnabled = True
        Me.eventcombo.Location = New System.Drawing.Point(132, 95)
        Me.eventcombo.Name = "eventcombo"
        Me.eventcombo.Size = New System.Drawing.Size(138, 21)
        Me.eventcombo.TabIndex = 2
        '
        'winnerview
        '
        Me.winnerview.Location = New System.Drawing.Point(91, 174)
        Me.winnerview.Name = "winnerview"
        Me.winnerview.Size = New System.Drawing.Size(86, 25)
        Me.winnerview.TabIndex = 3
        Me.winnerview.Text = "View"
        Me.winnerview.UseVisualStyleBackColor = True
        '
        'winnersearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 241)
        Me.Controls.Add(Me.winnerview)
        Me.Controls.Add(Me.eventcombo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WINNERSVIEW)
        Me.Name = "winnersearch"
        Me.Text = "Winners"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WINNERSVIEW As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents eventcombo As System.Windows.Forms.ComboBox
    Friend WithEvents winnerview As System.Windows.Forms.Button

End Class
