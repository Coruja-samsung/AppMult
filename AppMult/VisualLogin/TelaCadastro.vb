Public Class TelaCadastro
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicio.TelaCadastro1.Visible = False
        Inicio.TelaLogin1.Visible = True
    End Sub

    Private Sub Salvar_Click(sender As Object, e As EventArgs) Handles Salvar.Click
        If nome.Text = "" Then
            MessageBox.Show("Preencha o campo Nome!")
            nome.Focus()
            Exit Sub
        End If
        If usuario.Text = "" Then
            MessageBox.Show("Preencha o campo Usuario!")
            usuario.Focus()
            Exit Sub
        End If
        If Senha.Text = "" Then
            MessageBox.Show("Preencha o campo Senha!")
            Senha.Focus()
            Exit Sub
        End If
        If Senha2.Text = "" Then
            MessageBox.Show("Preencha o campo Senha 2!")
            Senha2.Focus()
            Exit Sub
        End If

        If Senha2.Text <> Senha.Text Then
            MessageBox.Show("Senhas nao conhecidem!")
            Senha.Focus()
            Exit Sub
        End If

        Criarusuario(nome.Text, usuario.Text, Senha.Text)

    End Sub
End Class
