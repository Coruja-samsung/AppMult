Imports System.Data.OleDb
Imports System.Reflection.Emit


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

        AdvancedDataGridView1.Font = New Font(Label1.Font.FontFamily, Label1.Height / 2.3)
    End Sub

    Private Sub Label1_Resize(sender As Object, e As EventArgs) Handles Label1.Resize, Label2.Resize, Label3.Resize, Label4.Resize, Label5.Resize, Label6.Resize, Label7.Resize
        AjustarTamanhoFonte(sender)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = ChrW(13) Then

            _dataTable.Clear()
            PegarCaixa(TextBox1.Text)

        End If

    End Sub


    Private _dataTable As DataTable
    Public _dataSet As DataSet
    Private bindingSource_main

    Private Sub TelaValidacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dataTable = New DataTable()
        _dataSet = New DataSet()

        bindingSource_main = New BindingSource()
        bindingSource_main.DataSource = _dataSet

        AdvancedDataGridView1.SetDoubleBuffered()
        AdvancedDataGridView1.DataSource = bindingSource_main

        AddCab()
    End Sub

    Private Sub AddCab()
        ' Adicionar tabela ao DataSet
        _dataTable = _dataSet.Tables.Add("TableTest")

        ' Adicionar colunas à tabela
        _dataTable.Columns.Add("CAIXA", GetType(String))
        _dataTable.Columns.Add("SKUs", GetType(String))
        _dataTable.Columns.Add("EANs", GetType(String))
        _dataTable.Columns.Add("SERIALs", GetType(String))
        _dataTable.Columns.Add("STATUs", GetType(String))

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

    Sub PegarCaixa(Caixa As String)
        'Dim stopwatch As Stopwatch
        'stopwatch = New Stopwatch()
        'stopwatch.Start()

        Dim AcessBD As String = "C:\Users\Luiz Henrique\source\repos\AppMult\AppMult\BaseAppMult\AppMult.accdb"
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
                                row1("SERIAL")
                            }
                            _dataTable.Rows.Add(newrow)

                        Else
                            _dataTable.Clear()
                            MessageBox.Show("Atualize o Arquivo de Eans!", "Atenção", MessageBoxButtons.OKCancel)
                            Exit Sub
                        End If
                    End If
                Next

                If _dataTable.Rows.Count <> 0 Then
                    TextBox1.Enabled = False
                Else
                    MessageBox.Show("Caixa Não Encontrada!", "Atenção!")
                    Exit Sub
                End If

            End Using

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
    End Sub

End Class