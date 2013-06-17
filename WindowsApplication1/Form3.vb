Imports Oracle.DataAccess.Client
Imports System.Data
Imports Oracle.DataAccess.Types

Public Class Form3
    Friend eid As Integer
    Friend ename As String
    Friend venue As String
    Friend detect As Integer
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            "select eid from event"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            ComboBox1.Items.Add(dr.Item("eid").ToString())

        End While
        dr.Dispose()
        cmd.Dispose()
        Dim cmd1 As New OracleCommand
        cmd1.Connection = conn
        cmd1.CommandText = "select ename from event"
        cmd1.CommandType = CommandType.Text
        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read()
            ComboBox2.Items.Add(dr1.Item("ename").ToString())
        End While
        dr1.Dispose()
        cmd1.Dispose()
        Dim cmd2 As New OracleCommand
        cmd2.Connection = conn
        cmd2.CommandText = "select vname from venue"
        cmd2.CommandType = CommandType.Text
        Dim dr2 As OracleDataReader = cmd2.ExecuteReader()
        While dr2.Read()
            ComboBox3.Items.Add(dr2.Item("vname").ToString())
        End While
        dr2.Dispose()
        cmd2.Dispose()
        conn.Dispose()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (ComboBox1.Text <> "") Then

            eid = CType(ComboBox1.Text, Integer)
            detect = 1
            Form5.Show()
        ElseIf (ComboBox2.Text <> "") Then
            ename = ComboBox2.Text
            detect = 2
            Form5.Show()
        ElseIf (ComboBox3.Text <> "") Then

            venue = ComboBox3.Text
            detect = 3
            Form6.Show()
        Else
            MessageBox.Show("Choose one value !!")

        End If
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""

    End Sub
End Class