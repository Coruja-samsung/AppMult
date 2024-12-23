<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaCadastro
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Login = New Label()
        Button2 = New Button()
        Salvar = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        nome = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        usuario = New TextBox()
        Panel1 = New Panel()
        Button5 = New Button()
        Senha = New TextBox()
        Panel3 = New Panel()
        Button6 = New Button()
        Senha2 = New TextBox()
        Panel4 = New Panel()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.Location = New Point(50, 41)
        Login.Name = "Login"
        Login.Size = New Size(176, 50)
        Login.TabIndex = 6
        Login.Text = "Cadastro"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.DimGray
        Button2.Location = New Point(245, 388)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 30)
        Button2.TabIndex = 5
        Button2.Text = "Entrar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Salvar
        ' 
        Salvar.BackColor = Color.Transparent
        Salvar.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Salvar.ForeColor = Color.DimGray
        Salvar.Location = New Point(50, 316)
        Salvar.Name = "Salvar"
        Salvar.Size = New Size(324, 48)
        Salvar.TabIndex = 4
        Salvar.Text = "Salvar"
        Salvar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.75F)
        Label1.Location = New Point(97, 393)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 7
        Label1.Text = "Já tem conta?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = My.Resources.Resources.account_custom
        Panel2.Location = New Point(57, 115)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(35, 35)
        Panel2.TabIndex = 11
        ' 
        ' nome
        ' 
        nome.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nome.Location = New Point(95, 115)
        nome.Name = "nome"
        nome.PlaceholderText = "Nome completo"
        nome.Size = New Size(272, 35)
        nome.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Enabled = False
        Button3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.DimGray
        Button3.Location = New Point(50, 108)
        Button3.Name = "Button3"
        Button3.Size = New Size(324, 48)
        Button3.TabIndex = 12
        Button3.Text = "Entrar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Enabled = False
        Button4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.DimGray
        Button4.Location = New Point(50, 159)
        Button4.Name = "Button4"
        Button4.Size = New Size(324, 48)
        Button4.TabIndex = 12
        Button4.Text = "Entrar"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' usuario
        ' 
        usuario.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usuario.Location = New Point(95, 166)
        usuario.Name = "usuario"
        usuario.PlaceholderText = "Usuario"
        usuario.Size = New Size(272, 35)
        usuario.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.account_custom
        Panel1.Location = New Point(57, 166)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(35, 35)
        Panel1.TabIndex = 11
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.Enabled = False
        Button5.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.DimGray
        Button5.Location = New Point(50, 208)
        Button5.Name = "Button5"
        Button5.Size = New Size(324, 48)
        Button5.TabIndex = 12
        Button5.Text = "Entrar"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Senha
        ' 
        Senha.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Senha.Location = New Point(95, 215)
        Senha.Name = "Senha"
        Senha.PasswordChar = "*"c
        Senha.PlaceholderText = "Senha"
        Senha.Size = New Size(272, 35)
        Senha.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BackgroundImage = My.Resources.Resources.lock_custom
        Panel3.Location = New Point(57, 215)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(35, 35)
        Panel3.TabIndex = 11
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.Enabled = False
        Button6.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.DimGray
        Button6.Location = New Point(50, 258)
        Button6.Name = "Button6"
        Button6.Size = New Size(324, 48)
        Button6.TabIndex = 12
        Button6.Text = "Entrar"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Senha2
        ' 
        Senha2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Senha2.Location = New Point(95, 265)
        Senha2.Name = "Senha2"
        Senha2.PasswordChar = "*"c
        Senha2.PlaceholderText = "Senha Novamente"
        Senha2.Size = New Size(272, 35)
        Senha2.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BackgroundImage = My.Resources.Resources.lock_custom
        Panel4.Location = New Point(57, 265)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(35, 35)
        Panel4.TabIndex = 11
        ' 
        ' TelaCadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Senha2)
        Controls.Add(Senha)
        Controls.Add(usuario)
        Controls.Add(nome)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Salvar)
        Controls.Add(Label1)
        Controls.Add(Login)
        Name = "TelaCadastro"
        Size = New Size(434, 461)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Login As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Salvar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nome As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents usuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Senha As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Senha2 As TextBox
    Friend WithEvents Panel4 As Panel

End Class
