Public Class Form9

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ta As New DataSet1TableAdapters.COLLEGETableAdapter
        TextBox1.Text = CType(ta.cname, String)
    End Sub
End Class