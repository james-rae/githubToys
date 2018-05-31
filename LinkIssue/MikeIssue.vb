Public Class MikeIssue

    Private Sub cmdEnhance_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnhance.Click
        Dim issueNum = Me.txtIssue.Text.Trim
        If Not IsNumeric(issueNum) Then
            MessageBox.Show("Not a number, silly!")
            Exit Sub
        End If

        Dim url = "=HYPERLINK(""https://github.com/fgpv-vpgf/fgpv-vpgf/issues/" + issueNum + """,""" & issueNum & """)"
        Clipboard.SetText(url)
        tmrThanks.Enabled = True
        lblThanks.Visible = True

    End Sub

    Private Sub tmrThanks_Tick(sender As Object, e As EventArgs) Handles tmrThanks.Tick
        tmrThanks.Enabled = False
        lblThanks.Visible = False
    End Sub
End Class
