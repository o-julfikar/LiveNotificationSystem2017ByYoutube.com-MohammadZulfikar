Imports System.ComponentModel

Public Class ViewReportForm
    Private Sub ViewReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LAD.UserReports' table. You can move, or remove it, as needed.
        Me.UserReportsTableAdapter.Fill(Me.LAD.UserReports)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvReport.CurrentRow.Cells(4).Value = "Cancelled"
        dgvReport.CurrentRow.Cells(5).Value = HomePage.mainUsername.Text
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        acceptMenu.Show(btnAccept, New Point(0, 0), ArrowDirection.Up)
    End Sub

    Private Sub ViewedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewedToolStripMenuItem.Click
        dgvReport.CurrentRow.Cells(4).Value = "Viewed"
        dgvReport.CurrentRow.Cells(5).Value = HomePage.mainUsername.Text
    End Sub

    Private Sub OnProgressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnProgressToolStripMenuItem.Click
        dgvReport.CurrentRow.Cells(4).Value = "On Progress"
        dgvReport.CurrentRow.Cells(5).Value = HomePage.mainUsername.Text
    End Sub

    Private Sub SolvedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolvedToolStripMenuItem.Click
        dgvReport.CurrentRow.Cells(4).Value = "Solved"
        dgvReport.CurrentRow.Cells(5).Value = HomePage.mainUsername.Text
    End Sub

    Private Sub ViewReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Me.Validate()
            Me.UserReportsBindingSource.EndEdit()
            Me.UserReportsTableAdapter.Update(Me.LAD.UserReports)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellContentClick

    End Sub

    Private Sub dgvReport_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellContentDoubleClick
        btnAccept.PerformClick()
    End Sub
End Class
