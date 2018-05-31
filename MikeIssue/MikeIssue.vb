Public Class MikeIssue

    Private Sub cmdEnhance_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnhance.Click
        Dim issueNum = Me.txtIssue.Text.Trim
        If Not IsNumeric(issueNum) Then
            MessageBox.Show("Not a number, silly!")
            Exit Sub
        End If

        Dim url = "https://github.com/fgpv-vpgf/fgpv-vpgf/issues/" + issueNum
        Process.Start(url)


    End Sub
End Class
