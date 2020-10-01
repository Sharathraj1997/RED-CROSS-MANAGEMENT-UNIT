Imports System.Data.OleDb
Public Class guest

    Private Sub btnaccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtgname.Text = "" Or txttopic.Text = "" Or dtdob.Text = "" Then
            MsgBox("Please Enter the Required Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If dtdob.Value > Date.Today Then
            MsgBox("Date of Birth Can't be After Today")
            Exit Sub
        End If

        If btnsave.Text = "SAVE" Then
            connectiondb()
            qry = "insert into guest(gname,topic,dob) values ('" & txtgname.Text & "','" & txttopic.Text & "','" & dtdob.Value.Date & "')"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("guest details added successfully", MsgBoxStyle.Information)

        ElseIf btnsave.Text = "Update" Then
            connectiondb()
            qry = "update guest set gname='" & txtgname.Text & "',topic='" & txttopic.Text & "',dob='" & dtdob.Text & "'"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Guest details updated successfully", MsgBoxStyle.Information)
        End If
    End Sub


    Public Sub reset()
        txtgname.Text = ""
        txttopic.Text = ""
        dtdob.Text = ""
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub




    Private Sub txtgname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgname.TextChanged
        connectiondb()
        qry = "select * from guest where gname='" & txtgname.Text & "'"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtgname.Text = dr(1)
            txttopic.Text = dr(2)
            dtdob.Text = dr(3)
            btnsave.Text = "Update"
        Else
            txtgname.Clear()
            txttopic.Clear()
            btnsave.Text = "SAVE"
        End If
        connection_close()

    End Sub

    Private Sub txtgname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgname.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttopic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttopic.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class