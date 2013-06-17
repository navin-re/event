Public Class collegedetails

    Private Sub collegedetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cname As String
        cname = InfoCheck.cname
        Dim ta As New DataSet1TableAdapters.COLLEGETableAdapter
        Collegeiddisp.Text = CType(ta.rcid(cname), String)
        collegenamedisp.Text = cname
        Dim ta1 As New DataSet1TableAdapters.COLLEGETableAdapter
        cpointsdisp.Text = CType(ta1.rcpoints(cname), String)

    End Sub
End Class