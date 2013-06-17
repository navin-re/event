Public Class participantdetails

    Private Sub participantdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pid As Integer
        pid = InfoCheck.pid
        iddisp.Text = pid
        Dim ta As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        partnamedisp.Text = CType(ta.rpname(pid), String)
        Dim ta1 As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        collegedisp.Text = CType(ta1.rcollege(pid), String)
        Dim ta2 As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        phnodisp.Text = CType(ta2.rphone(pid), String)
        Dim ta3 As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        yeardisp.Text = CType(ta3.ryear(pid), String)
        Dim ta4 As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        deptdisp.Text = CType(ta4.rdept(pid), String)


    End Sub
End Class