Public Class MainForm

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = My.Application.Info.Title
    End Sub

    Private Sub PasteTextV1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasteTextV1.Click
        If PasteText.ShowDialog() = Windows.Forms.DialogResult.OK And PasteText.cboFactura.SelectedIndex > -1 And Not String.IsNullOrWhiteSpace(PasteText.txtPastedText.Text) Then
            If ReadDataFromPastedTextV1(PasteText.cboFactura.SelectedValue, PasteText.txtPastedText.Text) Then
                PasteText.Close()
                PasteText.Dispose()
            End If
        Else
            PasteText.Close()
            PasteText.Dispose()
        End If
    End Sub

    Private Sub PasteTextV2(sender As Object, e As EventArgs) Handles btnPasteTextV2.Click
        If PasteText.ShowDialog() = Windows.Forms.DialogResult.OK And PasteText.cboFactura.SelectedIndex > -1 And Not String.IsNullOrWhiteSpace(PasteText.txtPastedText.Text) Then
            If ReadDataFromPastedTextV2(PasteText.cboFactura.SelectedValue, PasteText.txtPastedText.Text) Then
                PasteText.Close()
                PasteText.Dispose()
            End If
        Else
            PasteText.Close()
            PasteText.Dispose()
        End If
    End Sub

    Private Sub btnViewData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewData.Click
        ViewData.Show(Me)
    End Sub
    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TerminateApplication()
    End Sub
End Class
