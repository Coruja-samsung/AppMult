<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        PanelMenu = New Panel()
        PanelSelecao = New Panel()
        SubMenuAtualizar = New Panel()
        ButtonEans = New Button()
        ButtonSearch = New Button()
        PanelSair = New Panel()
        ButtonSair = New Button()
        ButtonAtualizar = New Button()
        ButtonValidacao = New Button()
        PanelLogo = New Panel()
        ButtonRecize = New Button()
        fundoazul = New Panel()
        PanelUser = New Panel()
        lbUsuario = New Label()
        PanelCaminho = New Panel()
        lbCaminho = New Label()
        PanelDeskTop = New Panel()
        TelaValidacao1 = New TelaValidacao()
        TelaAtualizarSearch1 = New TelaAtualizarSerial()
        TelaAtualizaEan1 = New TelaAtualizaEan()
        PanelMenu.SuspendLayout()
        SubMenuAtualizar.SuspendLayout()
        PanelSair.SuspendLayout()
        PanelLogo.SuspendLayout()
        PanelCaminho.SuspendLayout()
        PanelDeskTop.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        PanelMenu.Controls.Add(PanelSelecao)
        PanelMenu.Controls.Add(SubMenuAtualizar)
        PanelMenu.Controls.Add(PanelSair)
        PanelMenu.Controls.Add(ButtonAtualizar)
        PanelMenu.Controls.Add(ButtonValidacao)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(256, 621)
        PanelMenu.TabIndex = 2
        ' 
        ' PanelSelecao
        ' 
        PanelSelecao.BackColor = Color.Cyan
        PanelSelecao.ForeColor = Color.Transparent
        PanelSelecao.Location = New Point(0, 164)
        PanelSelecao.Name = "PanelSelecao"
        PanelSelecao.Size = New Size(10, 55)
        PanelSelecao.TabIndex = 8
        ' 
        ' SubMenuAtualizar
        ' 
        SubMenuAtualizar.Controls.Add(ButtonEans)
        SubMenuAtualizar.Controls.Add(ButtonSearch)
        SubMenuAtualizar.Dock = DockStyle.Top
        SubMenuAtualizar.Location = New Point(0, 274)
        SubMenuAtualizar.MinimumSize = New Size(256, 110)
        SubMenuAtualizar.Name = "SubMenuAtualizar"
        SubMenuAtualizar.Size = New Size(256, 110)
        SubMenuAtualizar.TabIndex = 9
        SubMenuAtualizar.Visible = False
        ' 
        ' ButtonEans
        ' 
        ButtonEans.AccessibleRole = AccessibleRole.None
        ButtonEans.BackColor = Color.FromArgb(CByte(13), CByte(10), CByte(157))
        ButtonEans.Cursor = Cursors.Hand
        ButtonEans.Dock = DockStyle.Top
        ButtonEans.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonEans.FlatAppearance.BorderSize = 0
        ButtonEans.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonEans.FlatAppearance.MouseOverBackColor = Color.Blue
        ButtonEans.FlatStyle = FlatStyle.Flat
        ButtonEans.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonEans.ForeColor = Color.White
        ButtonEans.Image = My.Resources.Resources.refresh
        ButtonEans.ImageAlign = ContentAlignment.MiddleLeft
        ButtonEans.Location = New Point(0, 55)
        ButtonEans.Margin = New Padding(0)
        ButtonEans.MinimumSize = New Size(256, 55)
        ButtonEans.Name = "ButtonEans"
        ButtonEans.Padding = New Padding(9, 0, 0, 0)
        ButtonEans.Size = New Size(256, 55)
        ButtonEans.TabIndex = 8
        ButtonEans.Text = "Eans"
        ButtonEans.UseVisualStyleBackColor = False
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.AccessibleRole = AccessibleRole.None
        ButtonSearch.BackColor = Color.FromArgb(CByte(13), CByte(10), CByte(157))
        ButtonSearch.Cursor = Cursors.Hand
        ButtonSearch.Dock = DockStyle.Top
        ButtonSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonSearch.FlatAppearance.BorderSize = 0
        ButtonSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonSearch.FlatAppearance.MouseOverBackColor = Color.Blue
        ButtonSearch.FlatStyle = FlatStyle.Flat
        ButtonSearch.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSearch.ForeColor = Color.White
        ButtonSearch.Image = My.Resources.Resources.lupa
        ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft
        ButtonSearch.Location = New Point(0, 0)
        ButtonSearch.Margin = New Padding(0)
        ButtonSearch.MinimumSize = New Size(256, 55)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Padding = New Padding(9, 0, 0, 0)
        ButtonSearch.Size = New Size(256, 55)
        ButtonSearch.TabIndex = 7
        ButtonSearch.Text = "Search"
        ButtonSearch.UseVisualStyleBackColor = False
        ' 
        ' PanelSair
        ' 
        PanelSair.Controls.Add(ButtonSair)
        PanelSair.Dock = DockStyle.Bottom
        PanelSair.Location = New Point(0, 528)
        PanelSair.Name = "PanelSair"
        PanelSair.Size = New Size(256, 93)
        PanelSair.TabIndex = 7
        ' 
        ' ButtonSair
        ' 
        ButtonSair.AccessibleRole = AccessibleRole.None
        ButtonSair.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonSair.Cursor = Cursors.Hand
        ButtonSair.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonSair.FlatAppearance.BorderSize = 0
        ButtonSair.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonSair.FlatAppearance.MouseOverBackColor = Color.Crimson
        ButtonSair.FlatStyle = FlatStyle.Flat
        ButtonSair.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSair.ForeColor = Color.White
        ButtonSair.Image = My.Resources.Resources.log_out
        ButtonSair.ImageAlign = ContentAlignment.MiddleLeft
        ButtonSair.Location = New Point(0, 10)
        ButtonSair.Margin = New Padding(0)
        ButtonSair.Name = "ButtonSair"
        ButtonSair.Padding = New Padding(9, 0, 0, 0)
        ButtonSair.Size = New Size(256, 74)
        ButtonSair.TabIndex = 7
        ButtonSair.Text = "Sair      "
        ButtonSair.UseVisualStyleBackColor = False
        ' 
        ' ButtonAtualizar
        ' 
        ButtonAtualizar.AccessibleRole = AccessibleRole.None
        ButtonAtualizar.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonAtualizar.Cursor = Cursors.Hand
        ButtonAtualizar.Dock = DockStyle.Top
        ButtonAtualizar.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonAtualizar.FlatAppearance.BorderSize = 0
        ButtonAtualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonAtualizar.FlatAppearance.MouseOverBackColor = Color.Blue
        ButtonAtualizar.FlatStyle = FlatStyle.Flat
        ButtonAtualizar.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAtualizar.ForeColor = Color.White
        ButtonAtualizar.Image = My.Resources.Resources.refresh
        ButtonAtualizar.ImageAlign = ContentAlignment.MiddleLeft
        ButtonAtualizar.Location = New Point(0, 219)
        ButtonAtualizar.Margin = New Padding(0)
        ButtonAtualizar.MinimumSize = New Size(256, 55)
        ButtonAtualizar.Name = "ButtonAtualizar"
        ButtonAtualizar.Padding = New Padding(9, 0, 0, 0)
        ButtonAtualizar.Size = New Size(256, 55)
        ButtonAtualizar.TabIndex = 6
        ButtonAtualizar.Text = "Atualizar        ⏷"
        ButtonAtualizar.TextAlign = ContentAlignment.MiddleRight
        ButtonAtualizar.UseVisualStyleBackColor = False
        ' 
        ' ButtonValidacao
        ' 
        ButtonValidacao.AccessibleRole = AccessibleRole.None
        ButtonValidacao.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonValidacao.Cursor = Cursors.Hand
        ButtonValidacao.Dock = DockStyle.Top
        ButtonValidacao.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonValidacao.FlatAppearance.BorderSize = 0
        ButtonValidacao.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonValidacao.FlatAppearance.MouseOverBackColor = Color.Blue
        ButtonValidacao.FlatStyle = FlatStyle.Flat
        ButtonValidacao.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonValidacao.ForeColor = Color.White
        ButtonValidacao.Image = My.Resources.Resources.file_text
        ButtonValidacao.ImageAlign = ContentAlignment.MiddleLeft
        ButtonValidacao.Location = New Point(0, 164)
        ButtonValidacao.Margin = New Padding(0)
        ButtonValidacao.MinimumSize = New Size(256, 55)
        ButtonValidacao.Name = "ButtonValidacao"
        ButtonValidacao.Padding = New Padding(9, 0, 0, 0)
        ButtonValidacao.Size = New Size(256, 55)
        ButtonValidacao.TabIndex = 5
        ButtonValidacao.Text = "Validação"
        ButtonValidacao.UseVisualStyleBackColor = False
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(ButtonRecize)
        PanelLogo.Controls.Add(fundoazul)
        PanelLogo.Controls.Add(PanelUser)
        PanelLogo.Controls.Add(lbUsuario)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(256, 164)
        PanelLogo.TabIndex = 4
        ' 
        ' ButtonRecize
        ' 
        ButtonRecize.AccessibleRole = AccessibleRole.None
        ButtonRecize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonRecize.BackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonRecize.Cursor = Cursors.Hand
        ButtonRecize.FlatAppearance.BorderColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonRecize.FlatAppearance.BorderSize = 0
        ButtonRecize.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        ButtonRecize.FlatAppearance.MouseOverBackColor = Color.Blue
        ButtonRecize.FlatStyle = FlatStyle.Flat
        ButtonRecize.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonRecize.ForeColor = Color.White
        ButtonRecize.Image = My.Resources.Resources.menu
        ButtonRecize.ImageAlign = ContentAlignment.MiddleLeft
        ButtonRecize.Location = New Point(190, 9)
        ButtonRecize.Margin = New Padding(0)
        ButtonRecize.Name = "ButtonRecize"
        ButtonRecize.Size = New Size(55, 55)
        ButtonRecize.TabIndex = 6
        ButtonRecize.TabStop = False
        ButtonRecize.UseVisualStyleBackColor = False
        ' 
        ' fundoazul
        ' 
        fundoazul.BackColor = Color.Transparent
        fundoazul.BackgroundImageLayout = ImageLayout.Stretch
        fundoazul.ForeColor = Color.Transparent
        fundoazul.Location = New Point(250, 0)
        fundoazul.Name = "fundoazul"
        fundoazul.Size = New Size(256, 158)
        fundoazul.TabIndex = 1
        ' 
        ' PanelUser
        ' 
        PanelUser.BackColor = Color.Transparent
        PanelUser.BackgroundImage = My.Resources.Resources.user
        PanelUser.BackgroundImageLayout = ImageLayout.Stretch
        PanelUser.ForeColor = Color.Transparent
        PanelUser.Location = New Point(86, 34)
        PanelUser.Name = "PanelUser"
        PanelUser.Size = New Size(80, 80)
        PanelUser.TabIndex = 2
        ' 
        ' lbUsuario
        ' 
        lbUsuario.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbUsuario.ForeColor = Color.White
        lbUsuario.Location = New Point(3, 117)
        lbUsuario.Name = "lbUsuario"
        lbUsuario.Size = New Size(250, 25)
        lbUsuario.TabIndex = 2
        lbUsuario.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelCaminho
        ' 
        PanelCaminho.BackColor = Color.WhiteSmoke
        PanelCaminho.Controls.Add(lbCaminho)
        PanelCaminho.Dock = DockStyle.Top
        PanelCaminho.Location = New Point(256, 0)
        PanelCaminho.Name = "PanelCaminho"
        PanelCaminho.Size = New Size(858, 49)
        PanelCaminho.TabIndex = 1
        ' 
        ' lbCaminho
        ' 
        lbCaminho.AutoSize = True
        lbCaminho.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbCaminho.ForeColor = Color.Black
        lbCaminho.Location = New Point(10, 12)
        lbCaminho.Name = "lbCaminho"
        lbCaminho.Size = New Size(169, 25)
        lbCaminho.TabIndex = 0
        lbCaminho.Text = "Home / Validação"
        ' 
        ' PanelDeskTop
        ' 
        PanelDeskTop.Controls.Add(TelaValidacao1)
        PanelDeskTop.Controls.Add(TelaAtualizarSearch1)
        PanelDeskTop.Controls.Add(TelaAtualizaEan1)
        PanelDeskTop.Dock = DockStyle.Fill
        PanelDeskTop.Location = New Point(256, 49)
        PanelDeskTop.Name = "PanelDeskTop"
        PanelDeskTop.Size = New Size(858, 572)
        PanelDeskTop.TabIndex = 0
        ' 
        ' TelaValidacao1
        ' 
        TelaValidacao1.Dock = DockStyle.Fill
        TelaValidacao1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TelaValidacao1.Location = New Point(0, 0)
        TelaValidacao1.Margin = New Padding(4, 3, 4, 3)
        TelaValidacao1.Name = "TelaValidacao1"
        TelaValidacao1.Size = New Size(858, 572)
        TelaValidacao1.TabIndex = 0
        ' 
        ' TelaAtualizarSearch1
        ' 
        TelaAtualizarSearch1.Dock = DockStyle.Fill
        TelaAtualizarSearch1.ForeColor = Color.Black
        TelaAtualizarSearch1.Location = New Point(0, 0)
        TelaAtualizarSearch1.Name = "TelaAtualizarSearch1"
        TelaAtualizarSearch1.Size = New Size(858, 572)
        TelaAtualizarSearch1.TabIndex = 1
        TelaAtualizarSearch1.Visible = False
        ' 
        ' TelaAtualizaEan1
        ' 
        TelaAtualizaEan1.Dock = DockStyle.Fill
        TelaAtualizaEan1.ForeColor = Color.Black
        TelaAtualizaEan1.Location = New Point(0, 0)
        TelaAtualizaEan1.Name = "TelaAtualizaEan1"
        TelaAtualizaEan1.Size = New Size(858, 572)
        TelaAtualizaEan1.TabIndex = 0
        TelaAtualizaEan1.Visible = False
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1114, 621)
        Controls.Add(PanelDeskTop)
        Controls.Add(PanelCaminho)
        Controls.Add(PanelMenu)
        ForeColor = Color.FromArgb(CByte(13), CByte(38), CByte(167))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1130, 660)
        Name = "Principal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Validação de Mult"
        PanelMenu.ResumeLayout(False)
        SubMenuAtualizar.ResumeLayout(False)
        PanelSair.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        PanelCaminho.ResumeLayout(False)
        PanelCaminho.PerformLayout()
        PanelDeskTop.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelCaminho As Panel
    Friend WithEvents lbCaminho As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ButtonValidacao As Button
    Friend WithEvents ButtonAtualizar As Button
    Friend WithEvents PanelSair As Panel
    Friend WithEvents PanelSelecao As Panel
    Friend WithEvents PanelUser As Panel
    Friend WithEvents lbUsuario As Label
    Friend WithEvents ButtonSair As Button
    Friend WithEvents PanelDeskTop As Panel
    Friend WithEvents SubMenuAtualizar As Panel
    Friend WithEvents ButtonEans As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TelaAtualizarSearch1 As TelaAtualizarSerial
    Friend WithEvents TelaAtualizaEan1 As TelaAtualizaEan
    Friend WithEvents ButtonRecize As Button
    Protected Friend WithEvents TelaValidacao1 As TelaValidacao
    Friend WithEvents fundoazul As Panel

End Class
