Imports System.Data.OleDb

Module ConexaoBD

    Dim caminho_executavel As String = System.AppDomain.CurrentDomain.BaseDirectory.ToString()

    Public AcessBD As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\AppMult.accdb"
    Public CaminhoSerial As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\SerialScan.xls"
    Public CaminhoEan As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\EANs.xls"

    Public UsuarioLogado As String
    Public NomeLogado As String

    Public Sub Bddedados()

        Dim stopwatch As Stopwatch
        stopwatch = New Stopwatch()
        stopwatch.Start()

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
            Using conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & CaminhoSerial & ";Extended Properties='Excel 12.0;HDR=NO';")
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
            Using conn2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & CaminhoEan & ";Extended Properties='Excel 12.0;HDR=NO';")
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
                            insertCmd.Parameters.AddWithValue("?", "")
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

    Function PegarCaixa(Caixa As String)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "SELECT * FROM Validacao"

        Try
            ' Conectando ao banco de dados Access
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()

                Dim dt1 As New DataTable
                Using cmd1 As New OleDbCommand(query, accessConn)
                    ' Cria um adaptador para preencher o DataTable
                    Dim da1 As New OleDbDataAdapter(cmd1)
                    da1.Fill(dt1)
                End Using

                Dim Table As New DataTable()
                Table.Columns.Add("CAIXA", GetType(String))
                Table.Columns.Add("SKUs", GetType(String))
                Table.Columns.Add("EANs", GetType(String))
                Table.Columns.Add("SERIALs", GetType(String))

                ' Iterar pelas linhas da primeira tabela (dt1)
                For Each row1 As DataRow In dt1.Rows
                    If Caixa = row1.Field(Of String)("CAIXA") Then
                        ' Procurar a linha correspondente na tabela dt2
                        If row1.Field(Of String)("EAN") <> "" Then
                            ' Adicionar os dados na tabela temporária
                            Dim newrow As Object() = {
                                row1("CAIXA"),
                                row1("SKU"),
                                row1("EAN"),
                                row1("SERIAL")}
                            Table.Rows.Add(newrow)
                        Else
                            Return "EAN"
                            Exit Function
                        End If
                    End If
                Next
                Return Table
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message)
        End Try
    End Function

    Sub Criarusuario(nomeb As String, usuariob As String, senhab As String)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "INSERT INTO Usuarios (Usuario, Senha, Nome) VALUES (?, ?, ?)"

        Try
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()
                Using insertCmd As New OleDbCommand(query, accessConn)
                    ' Adiciona os parâmetros da consulta
                    insertCmd.Parameters.AddWithValue("?", usuariob)
                    insertCmd.Parameters.AddWithValue("?", senhab)
                    insertCmd.Parameters.AddWithValue("?", nomeb)
                    ' Executa o comando de inserção
                    insertCmd.ExecuteNonQuery()
                End Using
            End Using

            Inicio.TelaCadastro1.nome.Text = ""
            Inicio.TelaCadastro1.usuario.Text = ""
            Inicio.TelaCadastro1.Senha.Text = ""
            Inicio.TelaCadastro1.Senha2.Text = ""

            MessageBox.Show("Usuario Cadastrado com Sucesso!")

            Inicio.TelaCadastro1.Visible = False
            Inicio.TelaLogin1.Visible = True

        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message)
        End Try

    End Sub

    Sub logar(usuariob As String, senhab As String)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "SELECT * FROM Usuarios"

        Try
            ' Conectando ao banco de dados Access
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()

                Dim dt1 As New DataTable
                Using cmd1 As New OleDbCommand(query, accessConn)
                    ' Cria um adaptador para preencher o DataTable
                    Dim da1 As New OleDbDataAdapter(cmd1)
                    da1.Fill(dt1)
                End Using

                ' Iterar pelas linhas da primeira tabela (dt1)
                For Each row1 As DataRow In dt1.Rows
                    If usuariob = row1.Field(Of String)("Usuario") Then
                        If senhab = row1.Field(Of String)("Senha") Then
                            NomeLogado = row1.Field(Of String)("Nome")
                            UsuarioLogado = row1.Field(Of String)("Usuario")

                            Principal.Show()
                            Inicio.Close()

                            Exit Sub
                        Else
                            MessageBox.Show("Senha incorreta!")
                            Exit Sub
                        End If
                    End If
                Next row1
                MessageBox.Show("Usuario Não encontrado!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message)
        End Try
    End Sub


    ' receber tabela e usuario e hora
    Function salvarvalidado(validado As DataTable)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "INSERT INTO historicovalidacao (Data_hora_Validacao, Caixa, SKU, Ean, Serial, Usuario, Nome) VALUES (?, ?, ?, ?, ?, ?, ?)"

        Try
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()
                Using insertCmd As New OleDbCommand(query, accessConn)
                    For Each row1 As DataRow In validado.Rows
                        ' adicionar a tabela que vier em uma variavel e usuario e hora
                        insertCmd.Parameters.AddWithValue("?", Now)
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("CAIXA"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("SKUs"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("EANs"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("SERIALs"))
                        insertCmd.Parameters.AddWithValue("?", ConexaoBD.UsuarioLogado)
                        insertCmd.Parameters.AddWithValue("?", ConexaoBD.NomeLogado)

                        ' Executa o comando de inserção
                        insertCmd.ExecuteNonQuery()
                    Next
                End Using
            End Using

        Catch ex As Exception
            salvarvalidado = ex.Message
        End Try

    End Function

    Function salvarerros(erros As DataTable)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "INSERT INTO historicovalidacao (Data_hora_Validacao, Caixa, SKU, Ean, Serial, Erro, Usuario, Nome) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"

        Try
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()
                Using insertCmd As New OleDbCommand(query, accessConn)
                    For Each row1 As DataRow In erros.Rows
                        ' adicionar a tabela que vier em uma variavel e usuario e hora
                        insertCmd.Parameters.AddWithValue("?", Now)
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("CAIXA"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("SKUs"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("EANs"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("SERIALs"))
                        insertCmd.Parameters.AddWithValue("?", row1.Field(Of String)("Erro"))
                        insertCmd.Parameters.AddWithValue("?", ConexaoBD.UsuarioLogado)
                        insertCmd.Parameters.AddWithValue("?", ConexaoBD.NomeLogado)

                        ' Executa o comando de inserção
                        insertCmd.ExecuteNonQuery()
                    Next
                End Using
            End Using

        Catch ex As Exception
            salvarerros = ex.Message
        End Try

    End Function

End Module
