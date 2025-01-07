
Public Class TelaAtualizaEan
    Private WithEvents bgWorker As New BackgroundWorker()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' O valor que será copiado para a área de transferência
        Dim texto As String = ConexaoBD.CaminhoEan

        ' Copiar o texto para a área de transferência
        Clipboard.SetText(texto)

        ' Mensagem para confirmar a operação
        RJMessageBox.Show("Caminho copiado para a área de transferência.",
                            "Sucesso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Bddedados()
    End Sub
End Class
