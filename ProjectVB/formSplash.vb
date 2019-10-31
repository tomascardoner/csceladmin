Public Class formSplash

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title
        lblTitle.Text = My.Application.Info.Title
        lblVersion.Text = "Versión " & My.Application.Info.Version.ToString
    End Sub
End Class