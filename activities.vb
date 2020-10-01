Imports System.Data.OleDb
Public Class activities
    Dim dt As Date

    Private Sub btnaccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccept.Click
        If txtpno.Text = "" Or txtact.Text = "" Or txtgname.Text = "" Or txtplace.Text = "" Or dtpone.Text = "" Then
            MsgBox("Please Enter The Required Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        dt = New Date()
        If dtpone.Value.Date > Today Then

            MsgBox("Date of Birth Can't be After Today")
            Exit Sub
        End If

        If btnaccept.Text = "ACCEPT" Then
            connectiondb()
            qry = "insert into activity(pno,type,gname,dt,place) values ('" & txtpno.Text & "','" & txtact.Text & "','" & txtgname.Text & "','" & dtpone.Value.Date & "','" & txtplace.Text & "')"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Guest Details Added Successfully", MsgBoxStyle.Information)

        ElseIf btnaccept.Text = "Update" Then
            connectiondb()
            qry = "update activity set type='" & txtact.Text & "',gname='" & txtgname.Text & "',dt='" & dtpone.Value.Date & "',place='" & txtplace.Text & "' where pno='" & txtpno.Text & "'"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Guest Details Updated Successfully", MsgBoxStyle.Information)
        End If
        reset()
    End Sub

    Public Sub reset()
        txtpno.Text = ""
        txtact.Text = ""
        txtgname.Text = ""
        dtpone.Text = ""
        txtplace.Text = ""
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Private Sub txtpno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpno.TextChanged
        connectiondb()
        qry = "select * from activity where pno='" & txtpno.Text & "'"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtact.Text = dr(1)
            txtgname.Text = dr(2)
            dtpone.Text = dr(3)
            txtplace.Text = dr(4)
            btnaccept.Text = "Update"
        Else
            txtact.Clear()
            txtgname.Clear()
            txtplace.Clear()
            btnaccept.Text = "ACCEPT"
        End If
        connection_close()
    End Sub

    Private Sub txtpno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtgname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgname.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class