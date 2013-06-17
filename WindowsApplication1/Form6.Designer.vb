<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EVENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.EVENTTableAdapter = New WindowsApplication1.DataSet1TableAdapters.EVENTTableAdapter()
        Me.DataSet11 = New WindowsApplication1.DataSet1()
        Me.EVENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PARAM1ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PARAM1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Event Taking Place in the venue :"
        '
        'EVENTBindingSource
        '
        Me.EVENTBindingSource.DataMember = "EVENT"
        Me.EVENTBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTTableAdapter
        '
        Me.EVENTTableAdapter.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTBindingSource1
        '
        Me.EVENTBindingSource1.DataMember = "EVENT"
        Me.EVENTBindingSource1.DataSource = Me.DataSet11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EIDDataGridViewTextBoxColumn, Me.ENAMEDataGridViewTextBoxColumn, Me.DATDataGridViewTextBoxColumn, Me.TIMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EVENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(442, 199)
        Me.DataGridView1.TabIndex = 2
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARAM1ToolStripLabel, Me.PARAM1ToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(498, 25)
        Me.FillByToolStrip.TabIndex = 3
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'PARAM1ToolStripLabel
        '
        Me.PARAM1ToolStripLabel.Name = "PARAM1ToolStripLabel"
        Me.PARAM1ToolStripLabel.Size = New System.Drawing.Size(81, 22)
        Me.PARAM1ToolStripLabel.Text = "Venue Name :"
        '
        'PARAM1ToolStripTextBox
        '
        Me.PARAM1ToolStripTextBox.Name = "PARAM1ToolStripTextBox"
        Me.PARAM1ToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(70, 22)
        Me.FillByToolStripButton.Text = "Get Details "
        '
        'EIDDataGridViewTextBoxColumn
        '
        Me.EIDDataGridViewTextBoxColumn.DataPropertyName = "EID"
        Me.EIDDataGridViewTextBoxColumn.HeaderText = "EID"
        Me.EIDDataGridViewTextBoxColumn.Name = "EIDDataGridViewTextBoxColumn"
        Me.EIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ENAMEDataGridViewTextBoxColumn
        '
        Me.ENAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME"
        Me.ENAMEDataGridViewTextBoxColumn.HeaderText = "ENAME"
        Me.ENAMEDataGridViewTextBoxColumn.Name = "ENAMEDataGridViewTextBoxColumn"
        Me.ENAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DATDataGridViewTextBoxColumn
        '
        Me.DATDataGridViewTextBoxColumn.DataPropertyName = "DAT"
        Me.DATDataGridViewTextBoxColumn.HeaderText = "DAT"
        Me.DATDataGridViewTextBoxColumn.Name = "DATDataGridViewTextBoxColumn"
        Me.DATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIMEDataGridViewTextBoxColumn
        '
        Me.TIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME"
        Me.TIMEDataGridViewTextBoxColumn.HeaderText = "TIME"
        Me.TIMEDataGridViewTextBoxColumn.Name = "TIMEDataGridViewTextBoxColumn"
        Me.TIMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 295)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Events"
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents EVENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTTableAdapter As WindowsApplication1.DataSet1TableAdapters.EVENTTableAdapter
    Friend WithEvents DataSet11 As WindowsApplication1.DataSet1
    Friend WithEvents EVENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PARAM1ToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PARAM1ToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
