Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Windows.Win32.System

Module ConexaoBD

    'Public AcessBD As String = Application.StartupPath & "Base\AppMult.accdb"
    'Public CaminhoSerial As String = Application.StartupPath & "Base\SerialScan.xls"
    'Public CaminhoEan As String = Application.StartupPath & "Base\EANs.xls"

    Public AcessBD As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\AppMult.accdb"
    Public CaminhoSerial As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\SerialScan.xls"
    Public CaminhoEan As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\EANs.xls"

    Public UsuarioLogado As String
    Public NomeLogado As String

    Public Sub Bddedados()

        Dim form2 As New Loading()
        Dim formTask As Task = Task.Run(Sub()
                                            form2.ShowDialog()
                                        End Sub)

        Dim stopwatch As Stopwatch
        stopwatch = New Stopwatch()
        stopwatch.Start()

        ' Conexão com o banco de dados Access
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD

        ' Executando a consulta e inserindo os dados no banco de dados Access
        Try

            Dim dt1 As New DataTable()

            ' Criação de objetos para Excel
            Dim excelApp As Excel.Application = Nothing
            Dim excelWorkbook As Excel.Workbook = Nothing
            Dim excelWorksheet As Excel.Worksheet = Nothing

            ' Inicia a aplicação do Excel
            excelApp = New Excel.Application()
            excelWorkbook = excelApp.Workbooks.Open(CaminhoSerial)
            excelWorksheet = CType(excelWorkbook.Sheets(1), Excel.Worksheet)

            ' Processa os dados e preenche o DataTable
            Dim data As Object(,) = CType(excelWorksheet.UsedRange.Value, Object(,))
            Dim rows As Integer = data.GetLength(0)
            Dim cols As Integer = data.GetLength(1)

            Dim cabcolunas(3) As Integer
            Dim contcab As Integer = 0

            ' Criação das colunas no DataTable
            For col As Integer = 1 To cols
                If data(3, col) = "Item Code" Or
                   data(3, col) = "Box ID" Or
                   data(3, col) = "Serial No." Then
                    dt1.Columns.Add(data(3, col))
                    cabcolunas(contcab) = col
                    contcab = contcab + 1
                End If
            Next

            ' Preenchendo o DataTable com os valores da planilha
            For row As Integer = 4 To rows
                If data(row, 9) <> "" Then
                    Dim dataRow As DataRow = dt1.NewRow()
                    dataRow(0) = data(row, cabcolunas(0))
                    dataRow(1) = data(row, cabcolunas(1))
                    dataRow(2) = data(row, cabcolunas(2))
                    dt1.Rows.Add(dataRow)
                End If
            Next

            Dim dt2 As New DataTable()
            ' Conectando ao segundo arquivo Excel
            Dim excelWorkbook2 As Excel.Workbook = Nothing
            Dim excelWorksheet2 As Excel.Worksheet = Nothing

            ' Inicia a aplicação do Excel
            excelWorkbook2 = excelApp.Workbooks.Open(CaminhoEan)
            excelWorksheet2 = CType(excelWorkbook2.Sheets(1), Excel.Worksheet)

            ' Processa os dados e preenche o DataTable
            Dim data2 As Object(,) = CType(excelWorksheet2.UsedRange.Value, Object(,))
            Dim rows2 As Integer = data2.GetLength(0)
            Dim cols2 As Integer = data2.GetLength(1)

            ' Criação das colunas no DataTable
            dt2.Columns.Add(data2(3, 1))
            dt2.Columns.Add(data2(3, 3))

            ' Preenchendo o DataTable com os valores da planilha
            For row As Integer = 4 To rows2
                If data2(row, 1) <> "" Then
                    Dim dataRow2 As DataRow = dt2.NewRow()
                    dataRow2(0) = data2(row, 1)
                    dataRow2(1) = data2(row, 3)

                    dt2.Rows.Add(dataRow2)
                End If
            Next

            If excelWorksheet IsNot Nothing Then Marshal.ReleaseComObject(excelWorksheet)
            If excelWorksheet2 IsNot Nothing Then Marshal.ReleaseComObject(excelWorksheet2)
            If excelWorkbook IsNot Nothing Then
                excelWorkbook.Close(False)
                Marshal.ReleaseComObject(excelWorkbook)
                excelWorkbook = Nothing
            End If
            If excelWorkbook2 IsNot Nothing Then
                excelWorkbook2.Close(False)
                Marshal.ReleaseComObject(excelWorkbook2)
                excelWorkbook2 = Nothing
            End If

            If excelApp IsNot Nothing Then
                excelApp.Quit()
                Marshal.ReleaseComObject(excelApp)
            End If

            GC.Collect()
            GC.WaitForPendingFinalizers()


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
                    Dim row2 As DataRow = dt2.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("Item Code") = row1.Field(Of String)("Item Code"))

                    If row2 IsNot Nothing Then
                        ' Monta o comando SQL para inserção no Access
                        Dim insertQuery As String = "INSERT INTO Validacao (CAIXA, SKU, EAN, SERIAL) VALUES (?, ?, ?, ?)"

                        Using insertCmd As New OleDbCommand(insertQuery, accessConn)
                            ' Adiciona os parâmetros da consulta
                            insertCmd.Parameters.AddWithValue("?", row1("Box ID"))
                            insertCmd.Parameters.AddWithValue("?", row1("Item Code"))
                            insertCmd.Parameters.AddWithValue("?", row2("Alt. Code"))
                            insertCmd.Parameters.AddWithValue("?", row1("Serial No."))
                            ' Executa o comando de inserção
                            insertCmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Monta o comando SQL para inserção no Access
                        Dim insertQuery As String = "INSERT INTO Validacao (CAIXA, SKU, EAN, SERIAL) VALUES (?, ?, ?, ?)"

                        Using insertCmd As New OleDbCommand(insertQuery, accessConn)
                            ' Adiciona os parâmetros da consulta
                            insertCmd.Parameters.AddWithValue("?", row1("Box ID"))
                            insertCmd.Parameters.AddWithValue("?", row1("Item Code"))
                            insertCmd.Parameters.AddWithValue("?", "")
                            insertCmd.Parameters.AddWithValue("?", row1("Serial No."))
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
            If form2.InvokeRequired Then
                form2.Invoke(Sub() form2.Close())
            Else
                form2.Close()
            End If

            RJMessageBox.Show("Dados inseridos com sucesso! " & formattedTime,
                                "Sucesso!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        Catch ex As Exception
            If form2.InvokeRequired Then
                form2.Invoke(Sub() form2.Close())
            Else
                form2.Close()
            End If

            RJMessageBox.Show("Erro: " & ex.Message,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
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
            RJMessageBox.Show("Erro: " & ex.Message,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
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

            RJMessageBox.Show("Usuario Cadastrado com Sucesso!",
                                "Sucesso!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

            Inicio.TelaCadastro1.Visible = False
            Inicio.TelaLogin1.Visible = True

        Catch ex As Exception
            RJMessageBox.Show("Erro: " & ex.Message,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
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
                            RJMessageBox.Show("Senha incorreta!",
                                                "Atenção!",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                Next row1
                RJMessageBox.Show("Usuario não encontrado!",
                                    "Erro!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
            End Using
        Catch ex As Exception
            RJMessageBox.Show("Erro: " & ex.Message,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        End Try
    End Sub


    ' receber tabela e usuario e hora
    Function salvarvalidado(validado As DataTable)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "INSERT INTO historicovalidacao (Data_hora_Validacao, Caixa, SKU, Ean, Serial, Usuario, Nome) VALUES (?, ?, ?, ?, ?, ?, ?)"

        Try
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()

                For Each row1 As DataRow In validado.Rows
                    Using insertCmd As New OleDbCommand(query, accessConn)
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
                    End Using
                Next

            End Using


        Catch ex As Exception
            salvarvalidado = ex.Message
        End Try

    End Function

    Function salvarerros(erros As DataTable)
        Dim accessConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AcessBD
        Dim query As String = "INSERT INTO historicoerros (Data_hora_Validacao, Caixa, SKU, Ean, Serial, Erro, Usuario, Nome) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"

        Try
            Using accessConn As New OleDbConnection(accessConnStr)
                accessConn.Open()

                For Each row1 As DataRow In erros.Rows
                    Using insertCmd As New OleDbCommand(query, accessConn)
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
                    End Using
                Next

            End Using

        Catch ex As Exception
            salvarerros = ex.Message
        End Try

    End Function

End Module
