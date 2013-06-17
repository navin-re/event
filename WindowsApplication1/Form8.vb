Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ta As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        TextBox1.Text = CType(ta.returnname, String)
    End Sub
End Class