Imports System.Data.OleDb
Imports System.Reflection.Emit


Public Class TelaValidacao

    Private _dataTable As DataTable
    Public _dataSet As DataSet
    Private bindingSource_main

    Dim tabela_erros As DataTable
    Public tabela_erros_dataSet As DataSet

    Private Sub TelaValidacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dataTable = New DataTable()
        _dataSet = New DataSet()

        bindingSource_main = New BindingSource()
        bindingSource_main.DataSource = _dataSet

        AdvancedDataGridView1.SetDoubleBuffered()
        AdvancedDataGridView1.DataSource = bindingSource_main

        AddCab__dataTable()

        tabela_erros = New DataTable()
        AddCab_tabela_erros()

    End Sub

    Private Sub AddCab__dataTable()
        ' Adicionar tabela ao DataSet
        _dataTable = _dataSet.Tables.Add("TableTest")

        ' Adicionar colunas à tabela
        _dataTable.Columns.Add("CAIXA", GetType(String))
        _dataTable.Columns.Add("SKUs", GetType(String))
        _dataTable.Columns.Add("EANs", GetType(String))
        _dataTable.Columns.Add("SERIALs", GetType(String))
        _dataTable.Columns.Add("STATUs", GetType(Image))

        ' Vincular o DataTable ao BindingSource
        bindingSource_main.DataMember = _dataTable.TableName

        AdvancedDataGridView1.Columns(0).FillWeight = 90
        AdvancedDataGridView1.Columns(1).FillWeight = 110
        AdvancedDataGridView1.Columns(2).FillWeight = 90
        AdvancedDataGridView1.Columns(3).FillWeight = 100
        AdvancedDataGridView1.Columns(4).FillWeight = 50
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(0), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(1), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(2), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(3), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(4), False)
    End Sub

    Private Sub AddCab_tabela_erros()
        ' Adicionar colunas à tabela
        tabela_erros.Columns.Add("CAIXA", GetType(String))
        tabela_erros.Columns.Add("EANs", GetType(String))
        tabela_erros.Columns.Add("SERIALs", GetType(String))
        tabela_erros.Columns.Add("Erro", GetType(String))
    End Sub


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

        txtCaixa.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)
        txtEan.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)
        txtSerial.Font = New Font(Label1.Font.FontFamily, fatorRedimensionamento)

        AdvancedDataGridView1.Font = New Font(Label1.Font.FontFamily, Label1.Height / 2.3)
    End Sub

    Private Sub Label1_Resize(sender As Object, e As EventArgs) Handles Label1.Resize, lbTotal.Resize, lbConferido.Resize, Label4.Resize, lbPendente.Resize, Label6.Resize, lbPorcent.Resize
        AjustarTamanhoFonte(sender)
    End Sub

    Function PegarCaixa(Caixa As String)
        Dim AcessBD As String = "C:\Users\luiz.os\source\repos\Coruja-samsung\AppMult\AppMult\BaseAppMult\AppMult.accdb"
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
                                row1("SERIAL"),
                                My.Resources.Resources.scanner
                            }
                            _dataTable.Rows.Add(newrow)

                        Else
                            Return "EAN"
                            Exit Function
                        End If
                    End If
                Next

                If _dataTable.Rows.Count <> 0 Then
                    txtCaixa.Enabled = False
                Else
                    Return "NF"
                    Exit Function
                End If

            End Using
            'Dim stopwatch As Stopwatch
            'stopwatch = New Stopwatch()
            'stopwatch.Start()

            'stopwatch.Stop()
            'Dim elapsed As TimeSpan = stopwatch.Elapsed

            '' Formatando o TimeSpan como "hh:mm:ss:fff"
            'Dim formattedTime As String = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}",
            '                                       elapsed.Hours,
            '                                       elapsed.Minutes,
            '                                       elapsed.Seconds,
            '                                       elapsed.Milliseconds)

            'MessageBox.Show("Dados inseridos com sucesso! " & formattedTime)
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message)
        End Try
    End Function
    Public Function CompareImages(ByVal img1 As Bitmap, ByVal img2 As Bitmap) As Boolean
        Dim i As Integer
        Dim j As Integer

        For i = 0 To img1.Width - 1
            For j = 0 To img2.Height - 1
                If img1.GetPixel(i, j) <> img2.GetPixel(i, j) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Private Sub txtCaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaixa.KeyPress
        If e.KeyChar = ChrW(13) Then
            Dim result As String = PegarCaixa(txtCaixa.Text)
            If result = "EAN" Then
                _dataTable.Clear()
                MessageBox.Show("Atualize o Arquivo de Eans!", "Atenção")
                txtCaixa.Text = ""
            ElseIf result = "NF" Then
                MessageBox.Show("Caixa Não Encontrada!", "Atenção!")
                txtCaixa.Text = ""
            End If
            Dim ites As Integer = AdvancedDataGridView1.RowCount
            lbTotal.Text = ites
        End If
    End Sub

    Private Sub txtEan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEan.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtSerial.Focus()
        End If
    End Sub

    Private Sub txtSerial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerial.KeyPress
        If e.KeyChar = ChrW(13) Then
            If txtEan.Text <> "" Then
                If txtSerial.Text <> "" Then
                    Dim EanLinha As Object
                    Dim SerialLinha As Object
                    Dim Status As Object
                    For Each row As DataGridViewRow In AdvancedDataGridView1.Rows

                        EanLinha = row.Cells("EANs").Value
                        SerialLinha = row.Cells("SERIALs").Value
                        Status = row.Cells("STATUs").Value

                        If txtEan.Text = SerialLinha Or txtSerial.Text = EanLinha Then
                            MessageBox.Show("Informações Trocadas!", "Atenção")
                            txtEan.Text = ""
                            txtSerial.Text = ""
                            txtEan.Focus()
                            tabela_erros.Rows.Add(txtCaixa.Text,
                                EanLinha,
                                Status,
                                "informacoes trocadas"
                            )
                            Exit Sub
                        End If

                        If txtEan.Text = EanLinha Then
                            If txtSerial.Text = SerialLinha Then
                                If CompareImages(Status, My.Resources.Resources.verifica) Then
                                    MessageBox.Show("Item já Validado!", "Atenção")
                                    txtEan.Text = ""
                                    txtSerial.Text = ""
                                    txtEan.Focus()
                                    tabela_erros.Rows.Add(txtCaixa.Text,
                                        EanLinha,
                                        Status,
                                        "Item ja Validado"
                                    )
                                    Exit Sub
                                Else

                                    Dim total As Integer = AdvancedDataGridView1.RowCount
                                    Dim conferido As Integer = Int(lbConferido.Text) + 1
                                    Dim pendente As Integer = total - conferido
                                    Dim porcent As Integer = conferido / total * 100

                                    lbConferido.Text = conferido
                                    lbPendente.Text = pendente
                                    lbPorcent.Text = porcent & "%"
                                    ProgressBar1.Value = porcent


                                    txtEan.Text = ""
                                    txtSerial.Text = ""
                                    row.Cells("STATUs").Value = My.Resources.Resources.verifica
                                    txtEan.Focus()
                                    Exit Sub
                                End If
                            End If
                        End If

                        Dim linhas As Integer = AdvancedDataGridView1.Rows.Count - 1
                        If linhas = row.Index Then
                            MessageBox.Show("Item não pertence a caixa!", "Atenção")
                            txtEan.Text = ""
                            txtSerial.Text = ""
                            txtEan.Focus()
                            tabela_erros.Rows.Add(txtCaixa.Text,
                                EanLinha,
                                Status,
                                "Item nao pertence a caixa"
                            )
                            Exit Sub
                        End If

                    Next
                End If
            End If
        End If
    End Sub
End Class