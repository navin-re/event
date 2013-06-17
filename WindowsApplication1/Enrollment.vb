Imports Oracle.DataAccess.Client
Imports System.Data
Imports Oracle.DataAccess.Types
Public Class enrollment

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

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
            "select ename from event"
        cmd.CommandType = CommandType.Text

        Dim dr As OracleDataReader = cmd.ExecuteReader()
        While dr.Read()
            ComboBox1.Items.Add(dr.Item("ename").ToString())

        End While
        dr.Dispose()
        cmd.Dispose()
        conn.Dispose()
    End Sub

    Private Sub EventName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ParticipantID.Text = "" And EventID.Text = "" And ComboBox1.Text = "" Then
            MsgBox("Please enter required fields!", MsgBoxStyle.Critical, "Details?")

        Else


            If ParticipantID.Text = "" Then
                MsgBox("Please enter your Participant ID!", MsgBoxStyle.Exclamation, "PID?")

            ElseIf EventID.Text = "" And ComboBox1.Text = "" Then
                MsgBox("Please enter your EventID or Event Name", MsgBoxStyle.Exclamation, "EventID or Event Name?")

            Else
                Dim pid As Integer
                Dim eid As Integer
                pid = CType(ParticipantID.Text, Integer)
                If (EventID.Text <> "") Then
                    eid = CType(EventID.Text, Integer)
                End If
                If (ComboBox1.Text <> "") Then
                    Dim taba As New DataSet1TableAdapters.EVENTTableAdapter
                    eid = CType(taba.reid(ComboBox1.Text), Integer)
                End If


                Try
                    Dim tb1 As New DataSet1TableAdapters.ENROLLMENTTableAdapter
                    tb1.Enroll(pid, eid)
                    MsgBox("The participant has been enrolled successfully!!", MsgBoxStyle.Information, " Thank You!")
                Catch ex As Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

            End If

        End If



    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class



