<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        TelaCadastro1 = New TelaCadastro()
        TelaLogin1 = New TelaLogin()
        SuspendLayout()
        ' 
        ' TelaCadastro1
        ' 
        TelaCadastro1.BackColor = Color.White
        TelaCadastro1.Dock = DockStyle.Fill
        TelaCadastro1.Location = New Point(0, 0)
        TelaCadastro1.Name = "TelaCadastro1"
        TelaCadastro1.Size = New Size(434, 461)
        TelaCadastro1.TabIndex = 0
        TelaCadastro1.Visible = False
        ' 
        ' TelaLogin1
        ' 
        TelaLogin1.BackColor = Color.White
        TelaLogin1.BackgroundImageLayout = ImageLayout.Center
        TelaLogin1.Dock = DockStyle.Fill
        TelaLogin1.Location = New Point(0, 0)
        TelaLogin1.Name = "TelaLogin1"
        TelaLogin1.Size = New Size(434, 461)
        TelaLogin1.TabIndex = 1
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 461)
        Controls.Add(TelaLogin1)
        Controls.Add(TelaCadastro1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
    End Sub

    Friend WithEvents TelaCadastro1 As TelaCadastro
    Friend WithEvents TelaLogin1 As TelaLogin
End Class
