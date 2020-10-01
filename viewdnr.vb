Imports System.Data.OleDb
Public Class viewdnr
    Private Sub viewdnr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dnrload()

        cbbgrp.Items.Add("A+")
        cbbgrp.Items.Add("A-")
        cbbgrp.Items.Add("B+")
        cbbgrp.Items.Add("B-")
        cbbgrp.Items.Add("O+")
        cbbgrp.Items.Add("O-")
        cbbgrp.Items.Add("AB+")
        cbbgrp.Items.Add("AB-")

    End Sub


    Public Sub dnrload()
        i = 0
        dgvdnr.Rows.Clear()
        connectiondb()
        qry = "select * from dnr"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvdnr.Rows.Add()
            dgvdnr.Item(0, i).Value = dr(0)
            dgvdnr.Item(1, i).Value = dr(1)
            dgvdnr.Item(2, i).Value = dr(2)
            dgvdnr.Item(3, i).Value = dr(3)
            dgvdnr.Item(4, i).Value = dr(4)
            dgvdnr.Item(5, i).Value = dr(5)
            dgvdnr.Item(6, i).Value = dr(6)
            dgvdnr.Item(7, i).Value = dr(7)
            dgvdnr.Item(8, i).Value = dr(8)
            i = i + 1
        End While
        connection_close()
    End Sub

    Private Sub dgvdnr_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdnr.CellClick
        If e.ColumnIndex = 9 Then
            If MsgBoxResult.No = MsgBox("Do you want to delete this Record?", MsgBoxStyle.YesNo) Then
                Exit Sub
            Else
                connectiondb()
                qry = "delete from dnr where rno='" & dgvdnr.CurrentRow.Cells(0).Value & "'"
                cmd = New OleDbCommand(qry, con)
                cmd.ExecuteNonQuery()
                connection_close()
                dnrload()
            End If
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        i = 0
        dgvdnr.Rows.Clear()
        connectiondb()
        qry = "select * from dnr where bgrp='" & cbbgrp.Text & "' "
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            dgvdnr.Rows.Add()
            dgvdnr.Item(0, i).Value = dr(0)
            dgvdnr.Item(1, i).Value = dr(1)
            dgvdnr.Item(2, i).Value = dr(2)
            dgvdnr.Item(3, i).Value = dr(3)
            dgvdnr.Item(4, i).Value = dr(4)
            dgvdnr.Item(5, i).Value = dr(5)
            dgvdnr.Item(6, i).Value = dr(6)
            dgvdnr.Item(7, i).Value = dr(7)
            dgvdnr.Item(8, i).Value = dr(8)
            i = i + 1
        End While
        connection_close()
    End Sub
End Class
