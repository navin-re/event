Imports Oracle.DataAccess.Client
Imports System.Data
Imports Oracle.DataAccess.Types
Public Class winnersearch
    Friend ename As String
   
    Private Sub winnerview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles winnerview.Click

        If (eventcombo.Text <> "") Then
            ename = eventcombo.Text
            winnerdisplay.Show()
        Else
            MsgBox("Select The event", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub winnersearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            "select ename from event"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            eventcombo.Items.Add(dr.Item("ename").ToString())

        End While
        dr.Dispose()
        cmd.Dispose()
        conn.Dispose()
    End Sub
End Class
