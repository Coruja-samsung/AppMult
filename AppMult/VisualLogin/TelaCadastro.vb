Public Class TelaCadastro
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inicio.TelaCadastro1.Visible = False
        Inicio.TelaLogin1.Visible = True
    End Sub

    Private Sub Salvar_Click(sender As Object, e As EventArgs) Handles Salvar.Click
        If nome.Text = "" Then
            RJMessageBox.Show("Preencha o campo Nome!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            nome.Focus()
            Exit Sub
        End If
        If usuario.Text = "" Then
            RJMessageBox.Show("Preencha o campo Usuario!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            usuario.Focus()
            Exit Sub
        End If
        If Senha.Text = "" Then
            RJMessageBox.Show("Preencha o campo Senha!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            Senha.Focus()
            Exit Sub
        End If
        If Senha2.Text = "" Then
            RJMessageBox.Show("Preencha o campo Senha!",
                                "Atenção!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            Senha2.Focus()
            Exit Sub
        End If

        If Senha2.Text <> Senha.Text Then
            RJMessageBox.Show("Senhas nao conhecidem!",
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Senha.Focus()
            Exit Sub
        End If

        Criarusuario(nome.Text, usuario.Text, Senha.Text)

    End Sub
End Class
