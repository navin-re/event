Public Class tenparticipants

    Private Sub tenparticipants_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.PARTICIPANT' table. You can move, or remove it, as needed.
        Me.PARTICIPANTTableAdapter.Fill(Me.DataSet1.PARTICIPANT)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PARTICIPANTTableAdapter.FillBy(Me.DataSet1.PARTICIPANT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class