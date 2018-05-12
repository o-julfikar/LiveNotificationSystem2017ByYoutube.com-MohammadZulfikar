Public Class NewReportForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim db As New LADDataContext
        Dim newReport As New UserReport With {.ReportDate = Format(Now, "dd MMMM yyyy"), .ReportDescription = txtMsg.Text, .ReportHandler = "N/ A", .ReportStatus = "Pending", .Username = HomePage.mainUsername.Text}
        db.UserReports.InsertOnSubmit(newReport)
        db.SubmitChanges()
        MsgBox("New report added successfully")
        txtMsg.Clear()
        txtMsg.Focus()
    End Sub
End Class
