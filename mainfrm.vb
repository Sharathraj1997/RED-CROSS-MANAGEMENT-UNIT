Public Class mainfrm
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBoxResult.Yes = MsgBox("Do You Want To Exit?", MsgBoxStyle.YesNo) Then
            End
        End If
    End Sub

    Private Sub ViewStudentsDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentsDetailsToolStripMenuItem.Click
        viewstdinfo.Show()
    End Sub

    Private Sub EnterStudentsDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stdDetails.Show()
    End Sub

    Private Sub EnterDonerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterDonerDetailsToolStripMenuItem.Click
        dnrdetails.Show()
    End Sub

    Private Sub ViewDonerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDonerDetailsToolStripMenuItem.Click
        viewdnr.Show()
    End Sub

    Private Sub EnterStudentsDetailsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterStudentsDetailsToolStripMenuItem.Click
        stdDetails.Show()
    End Sub

    Private Sub ProgramsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramsToolStripMenuItem.Click
        activities.Show()
    End Sub

    Private Sub TripDetaillsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TripDetaillsToolStripMenuItem.Click
        viewACT.Show()
    End Sub

    Private Sub EntryFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryFormToolStripMenuItem.Click
        marks.Show()
    End Sub

    Private Sub ViewFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewFormToolStripMenuItem.Click
        viewMrks.Show()
    End Sub
End Class