Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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

        ' Vincular o DataTable ao BindingSource
        bindingSource_main.DataMember = _dataTable.TableName

        AdvancedDataGridView1.Columns(0).FillWeight = 90
        AdvancedDataGridView1.Columns(1).FillWeight = 110
        AdvancedDataGridView1.Columns(2).FillWeight = 90
        AdvancedDataGridView1.Columns(3).FillWeight = 100
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(0), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(1), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(2), False)
        AdvancedDataGridView1.SetChecklistTextFilterRemoveNodesOnSearchMode(AdvancedDataGridView1.Columns(3), False)

        Dim STATOs As New DataGridViewImageColumn()

        STATOs.HeaderText = "STATUs"
        STATOs.Image = My.Resources.Resources.scanner
        STATOs.ImageLayout = DataGridViewImageCellLayout.Zoom
        STATOs.Name = "STATUs"
        STATOs.ReadOnly = True
        STATOs.FillWeight = 50

        AdvancedDataGridView1.Columns.AddRange(STATOs)
        AdvancedDataGridView1.SetFilterAndSortEnabled(AdvancedDataGridView1.Columns(4), False)


        'AdvancedDataGridView1.Columns(4).ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub

    Private Sub AddCab_tabela_erros()
        ' Adicionar colunas à tabela
        tabela_erros.Columns.Add("CAIXA", GetType(String))
        tabela_erros.Columns.Add("SKUs", GetType(String))
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
            Dim result = PegarCaixa(txtCaixa.Text)
            If TypeOf result Is System.Data.DataTable Then
                If result.Rows.Count <> 0 Then
                    txtCaixa.Enabled = False
                    _dataTable.Merge(result)
                Else
                    MessageBox.Show("Caixa Não Encontrada!", "Atenção!")
                    txtCaixa.Text = ""
                End If
            Else
                _dataTable.Clear()
                MessageBox.Show("Atualize o Arquivo de Eans!", "Atenção")
                txtCaixa.Text = ""
                Exit Sub
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
                    Dim SKULinha As Object
                    Dim EanLinha As Object
                    Dim SerialLinha As Object
                    Dim Status As Object
                    For Each row As DataGridViewRow In AdvancedDataGridView1.Rows

                        SKULinha = row.Cells("SKUs").Value
                        EanLinha = row.Cells("EANs").Value
                        SerialLinha = row.Cells("SERIALs").Value
                        Status = row.Cells("STATUs").Value

                        If txtEan.Text = SerialLinha Or txtSerial.Text = EanLinha Then
                            MessageBox.Show("Informações Trocadas!", "Atenção")
                            txtEan.Text = ""
                            txtSerial.Text = ""
                            txtEan.Focus()
                            tabela_erros.Rows.Add(txtCaixa.Text,
                                SKULinha,
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
                                        SKULinha,
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
                                SKULinha,
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lbPendente.Text <> "0" Then
            MessageBox.Show("Itens Pendentes!")
            Exit Sub
        End If

        Dim salvar1 As String
        salvar1 = salvarvalidado(_dataTable)

        Dim salvar2 As String
        salvar2 = salvarerros(tabela_erros)

        If salvar1 <> "" And salvar2 <> "" Then
            MessageBox.Show("Validação Finalizada!")
            limpar()
        Else
            MessageBox.Show("Erro ao salvar!")
        End If

    End Sub

    Sub limpar()
        lbTotal.Text = 0
        lbConferido.Text = 0
        lbPendente.Text = 0
        ProgressBar1.Value = 0
        lbPorcent.Text = "0%"

        txtCaixa.Enabled = True
        txtCaixa.Text = ""
        txtEan.Text = ""
        txtSerial.Text = ""

        _dataTable.Clear()
        txtCaixa.Focus()
    End Sub
End Class