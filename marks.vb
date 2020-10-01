Imports System.Data.OleDb
Public Class marks
    Private Sub btnaccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccept.Click
        If txtregnum.Text = "" Or cbclass.Text = "Select Class" Or cbclass.Text = "" Or cbyear.Text = "" Or cbyear.Text = "Select Year" Or txtsname.Text = "" Or txtattend.Text = "" Or txtparticipation.Text = "" Or txtmarks.Text = "" Then
            MsgBox("Please Enter The Required Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        
        If btnaccept.Text = "ACCEPT" Then
            connectiondb()
            qry = "insert into marks(rno,cls,yr,sname,attend,parti,othr,mrks) values ('" & txtregnum.Text & "','" & cbclass.Text & "','" & cbyear.Text & "','" & txtsname.Text & "'," & txtattend.Text & "," & txtparticipation.Text & "," & txtothers.Text & "," & txtmarks.Text & ")"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Marks Details Added Successfully", MsgBoxStyle.Information)

        ElseIf btnaccept.Text = "UPDATE" Then
            connectiondb()
            qry = "update marks set cls='" & cbclass.Text & "',yr='" & cbyear.Text & "',sname='" & txtsname.Text & "',attend=" & txtattend.Text & ",parti=" & txtparticipation.Text & ",othr=" & txtothers.Text & ",mrks=" & txtmarks.Text & " where rno='" & txtregnum.Text & "'"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Marks Details Updated Successfully", MsgBoxStyle.Information)
        End If
        reset()
    End Sub

    Public Sub reset()
        txtregnum.Text = ""
        cbclass.Text = "Select Class"
        cbyear.Text = "Select Year"
        txtsname.Text = ""
        txtattend.Text = ""
        txtparticipation.Text = ""
        txtothers.Text = ""
        txtmarks.Text = ""
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        reset()
    End Sub

    Private Sub txtattend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtattend.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtparticipation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtparticipation.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtothers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtothers.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarks.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub txtregnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtregnum.TextChanged
        connectiondb()
        qry = "select * from marks where rno='" & txtregnum.Text & "'"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            cbclass.Text = dr(1)
            cbyear.Text = dr(2)
            txtsname.Text = dr(3)
            txtattend.Text = dr(4)
            txtparticipation.Text = dr(5)
            txtothers.Text = dr(6)
            txtmarks.Text = dr(7)
            btnaccept.Text = "UPDATE"
        Else
            cbclass.Text = "Select Class"
            cbyear.Text = "Select Year"
            txtsname.Clear()
            txtattend.Clear()
            txtparticipation.Clear()
            txtothers.Clear()
            txtmarks.Clear()
            btnaccept.Text = "ACCEPT"
        End If
        connection_close()
    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        If txtattend.Text = "" Or txtparticipation.Text = "" Or txtothers.Text = "" Then
            MsgBox("Enter required fields")
        Else
            txtmarks.Text = Val(txtattend.Text) + Val(txtparticipation.Text) + Val(txtothers.Text)
            If Val(txtmarks.Text) > 50 Then
                MsgBox("Total Marks Should Exceed 50")
                txtattend.Text = ""
                txtparticipation.Text = ""
                txtothers.Text = ""
                txtmarks.Text = ""
                txtattend.Focus()
            End If
        End If
    End Sub

    Private Sub marks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtmarks.ReadOnly = True
        cbclass.Items.Add("B.Com")
        cbclass.Items.Add("BBA")
        cbclass.Items.Add("BA")
        cbclass.Items.Add("B.Com(VOC)")
        cbyear.Items.Add("I-YEAR")
        cbyear.Items.Add("II-YEAR")
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtattend.Focus()
    End Sub

    Private Sub txtsname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsname.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class