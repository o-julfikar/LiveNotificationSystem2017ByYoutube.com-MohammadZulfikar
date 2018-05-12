Public Class HomePage
    Dim db As New LADDataContext

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LiveTrack_Tick(sender As Object, e As EventArgs) Handles LiveTrack.Tick
        Me.Text = "Home Page - " & txtUsername.Text
        cboUser.SelectedValue = mainUsername.Text
        Dim rCount = From p In db.UserReports
                     Where p.ReportStatus = "Pending"
                     Select p

        btnrCount.Text = rCount.Count.ToString
        If Val(btnrCount.Text) > 0 Then
            btnrCount.BackColor = Color.Red
        Else
            btnrCount.BackColor = Color.Green
        End If
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.LAD.Users)

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        RegForm.Show()
    End Sub

    Private Sub UserLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLogToolStripMenuItem.Click
        LogForm.ShowDialog()
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        ManageUsers.ShowDialog()
        HomePage_Load(sender, e)
    End Sub

    Private Sub txtPhotoLoc_TextChanged(sender As Object, e As EventArgs) Handles txtPhotoLoc.TextChanged
        PicUser.ImageLocation = txtPhotoLoc.Text
    End Sub

    Private Sub NewReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReportToolStripMenuItem.Click
        NewReportForm.ShowDialog()
    End Sub

    Private Sub btnrCount_Click(sender As Object, e As EventArgs) Handles btnrCount.Click
        ViewReportForm.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        BackupForm.Show()
    End Sub
End Class
