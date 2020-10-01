Imports System.Data.OleDb
Public Class viewstdinfo

    Private Sub viewstdinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbclass.Items.Add("All")
        cbclass.Items.Add("BA")
        cbclass.Items.Add("B.Com")
        cbclass.Items.Add("B.Com(VOC)")
        cbclass.Items.Add("BBA")
        cbyear.Items.Add("I-YEAR")
        cbyear.Items.Add("II-YEAR")
        cbclass.Text = "All"
        studload()
    End Sub

    Public Sub loadreader()
        While dr.Read = True
            dgstud.Rows.Add()
            dgstud.Item(0, i).Value = dr(0)
            dgstud.Item(1, i).Value = dr(1)
            dgstud.Item(2, i).Value = dr(2)
            dgstud.Item(3, i).Value = dr(3)
            dgstud.Item(4, i).Value = dr(4)
            dgstud.Item(5, i).Value = dr(5)
            dgstud.Item(6, i).Value = dr(6)
            dgstud.Item(7, i).Value = dr(7)
            i = i + 1
        End While
    End Sub

    Public Sub studload()
        i = 0
        dgstud.Rows.Clear()
        connectiondb()
        qry = "select * from studinfo"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        loadreader()
        connection_close()
    End Sub

    Private Sub dgstud_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstud.CellClick
        If e.ColumnIndex = 8 Then
            If MsgBoxResult.No = MsgBox("Do you want to delete this Record?", MsgBoxStyle.YesNo) Then
                Exit Sub
            Else
                connectiondb()
                qry = "delete from studinfo where rno='" & dgstud.CurrentRow.Cells(0).Value & "'"
                cmd = New OleDbCommand(qry, con)
                cmd.ExecuteNonQuery()
                connection_close()
                studload()
            End If
        End If
    End Sub


    Private Sub cbclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclass.SelectedIndexChanged
        i = 0
        dgstud.Rows.Clear()
        connectiondb()

        If (cbclass.Text = "All") Then
            qry = "select * from studinfo"
        Else
            qry = "select * from studinfo where class='" & cbclass.Text & "'"
        End If
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
       loadreader()
        cbyear.Text = "-Select Year-"
        connection_close()
    End Sub

    Private Sub btnchangeyear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangeyear.Click

        If MsgBoxResult.No = MsgBox("Do you want to change from first year to second year?", MsgBoxStyle.YesNo) Then
            Exit Sub
        Else
            i = 0
            dgstud.Rows.Clear()
            connectiondb()
            qry = "update studinfo set yr='II-YEAR'"
            cmd = New OleDbCommand(qry, con)
            dr = cmd.ExecuteReader
            loadreader()
            connection_close()
        End If
    End Sub

    Private Sub cbyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbyear.SelectedIndexChanged
        i = 0
        dgstud.Rows.Clear()
        connectiondb()
        If (cbclass.Text = "All" And cbyear.Text = "I-YEAR") Then 
            qry = "select * from studinfo where  yr ='I-YEAR'"
        ElseIf (cbclass.Text = "All" And cbyear.Text = "II-YEAR") Then
            qry = "select * from studinfo where  yr ='II-YEAR'"

        ElseIf (cbclass.Text = "BA" And cbyear.Text = "I-YEAR") Then
            qry = "select * from studinfo where  class='BA' and yr ='I-YEAR'"
        ElseIf (cbclass.Text = "BA" And cbyear.Text = "II-YEAR") Then
            qry = "select * from studinfo where  class='BA' and yr ='II-YEAR'"

        ElseIf (cbclass.Text = "B.Com" And cbyear.Text = "I-YEAR") Then
            qry = "select * from studinfo where  class='B.Com' and yr ='I-YEAR'"
        ElseIf (cbclass.Text = "B.Com" And cbyear.Text = "II-YEAR") Then
            qry = "select * from studinfo where  class='B.Com' and yr ='II-YEAR'"

        ElseIf (cbclass.Text = "B.Com(VOC)" And cbyear.Text = "I-YEAR") Then
            qry = "select * from studinfo where  class='B.Com(VOC)' and yr ='I-YEAR'"
        ElseIf (cbclass.Text = "B.Com(VOC)" And cbyear.Text = "II-YEAR") Then
            qry = "select * from studinfo where  class='B.Com(VOC)' and yr ='II-YEAR'"

        ElseIf (cbclass.Text = "BBA" And cbyear.Text = "I-YEAR") Then
            qry = "select * from studinfo where  class='BBA' and yr ='I-YEAR'"
        ElseIf (cbclass.Text = "BBA" And cbyear.Text = "II-YEAR") Then
            qry = "select * from studinfo where  class='BBA' and yr ='II-YEAR'"
        End If
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        loadreader()

        connection_close()
    End Sub

    Private Sub dgstud_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstud.CellContentClick

    End Sub
End Class