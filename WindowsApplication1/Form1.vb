Imports Oracle.DataAccess.Client
Imports System.Data
Imports Oracle.DataAccess.Types

Public Class main
    Dim oradb As String = "Data Source=(DESCRIPTION=" _
               + "(ADDRESS=(PROTOCOL=TCP)(HOST=NAVIN-PC)(PORT=1521))" _
              + "(CONNECT_DATA=(SERVICE_NAME=oracle)));" _
              + "User Id=system;Password=navin;"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.COLLEGE' table. You can move, or remove it, as needed.
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
            Collegecombobox.Items.Add(dr.Item("cname").ToString())

        End While
        dr.Dispose()
        cmd.Dispose()
        conn.Dispose()
        Dim conn1 As New OracleConnection(oradb)

        conn1.ConnectionString = oradb
        conn1.Open()
        Dim cmd1 As New OracleCommand
        cmd1.Connection = conn1
        cmd1.CommandText = _
            "select unique dept from participant"
        cmd1.CommandType = CommandType.Text

        Dim dr1 As OracleDataReader = cmd1.ExecuteReader()
        While dr1.Read()
            ComboBox2.Items.Add(dr1.Item("dept").ToString())

        End While
        dr1.Dispose()
        cmd1.Dispose()
        conn1.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim y As Integer
        Dim coll As String
        Dim dep As String
        Dim pid As Integer
        Dim cid As Integer
        coll = Collegecombobox.Text
        Dim tba1 As New DataSet1TableAdapters.PARTICIPANTTableAdapter
        Try
            pid = CType(tba1.maxpid(), Integer)
        Dim tableadapter As New DataSet1TableAdapters.COLLEGETableAdapter

            cid = CType(tableadapter.getcidfromcname(coll), Integer)


        If RadioButton1.Checked = True Then
            y = 1
        ElseIf RadioButton2.Checked = True Then
            y = 2
        ElseIf RadioButton3.Checked = True Then
            y = 3
        ElseIf RadioButton4.Checked = True Then
            y = 4
        Else
            MsgBox("Select suitable year")
        End If

        dep = ComboBox2.Text
            pid = pid + 1
            Dim cphone As Integer
            cphone = CType(TextBox2.Text, Integer)

        Dim tba2 As New DataSet1TableAdapters.PARTICIPANTTableAdapter
            tba2.Insertparticipant(pid, TextBox1.Text, y, dep, 5, cid, cphone)
            Dim cpid As String
            cpid = CType(pid, String)
            MsgBox("Your PID is " + cpid, MsgBoxStyle.OkOnly,MsgBoxStyle .Information)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Collegecombobox.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
