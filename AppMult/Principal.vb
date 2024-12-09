Public Class Principal
    Private Sub ButtonRecize_Click(sender As Object, e As EventArgs) Handles ButtonRecize.Click
        If PanelMenu.Width > 200 Then
            PanelMenu.Width = 77
        Else
            PanelMenu.Width = 256
        End If
    End Sub

    Sub hideTelas()
        TelaAtualizarSearch1.Visible = False
        TelaAtualizaEan1.Visible = False
        TelaValidacao1.Visible = False
    End Sub
    Sub hideSubMenus()
        SubMenuAtualizar.Visible = False
        ButtonAtualizar.Text = "Atualizar        ⏷"
    End Sub
    Sub resetColor()
        ButtonSearch.BackColor = Color.FromArgb(CByte(13), CByte(10), CByte(157))
        ButtonEans.BackColor = Color.FromArgb(CByte(13), CByte(10), CByte(157))
    End Sub

    Private Sub ButtonValidacao_Click(sender As Object, e As EventArgs) Handles ButtonValidacao.Click
        hideTelas()
        hideSubMenus()

        TelaValidacao1.Visible = True

        PanelSelecao.Top = sender.Top
        lbCaminho.Text = "Home / " & sender.text
    End Sub

    Private Sub ButtonAtualizar_Click(sender As Object, e As EventArgs) Handles ButtonAtualizar.Click
        If SubMenuAtualizar.Visible = True Then
            ButtonAtualizar.Text = "Atualizar        ⏷"
            SubMenuAtualizar.Visible = False
        Else
            ButtonAtualizar.Text = "Atualizar        ⏶"
            SubMenuAtualizar.Visible = True
        End If
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click, ButtonEans.Click
        hideTelas()
        resetColor()

        If sender Is ButtonSearch Then
            TelaAtualizarSearch1.Visible = True
        ElseIf sender Is ButtonEans Then
            TelaAtualizaEan1.Visible = True
        End If

        PanelSelecao.Top = ButtonAtualizar.Top
        lbCaminho.Text = "Home / Atualizar / " & sender.text
        sender.BackColor = Color.Blue

    End Sub

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.Close()
    End Sub


End Class