Imports System.Data.OleDb
Public Class login1
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtpassward.Text = "" Then
            MsgBox("Please Enter The Login Details", MsgBoxStyle.Exclamation)
        Else
            connectiondb()
            qry = "select * from login where uname='" & ComboBox1.Text & "' and pwd='" & txtpassward.Text & "'"
            cmd = New OleDbCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                uname = ComboBox1.Text
                mainfrm.Show()
                Me.Hide()
            Else
                MsgBox("Invalid User", MsgBoxStyle.Exclamation)
                txtpassward.Clear()
            End If
            connection_close()
        End If
    End Sub

    Private Sub txtpassward_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassward.Enter
        txtpassward.Clear()
        txtpassward.UseSystemPasswordChar = True
    End Sub

    Private Sub txtpassward_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtpassward.MouseClick
        txtpassward.Clear()
        txtpassward.UseSystemPasswordChar = True
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
    End Sub
End Class