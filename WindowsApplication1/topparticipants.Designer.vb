<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tenparticipants
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPOINTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARTICIPANTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.PARTICIPANTTableAdapter = New WindowsApplication1.DataSet1TableAdapters.PARTICIPANTTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARTICIPANTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.PNAMEDataGridViewTextBoxColumn, Me.YEARDataGridViewTextBoxColumn, Me.DEPTDataGridViewTextBoxColumn, Me.PPOINTSDataGridViewTextBoxColumn, Me.CIDDataGridViewTextBoxColumn, Me.PHNODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PARTICIPANTBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(743, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "PID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "PID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        Me.PIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PNAMEDataGridViewTextBoxColumn
        '
        Me.PNAMEDataGridViewTextBoxColumn.DataPropertyName = "PNAME"
        Me.PNAMEDataGridViewTextBoxColumn.HeaderText = "PNAME"
        Me.PNAMEDataGridViewTextBoxColumn.Name = "PNAMEDataGridViewTextBoxColumn"
        Me.PNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YEARDataGridViewTextBoxColumn
        '
        Me.YEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.HeaderText = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.Name = "YEARDataGridViewTextBoxColumn"
        Me.YEARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DEPTDataGridViewTextBoxColumn
        '
        Me.DEPTDataGridViewTextBoxColumn.DataPropertyName = "DEPT"
        Me.DEPTDataGridViewTextBoxColumn.HeaderText = "DEPT"
        Me.DEPTDataGridViewTextBoxColumn.Name = "DEPTDataGridViewTextBoxColumn"
        Me.DEPTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PPOINTSDataGridViewTextBoxColumn
        '
        Me.PPOINTSDataGridViewTextBoxColumn.DataPropertyName = "PPOINTS"
        Me.PPOINTSDataGridViewTextBoxColumn.HeaderText = "PPOINTS"
        Me.PPOINTSDataGridViewTextBoxColumn.Name = "PPOINTSDataGridViewTextBoxColumn"
        Me.PPOINTSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
        Me.CIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PHNODataGridViewTextBoxColumn
        '
        Me.PHNODataGridViewTextBoxColumn.DataPropertyName = "PHNO"
        Me.PHNODataGridViewTextBoxColumn.HeaderText = "PHNO"
        Me.PHNODataGridViewTextBoxColumn.Name = "PHNODataGridViewTextBoxColumn"
        Me.PHNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PARTICIPANTBindingSource
        '
        Me.PARTICIPANTBindingSource.DataMember = "PARTICIPANT"
        Me.PARTICIPANTBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PARTICIPANTTableAdapter
        '
        Me.PARTICIPANTTableAdapter.ClearBeforeFill = True
        '
        'tenparticipants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 343)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "tenparticipants"
        Me.Text = "TopParticipants"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARTICIPANTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents PARTICIPANTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARTICIPANTTableAdapter As WindowsApplication1.DataSet1TableAdapters.PARTICIPANTTableAdapter
    Friend WithEvents PIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPOINTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
