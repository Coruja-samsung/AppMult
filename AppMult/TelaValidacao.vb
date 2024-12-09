Imports System.Data.OleDb

Public Class TelaValidacao

    Private Sub AjustarTamanhoFonte(lb)
        ' Verifique se a Label existe
        If lb IsNot Nothing Then
            ' Ajustar o tamanho da fonte com base na altura da Label
            Dim fatorRedimensionamento As Single = lb.Height / 1.75  ' Por exemplo, 1/10 da altura da Label
            lb.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)
            AjustarTamanhoFonteTxtBox()
        End If
    End Sub

    Private Sub AjustarTamanhoFonteTxtBox()

        ' Ajustar o tamanho da fonte com base na altura da Label
        Dim fatorRedimensionamento As Single = Label1.Height / 2  ' Por exemplo, 1/10 da altura da Label

        TextBox1.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)
        TextBox2.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)
        TextBox3.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)

        AdvancedDataGridView1.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)

        'Button1.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)
        'Button2.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)

    End Sub

    Private Sub Label1_Resize(sender As Object, e As EventArgs) Handles Label1.Resize, Label2.Resize, Label3.Resize, Label4.Resize, Label5.Resize, Label6.Resize, Label7.Resize
        AjustarTamanhoFonte(sender)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = ChrW(13) Then

            Dim stopwatch As Stopwatch
            stopwatch = New Stopwatch()
            stopwatch.Start()

            ' Caminhos dos arquivos Excel
            Dim excelFile1 As String = "C:\Users\Luiz Henrique\Desktop\BaseMult\Base\Search.xlsx"
            Dim excelFile2 As String = "C:\Users\Luiz Henrique\Desktop\BaseMult\Base\Eans.xlsx"
            Dim AcessBD As String = "C:\Users\Luiz Henrique\Desktop\BaseMult\Base\AppMult.accdb"

            ' Conexão com o banco de dados Access
            Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD

            ' Consulta SQL para ler os dados do primeiro arquivo Excel
            Dim query1 As String = "SELECT [Pallet Group], [Pallet No#], [Item Code] FROM [Planilha1$]"

            ' Consulta SQL para ler os dados do segundo arquivo Excel
            Dim query2 As String = "SELECT [Item Code], [Alt# Code] FROM [Planilha2$]"

            ' Executando a consulta e inserindo os dados no banco de dados Access
            Try
                Dim dt1 As New DataTable()
                ' Conectando ao primeiro arquivo Excel
                Using conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelFile1 & ";Extended Properties='Excel 12.0 Xml;HDR=YES';")
                    conn1.Open()
                    ' Cria um comando para a consulta SQL
                    Using cmd1 As New OleDbCommand(query1, conn1)
                        ' Cria um adaptador para preencher o DataTable
                        Dim da1 As New OleDbDataAdapter(cmd1)
                        da1.Fill(dt1)
                        conn1.Close()
                    End Using
                End Using

                Dim dt2 As New DataTable()
                ' Conectando ao segundo arquivo Excel
                Using conn2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelFile2 & ";Extended Properties='Excel 12.0 Xml;HDR=YES';")
                    conn2.Open()
                    ' Cria um comando para a consulta SQL no segundo arquivo Excel
                    Using cmd2 As New OleDbCommand(query2, conn2)
                        ' Cria um adaptador para preencher o DataTable
                        Dim da2 As New OleDbDataAdapter(cmd2)
                        da2.Fill(dt2)
                        conn2.Close()
                    End Using
                End Using

                ' Conectando ao banco de dados Access
                Using accessConn As New OleDbConnection(accessConnStr)
                    accessConn.Open()

                    ' Criar uma variável para armazenar a tabela temporária
                    Dim tabela As New DataTable()
                    tabela.Columns.Add("Cod_Caixa")
                    tabela.Columns.Add("SKUs")
                    tabela.Columns.Add("EANs")
                    tabela.Columns.Add("SERIALs")
                    tabela.Columns.Add("STATUs")

                    ' Iterar pelas linhas da primeira tabela (dt1)
                    For Each row1 As DataRow In dt1.Rows
                        If TextBox1.Text = row1.Field(Of String)("Pallet Group") Then
                            ' Procurar a linha correspondente na tabela dt2
                            Dim row2 As DataRow = dt2.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("Item Code") = row1.Field(Of String)("Item Code"))
                            If row2 IsNot Nothing Then
                                ' Adicionar os dados na tabela temporária
                                tabela.Rows.Add(
                                    row1("Pallet Group"),
                                    row1("Item Code"),
                                    row2("Alt# Code"),
                                    row1("Pallet No#")
                                )
                            Else
                                MessageBox.Show("Atualize o Arquivo de Eans!", "Atenção", MessageBoxButtons.OKCancel)
                            End If
                        End If
                    Next

                    AdvancedDataGridView1.DataSource = Nothing

                    AdvancedDataGridView1.DataSource = tabela

                    AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(0), False)
                    AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(1), False)
                    AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(2), False)
                    AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(3), False)
                    AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(4), False)




                End Using

                stopwatch.Stop()

                Dim elapsed As TimeSpan = stopwatch.Elapsed

                ' Formatando o TimeSpan como "hh:mm:ss:fff"
                Dim formattedTime As String = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}",
                                                       elapsed.Hours,
                                                       elapsed.Minutes,
                                                       elapsed.Seconds,
                                                       elapsed.Milliseconds)

                MessageBox.Show("Dados inseridos com sucesso! " & formattedTime)
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try
        End If

    End Sub

End Class