Imports Oracle.DataAccess.Client
Imports System.Data
Imports Oracle.DataAccess.Types
Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (Form3.detect = 1) Then
            TextBox1.Text = Form3.eid
            Dim ta1 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox2.Text = CType(ta1.reename(Form3.eid, ""), String)
            Dim ta2 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox3.Text = CType(ta2.revname(Form3.eid, ""), String)
            Dim ta3 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox4.Text = CType(ta3.redate(Form3.eid, ""), String)
            Dim ta4 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox5.Text = CType(ta4.retime(Form3.eid, ""), String)

        End If
        If (Form3.detect = 2) Then
            Dim en As String
            en = Form3.ename
            Dim ta1 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox1.Text = CType(ta1.reid(en), String)
            TextBox2.Text = en
            Dim ta2 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox3.Text = CType(ta2.revname(0, en), String)
            Dim ta3 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox4.Text = CType(ta3.redate(0, en), String)
            Dim ta4 As New DataSet1TableAdapters.EVENTTableAdapter
            TextBox5.Text = CType(ta4.retime(0, en), String)
        End If
    End Sub

End Class