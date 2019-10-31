Public Class formMain

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = My.Application.Info.Title
    End Sub

    Private Sub PasteText(sender As Object, e As EventArgs) Handles buttonPasteText.Click
        If formPasteText.ShowDialog() = Windows.Forms.DialogResult.OK And formPasteText.cboFactura.SelectedIndex > -1 And Not String.IsNullOrWhiteSpace(formPasteText.txtPastedText.Text) Then
            If ReadDataFromPastedTextV2(formPasteText.cboFactura.SelectedValue, formPasteText.txtPastedText.Text) Then
                formPasteText.Close()
                formPasteText.Dispose()
            End If
        Else
            formPasteText.Close()
            formPasteText.Dispose()
        End If
    End Sub

    Private Sub btnViewData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonViewData.Click
        formViewData.Show(Me)
    End Sub
    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TerminateApplication()
    End Sub
End Class
