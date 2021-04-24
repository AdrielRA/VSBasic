Public Class frmOlaMundo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        lblMsg.Text = $"Bem-vindo ao mundo, {txtNome.Text}!"

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimiza_Click(sender As Object, e As EventArgs) Handles btn_Minimiza.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
