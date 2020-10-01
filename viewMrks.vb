Imports System.Data.OleDb
Public Class viewMrks

    Private Sub viewMrks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mrksload()
    End Sub

    Public Sub loadreader()
        While dr.Read = True
            dgvone.Rows.Add()
            dgvone.Item(0, i).Value = dr(0)
            dgvone.Item(1, i).Value = dr(1)
            dgvone.Item(2, i).Value = dr(2)
            dgvone.Item(3, i).Value = dr(3)
            dgvone.Item(4, i).Value = dr(4)
            dgvone.Item(5, i).Value = dr(5)
            dgvone.Item(6, i).Value = dr(6)
            dgvone.Item(7, i).Value = dr(7)
            i = i + 1
        End While
    End Sub

    Public Sub mrksload()
        i = 0
        dgvone.Rows.Clear()
        connectiondb()
        qry = "select * from marks"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        loadreader()
        connection_close()
    End Sub

    Private Sub dgvone_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvone.CellClick
        If e.ColumnIndex = 8 Then
            If MsgBoxResult.No = MsgBox("Do you want to delete this Record?", MsgBoxStyle.YesNo) Then
                Exit Sub
            Else
                connectiondb()
                qry = "delete from marks where rno='" & dgvone.CurrentRow.Cells(0).Value & "'"
                cmd = New OleDbCommand(qry, con)
                cmd.ExecuteNonQuery()

                connection_close()
                mrksload()
            End If
        End If
    End Sub
End Class