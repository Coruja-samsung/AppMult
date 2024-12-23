Public Class TelaLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicio.TelaCadastro1.Visible = True
        Inicio.TelaLogin1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        logar(txtUsuario.Text, txtSenha.Text)
    End Sub
End Class
