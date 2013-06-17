Public Class winnerdisplay

    Private Sub winnerdisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim enam As String
        enam = winnersearch.ename
       
        Try
            Dim ta1 As New DataSet1TableAdapters.WINNERTableAdapter
            winner1disp.Text = CType(ta1.rwinner(enam), String)
            Dim ta2 As New DataSet1TableAdapters.WINNERTableAdapter
            winner2disp.Text = CType(ta2.rwinner2(enam), String)
            Dim ta3 As New DataSet1TableAdapters.WINNERTableAdapter
            winner3disp.Text = CType(ta3.rwinner3(enam), String)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        
        

    End Sub
End Class