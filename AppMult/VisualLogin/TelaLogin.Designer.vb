<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaLogin
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
        Panel2 = New Panel()
        txtUsuario = New TextBox()
        Login = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        txtSenha = New TextBox()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = My.Resources.Resources.account_custom
        Panel2.Location = New Point(57, 148)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(35, 35)
        Panel2.TabIndex = 1
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(95, 148)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.PlaceholderText = "Usuario"
        txtUsuario.Size = New Size(272, 35)
        txtUsuario.TabIndex = 0
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.Location = New Point(50, 41)
        Login.Name = "Login"
        Login.Size = New Size(120, 50)
        Login.TabIndex = 1
        Login.Text = "Login"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DimGray
        Button1.Location = New Point(50, 314)
        Button1.Name = "Button1"
        Button1.Size = New Size(324, 48)
        Button1.TabIndex = 2
        Button1.Text = "Entrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.DimGray
        Button2.Location = New Point(245, 387)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 30)
        Button2.TabIndex = 3
        Button2.Text = "Cadastre-se"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.75F)
        Label1.Location = New Point(84, 392)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 20)
        Label1.TabIndex = 1
        Label1.Text = "Ainda não tem conta?"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Enabled = False
        Button3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.DimGray
        Button3.Location = New Point(50, 141)
        Button3.Name = "Button3"
        Button3.Size = New Size(324, 48)
        Button3.TabIndex = 2
        Button3.Text = "Entrar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Enabled = False
        Button4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.DimGray
        Button4.Location = New Point(50, 203)
        Button4.Name = "Button4"
        Button4.Size = New Size(324, 48)
        Button4.TabIndex = 2
        Button4.Text = "Entrar"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' txtSenha
        ' 
        txtSenha.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSenha.Location = New Point(95, 210)
        txtSenha.Name = "txtSenha"
        txtSenha.PasswordChar = "*"c
        txtSenha.PlaceholderText = "Senha"
        txtSenha.Size = New Size(272, 35)
        txtSenha.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.lock_custom
        Panel1.Location = New Point(57, 210)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(35, 35)
        Panel1.TabIndex = 1
        ' 
        ' TelaLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Panel1)
        Controls.Add(txtSenha)
        Controls.Add(Panel2)
        Controls.Add(txtUsuario)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Login)
        Name = "TelaLogin"
        Size = New Size(434, 461)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Login As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Panel1 As Panel

End Class
