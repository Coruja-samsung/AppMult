Imports System.Data.OleDb

Module ConexaoBD

    Public Sub Bddedados()

        Dim stopwatch As Stopwatch
        stopwatch = New Stopwatch()
        stopwatch.Start()

        ' Caminhos dos arquivos Excel
        Dim excelFile1 As String = "C:\Users\luiz.os\Desktop\BaseAppMult\SerialScan.xls"
        Dim excelFile2 As String = "C:\Users\luiz.os\Desktop\BaseAppMult\EANs.xls"
        Dim AcessBD As String = "C:\Users\luiz.os\Desktop\BaseAppMult\AppMult.accdb"

        ' Conexão com o banco de dados Access
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD

        ' Consulta SQL para ler os dados do primeiro arquivo Excel
        Dim query1 As String = "SELECT F9, F5, F10 FROM [sheet1$] WHERE F9 IS NOT NULL AND F9 <> ' ' AND F5 <> 'Item Code' "

        ' Consulta SQL para ler os dados do segundo arquivo Excel
        Dim query2 As String = "SELECT F3, F1 FROM [sheet1$] WHERE F3 IS NOT NULL AND F3 <> 'Item Code'"

        ' Executando a consulta e inserindo os dados no banco de dados Access
        Try
            OpenExcelSerial()
            Dim dt1 As New DataTable()
            ' Conectando ao primeiro arquivo Excel
            Using conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelFile1 & ";Extended Properties='Excel 12.0;HDR=NO';")
                conn1.Open()
                ' Cria um comando para a consulta SQL
                Using cmd1 As New OleDbCommand(query1, conn1)
                    ' Cria um adaptador para preencher o DataTable
                    Dim da1 As New OleDbDataAdapter(cmd1)
                    da1.Fill(dt1)
                    conn1.Close()
                End Using
            End Using
            CloseExcels()

            OpenExcelEan()
            Dim dt2 As New DataTable()
            ' Conectando ao segundo arquivo Excel
            Using conn2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelFile2 & ";Extended Properties='Excel 12.0;HDR=NO';")
                conn2.Open()
                ' Cria um comando para a consulta SQL no segundo arquivo Excel
                Using cmd2 As New OleDbCommand(query2, conn2)
                    ' Cria um adaptador para preencher o DataTable
                    Dim da2 As New OleDbDataAdapter(cmd2)
                    da2.Fill(dt2)
                    conn2.Close()
                End Using
            End Using
            CloseExcels()

            ' Conectando ao banco de dados Access
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()

                Dim DeleteQuery As String = "DELETE FROM Validacao;"
                Using DeleteCmd As New OleDbCommand(DeleteQuery, accessConn)
                    DeleteCmd.ExecuteNonQuery()
                End Using

                ' Para cada linha no DataTable do primeiro arquivo Excel, insira os dados na tabela Access
                For Each row1 As DataRow In dt1.Rows
                    ' Achar a linha correspondente no segundo DataTable
                    Dim row2 As DataRow = dt2.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("F3") = row1.Field(Of String)("F5"))

                    If row2 IsNot Nothing Then
                        ' Monta o comando SQL para inserção no Access
                        Dim insertQuery As String = "INSERT INTO Validacao (CAIXA, SKU, EAN, SERIAL) VALUES (?, ?, ?, ?)"

                        Using insertCmd As New OleDbCommand(insertQuery, accessConn)
                            ' Adiciona os parâmetros da consulta
                            insertCmd.Parameters.AddWithValue("?", row1("F9"))
                            insertCmd.Parameters.AddWithValue("?", row1("F5"))
                            insertCmd.Parameters.AddWithValue("?", row2("F1"))
                            insertCmd.Parameters.AddWithValue("?", row1("F10"))
                            ' Executa o comando de inserção
                            insertCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Monta o comando SQL para inserção no Access
                        Dim insertQuery As String = "INSERT INTO Validacao (CAIXA, SKU, EAN, SERIAL) VALUES (?, ?, ?, ?)"

                        Using insertCmd As New OleDbCommand(insertQuery, accessConn)
                            ' Adiciona os parâmetros da consulta
                            insertCmd.Parameters.AddWithValue("?", row1("F9"))
                            insertCmd.Parameters.AddWithValue("?", row1("F5"))
                            insertCmd.Parameters.AddWithValue("?", row1("F10"))
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
            CloseExcels()
            MessageBox.Show("Erro: " & ex.Message)
        End Try
    End Sub



End Module
