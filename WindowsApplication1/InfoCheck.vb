Imports Oracle.DataAccess.Client
Imports System.Data
Imports Oracle.DataAccess.Types
Public Class InfoCheck
    Friend cname As String
    Friend pid As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oradb As String = "Data Source=(DESCRIPTION=" _
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=NAVIN-PC)(PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=oracle)));" _
           + "User Id=system;Password=navin;"
        Dim conn As New OracleConnection(oradb)

        conn.ConnectionString = oradb
        conn.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = _
            "select cname from college"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            ComboBox1.Items.Add(dr.Item("cname").ToString())

        End While
        dr.Dispose()
        cmd.Dispose()
        conn.Dispose()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub topcolleges_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles topcolleges.LinkClicked
        Form7.Show()


    End Sub

    Private Sub topparticipants_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles topparticipants.LinkClicked
        tenparticipants.Show()



    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles participantID.TextChanged

    End Sub

    Private Sub Cstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cstatus.Click
        If ComboBox1.Text = "" Then
            MsgBox("Please enter a valid college name !", MsgBoxStyle.Exclamation)
        End If
        cname = ComboBox1.Text
        collegedetails.Show()



    End Sub

    Private Sub Pstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pstatus.Click
        If participantID.Text = "" Then
            MsgBox("Please enter a valid Paricipant ID !", MsgBoxStyle.Exclamation)

        End If
        pid = CType(participantID.Text, Integer)
        participantdetails.Show()

    End Sub
End Class
