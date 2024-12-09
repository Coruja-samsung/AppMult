Imports System.Data.OleDb

Module ConexaoBD

    Public Sub Bddedados()

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

                ' Para cada linha no DataTable do primeiro arquivo Excel, insira os dados na tabela Access
                For Each row1 As DataRow In dt1.Rows
                    ' Achar a linha correspondente no segundo DataTable
                    Dim row2 As DataRow = dt2.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("Item Code") = row1.Field(Of String)("Item Code"))

                    If row2 IsNot Nothing Then
                        ' Monta o comando SQL para inserção no Access
                        Dim insertQuery As String = "INSERT INTO BaseValidacao (Caixa, Cod_Item, Ean, Serial) VALUES (?, ?, ?, ?)"

                        Using insertCmd As New OleDbCommand(insertQuery, accessConn)
                            ' Adiciona os parâmetros da consulta
                            insertCmd.Parameters.AddWithValue("?", row1("Pallet Group"))
                            insertCmd.Parameters.AddWithValue("?", row1("Item Code"))
                            insertCmd.Parameters.AddWithValue("?", row2("Alt# Code"))
                            insertCmd.Parameters.AddWithValue("?", row1("Pallet No#"))

                            ' Executa o comando de inserção
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
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
    End Sub



End Module
