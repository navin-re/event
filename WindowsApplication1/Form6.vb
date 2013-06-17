Public Class Form6

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11._EVENT' table. You can move, or remove it, as needed.
        Me.EVENTTableAdapter.Fill(Me.DataSet11._EVENT)
        'TODO: This line of code loads data into the 'DataSet1._EVENT' table. You can move, or remove it, as needed.
        Me.EVENTTableAdapter.Fill(Me.DataSet1._EVENT)
        PARAM1ToolStripTextBox.Text = Form3.venue
        Try
            Me.EVENTTableAdapter.FillBy(Me.DataSet1._EVENT, PARAM1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Me.EVENTTableAdapter.FillBy(Me.DataSet1._EVENT, PARAM1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PARAM1ToolStripLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PARAM1ToolStripTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub FillByToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.EVENTTableAdapter.FillBy(Me.DataSet1._EVENT, PARAM1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.EVENTTableAdapter.FillBy(Me.DataSet1._EVENT, PARAM1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class