﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaValidacao
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel5 = New Panel()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel11 = New Panel()
        AdvancedDataGridView1 = New Zuby.ADGV.AdvancedDataGridView()
        TableLayoutPanel10 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Panel6 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        lbTotal = New Label()
        Label1 = New Label()
        Panel7 = New Panel()
        TableLayoutPanel5 = New TableLayoutPanel()
        lbConferido = New Label()
        Label4 = New Label()
        Panel8 = New Panel()
        TableLayoutPanel6 = New TableLayoutPanel()
        lbPendente = New Label()
        Label6 = New Label()
        Panel9 = New Panel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        Panel14 = New Panel()
        txtCaixa = New TextBox()
        TableLayoutPanel9 = New TableLayoutPanel()
        Panel15 = New Panel()
        txtEan = New TextBox()
        Panel16 = New Panel()
        txtSerial = New TextBox()
        TableLayoutPanel11 = New TableLayoutPanel()
        lbPorcent = New Label()
        Panel10 = New Panel()
        ProgressBar1 = New ProgressBar()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel11.SuspendLayout()
        CType(AdvancedDataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        Panel6.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel7.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        Panel8.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        Panel9.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        Panel14.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 572)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(848, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 572)
        Panel5.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(10, 516)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(838, 56)
        Panel2.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(540, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 45)
        Button2.TabIndex = 4
        Button2.Text = "Limpar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(691, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 45)
        Button1.TabIndex = 3
        Button1.Text = "Finalizar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(10, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(838, 11)
        Panel3.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(10, 11)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(838, 505)
        Panel4.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel11, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel10, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 55F))
        TableLayoutPanel1.Size = New Size(838, 505)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = SystemColors.ActiveBorder
        Panel11.Controls.Add(AdvancedDataGridView1)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(3, 230)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(832, 272)
        Panel11.TabIndex = 2
        ' 
        ' AdvancedDataGridView1
        ' 
        AdvancedDataGridView1.AllowUserToAddRows = False
        AdvancedDataGridView1.AllowUserToDeleteRows = False
        AdvancedDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AdvancedDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        AdvancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdvancedDataGridView1.Dock = DockStyle.Fill
        AdvancedDataGridView1.FilterAndSortEnabled = True
        AdvancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = True
        AdvancedDataGridView1.Location = New Point(0, 0)
        AdvancedDataGridView1.MaxFilterButtonImageHeight = 23
        AdvancedDataGridView1.Name = "AdvancedDataGridView1"
        AdvancedDataGridView1.ReadOnly = True
        AdvancedDataGridView1.RightToLeft = RightToLeft.No
        AdvancedDataGridView1.RowHeadersVisible = False
        AdvancedDataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        AdvancedDataGridView1.Size = New Size(832, 272)
        AdvancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = True
        AdvancedDataGridView1.TabIndex = 1
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 1
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel10.Dock = DockStyle.Fill
        TableLayoutPanel10.Location = New Point(0, 0)
        TableLayoutPanel10.Margin = New Padding(0)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 1
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.Size = New Size(838, 227)
        TableLayoutPanel10.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel9, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.Size = New Size(832, 221)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(Panel6, 0, 0)
        TableLayoutPanel3.Controls.Add(Panel7, 1, 0)
        TableLayoutPanel3.Controls.Add(Panel8, 2, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(832, 88)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        Panel6.Controls.Add(TableLayoutPanel4)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(10, 3)
        Panel6.Margin = New Padding(10, 3, 10, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(257, 75)
        Panel6.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(lbTotal, 0, 1)
        TableLayoutPanel4.Controls.Add(Label1, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(257, 75)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' lbTotal
        ' 
        lbTotal.AutoSize = True
        lbTotal.BackColor = Color.White
        lbTotal.Dock = DockStyle.Fill
        lbTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTotal.Location = New Point(30, 37)
        lbTotal.Margin = New Padding(30, 0, 30, 10)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(197, 28)
        lbTotal.TabIndex = 1
        lbTotal.Text = "0"
        lbTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 0)
        Label1.Margin = New Padding(3, 0, 3, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 32)
        Label1.TabIndex = 0
        Label1.Text = "Total"
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        Panel7.Controls.Add(TableLayoutPanel5)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(287, 3)
        Panel7.Margin = New Padding(10, 3, 10, 10)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(257, 75)
        Panel7.TabIndex = 1
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(lbConferido, 0, 1)
        TableLayoutPanel5.Controls.Add(Label4, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(257, 75)
        TableLayoutPanel5.TabIndex = 1
        ' 
        ' lbConferido
        ' 
        lbConferido.AutoSize = True
        lbConferido.BackColor = Color.White
        lbConferido.Dock = DockStyle.Fill
        lbConferido.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbConferido.ForeColor = Color.ForestGreen
        lbConferido.Location = New Point(30, 37)
        lbConferido.Margin = New Padding(30, 0, 30, 10)
        lbConferido.Name = "lbConferido"
        lbConferido.Size = New Size(197, 28)
        lbConferido.TabIndex = 1
        lbConferido.Text = "0"
        lbConferido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(3, 0)
        Label4.Margin = New Padding(3, 0, 3, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(251, 32)
        Label4.TabIndex = 0
        Label4.Text = "Conferido"
        Label4.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        Panel8.Controls.Add(TableLayoutPanel6)
        Panel8.Dock = DockStyle.Fill
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(564, 3)
        Panel8.Margin = New Padding(10, 3, 10, 10)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(258, 75)
        Panel8.TabIndex = 2
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Controls.Add(lbPendente, 0, 1)
        TableLayoutPanel6.Controls.Add(Label6, 0, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(0, 0)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(258, 75)
        TableLayoutPanel6.TabIndex = 1
        ' 
        ' lbPendente
        ' 
        lbPendente.AutoSize = True
        lbPendente.BackColor = Color.White
        lbPendente.Dock = DockStyle.Fill
        lbPendente.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbPendente.ForeColor = Color.IndianRed
        lbPendente.Location = New Point(30, 37)
        lbPendente.Margin = New Padding(30, 0, 30, 10)
        lbPendente.Name = "lbPendente"
        lbPendente.Size = New Size(198, 28)
        lbPendente.TabIndex = 1
        lbPendente.Text = "0"
        lbPendente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 0)
        Label6.Margin = New Padding(3, 0, 3, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(252, 32)
        Label6.TabIndex = 0
        Label6.Text = "Pendente"
        Label6.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Gainsboro
        Panel9.Controls.Add(TableLayoutPanel7)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(3, 91)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(826, 127)
        Panel9.TabIndex = 1
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(TableLayoutPanel8, 0, 1)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel11, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(0, 0)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 30.1470585F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 69.85294F))
        TableLayoutPanel7.Size = New Size(826, 127)
        TableLayoutPanel7.TabIndex = 0
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel8.Controls.Add(Panel14, 0, 0)
        TableLayoutPanel8.Controls.Add(TableLayoutPanel9, 1, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(3, 41)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.Size = New Size(820, 83)
        TableLayoutPanel8.TabIndex = 1
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(txtCaixa)
        Panel14.Dock = DockStyle.Fill
        Panel14.Location = New Point(0, 0)
        Panel14.Margin = New Padding(0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(328, 83)
        Panel14.TabIndex = 0
        ' 
        ' txtCaixa
        ' 
        txtCaixa.AcceptsReturn = True
        txtCaixa.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCaixa.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCaixa.Location = New Point(43, 27)
        txtCaixa.Name = "txtCaixa"
        txtCaixa.PlaceholderText = "Bipe o Cod Caixa"
        txtCaixa.Size = New Size(242, 33)
        txtCaixa.TabIndex = 0
        txtCaixa.TextAlign = HorizontalAlignment.Center
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 1
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Controls.Add(Panel15, 0, 0)
        TableLayoutPanel9.Controls.Add(Panel16, 0, 1)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(331, 3)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 2
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(486, 77)
        TableLayoutPanel9.TabIndex = 1
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(txtEan)
        Panel15.Dock = DockStyle.Fill
        Panel15.Location = New Point(0, 0)
        Panel15.Margin = New Padding(0)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(486, 38)
        Panel15.TabIndex = 0
        ' 
        ' txtEan
        ' 
        txtEan.AcceptsReturn = True
        txtEan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEan.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEan.Location = New Point(3, 3)
        txtEan.Name = "txtEan"
        txtEan.PlaceholderText = "Bipe o Ean do Produto"
        txtEan.Size = New Size(480, 33)
        txtEan.TabIndex = 1
        txtEan.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(txtSerial)
        Panel16.Dock = DockStyle.Fill
        Panel16.Location = New Point(0, 38)
        Panel16.Margin = New Padding(0)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(486, 39)
        Panel16.TabIndex = 1
        ' 
        ' txtSerial
        ' 
        txtSerial.AcceptsReturn = True
        txtSerial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtSerial.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSerial.Location = New Point(3, 3)
        txtSerial.Name = "txtSerial"
        txtSerial.PlaceholderText = "Bipe o Serial do Produto"
        txtSerial.Size = New Size(480, 33)
        txtSerial.TabIndex = 2
        txtSerial.TextAlign = HorizontalAlignment.Center
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 2
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 88.2074356F))
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.7925644F))
        TableLayoutPanel11.Controls.Add(lbPorcent, 1, 0)
        TableLayoutPanel11.Controls.Add(Panel10, 0, 0)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(3, 3)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 1
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel11.Size = New Size(820, 32)
        TableLayoutPanel11.TabIndex = 2
        ' 
        ' lbPorcent
        ' 
        lbPorcent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbPorcent.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbPorcent.ForeColor = Color.Green
        lbPorcent.Location = New Point(723, 0)
        lbPorcent.Margin = New Padding(0)
        lbPorcent.Name = "lbPorcent"
        lbPorcent.Size = New Size(97, 32)
        lbPorcent.TabIndex = 0
        lbPorcent.Text = "0%"
        lbPorcent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(ProgressBar1)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(0, 0)
        Panel10.Margin = New Padding(0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(723, 32)
        Panel10.TabIndex = 1
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ProgressBar1.Location = New Point(5, 5)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(713, 22)
        ProgressBar1.Step = 1
        ProgressBar1.TabIndex = 0
        ' 
        ' TelaValidacao
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Name = "TelaValidacao"
        Size = New Size(858, 572)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        CType(AdvancedDataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        Panel7.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        Panel8.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        Panel9.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        TableLayoutPanel11.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbPorcent As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lbConferido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lbPendente As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents txtEan As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Panel10 As Panel
    Public WithEvents txtCaixa As TextBox
    Public WithEvents AdvancedDataGridView1 As Zuby.ADGV.AdvancedDataGridView

End Class
