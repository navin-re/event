<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.COLLEGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.COLLEGETableAdapter = New WindowsApplication1.DataSet1TableAdapters.COLLEGETableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPOINTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.COLLEGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COLLEGEBindingSource
        '
        Me.COLLEGEBindingSource.DataMember = "COLLEGE"
        Me.COLLEGEBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COLLEGETableAdapter
        '
        Me.COLLEGETableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIDDataGridViewTextBoxColumn, Me.CNAMEDataGridViewTextBoxColumn, Me.CPOINTSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.COLLEGEBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(344, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
        Me.CIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CNAMEDataGridViewTextBoxColumn
        '
        Me.CNAMEDataGridViewTextBoxColumn.DataPropertyName = "CNAME"
        Me.CNAMEDataGridViewTextBoxColumn.HeaderText = "CNAME"
        Me.CNAMEDataGridViewTextBoxColumn.Name = "CNAMEDataGridViewTextBoxColumn"
        Me.CNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CPOINTSDataGridViewTextBoxColumn
        '
        Me.CPOINTSDataGridViewTextBoxColumn.DataPropertyName = "CPOINTS"
        Me.CPOINTSDataGridViewTextBoxColumn.HeaderText = "CPOINTS"
        Me.CPOINTSDataGridViewTextBoxColumn.Name = "CPOINTSDataGridViewTextBoxColumn"
        Me.CPOINTSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 289)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.COLLEGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents COLLEGEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLLEGETableAdapter As WindowsApplication1.DataSet1TableAdapters.COLLEGETableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPOINTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
