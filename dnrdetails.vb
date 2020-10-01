Imports System.Data.OleDb
Public Class dnrdetails
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtrno.Text = "" Or txtsname.Text = "" Or cbclass.Text = "-Select class-" Or cbclass.Text = "" Or cbyear.Text = "-Select Year-" Or cbyear.Text = "" Or cbblood.Text = "-Select bgrp-" Or cbblood.Text = "" Or dtdob.Text = "" Or txtaddr.Text = "" Or txtmob.Text = "" Then
            MsgBox("Please Enter The Required Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtmob.Text.Length <> 10 Then
            MsgBox("Invalid Mobile Number", MsgBoxStyle.Exclamation)
            txtmob.Focus()
            Exit Sub
        End If

        If rdomale.Checked = True Then
            gen = "M"
        ElseIf rdofemale.Checked = True Then
            gen = "F"
        Else
            MsgBox("Please Entre Gender")
            Exit Sub
        End If

        If dtdob.Value > Date.Today Then
            MsgBox("Date of Birth Can't be After Today")
            Exit Sub
        End If

        If btnsave.Text = "SAVE" Then
            connectiondb()
            qry = "insert into dnr(rno,sname,class,bgrp,yr,dob,gen,addr,mob) values ('" & txtrno.Text & "','" & txtsname.Text & "','" & cbclass.Text & "','" & cbblood.Text & "','" & cbyear.Text & "','" & dtdob.Value.Date & "','" & gen & "','" & txtaddr.Text & "'," & txtmob.Text & ")"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Donor Details Added Successfully", MsgBoxStyle.Information)

        ElseIf btnsave.Text = "Update" Then
            connectiondb()
            qry = "update dnr set sname='" & txtsname.Text & "',class='" & cbclass.Text & "',bgrp='" & cbblood.Text & "',yr='" & cbyear.Text & "',dob='" & dtdob.Value.Date & "',gen='" & gen & "',addr='" & txtaddr.Text & "',mob=" & txtmob.Text & " where rno='" & txtrno.Text & "'"
            cmd = New OleDbCommand(qry, con)
            cmd.ExecuteNonQuery()
            connection_close()
            MsgBox("Donor Details Updated Successfully", MsgBoxStyle.Information)
        End If
        reset()
    End Sub

    Public Sub reset()
        txtrno.Text = ""
        txtsname.Text = ""
        cbclass.Text = "-Select class-"
        cbblood.Text = "-Select bgrp-"
        cbyear.Text = "-Select year-"
        dtdob.Text = ""
        txtaddr.Text = ""
        txtmob.Text = ""
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Private Sub txtrno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrno.TextChanged
        Dim gen As String
        connectiondb()
        qry = "select * from dnr where rno='" & txtrno.Text & "'"
        cmd = New OleDbCommand(qry, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtsname.Text = dr(1)
            cbclass.Text = dr(2)
            cbblood.Text = dr(3)
            cbyear.Text = dr(4)
            dtdob.Text = dr(5)
            gen = dr(6)
            If gen.Equals("M") Then
                rdomale.Checked = True
            ElseIf gen.Equals("F") Then
                rdofemale.Checked = True
            End If

            txtaddr.Text = dr(7)
            txtmob.Text = dr(8)
            btnsave.Text = "Update"
        Else
            txtsname.Clear()
            cbclass.Text = "-Select class-"
            cbblood.Text = "-Select bgrp-"
            cbyear.Text = "-Select Year-"
            txtaddr.Clear()
            txtmob.Clear()
            btnsave.Text = "SAVE"
        End If
        connection_close()

    End Sub

    Private Sub txtmob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmob.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsname.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtclass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dnrdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbclass.Items.Add("B.Com")
        cbclass.Items.Add("BBA")
        cbclass.Items.Add("BA")
        cbclass.Items.Add("B.Com(VOC)")

        cbyear.Items.Add("I-YEAR")
        cbyear.Items.Add("II-YEAR")
        cbyear.Items.Add("III-YEAR")

        cbblood.Items.Add("A+")
        cbblood.Items.Add("A-")
        cbblood.Items.Add("B+")
        cbblood.Items.Add("B-")
        cbblood.Items.Add("O+")
        cbblood.Items.Add("O-")
        cbblood.Items.Add("AB+")
        cbblood.Items.Add("AB-")
    End Sub
End Class