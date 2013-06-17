<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Topcolleges
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
        Me.Topcollegesgrid = New System.Windows.Forms.DataGridView()
        CType(Me.Topcollegesgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Topcollegesgrid
        '
        Me.Topcollegesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Topcollegesgrid.Location = New System.Drawing.Point(8, 9)
        Me.Topcollegesgrid.Name = "Topcollegesgrid"
        Me.Topcollegesgrid.Size = New System.Drawing.Size(270, 249)
        Me.Topcollegesgrid.TabIndex = 0
        '
        'Topcolleges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Topcollegesgrid)
        Me.Name = "Topcolleges"
        Me.Text = "topcolleges"
        CType(Me.Topcollegesgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Topcollegesgrid As System.Windows.Forms.DataGridView
End Class
