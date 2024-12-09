<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaAtualizaEan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaAtualizaEan))
        Label2 = New Label()
        Panel3 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Gainsboro
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(10, 80)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 10, 0, 0)
        Label2.Size = New Size(838, 392)
        Label2.TabIndex = 5
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(10, 472)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(838, 100)
        Panel3.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.FlatAppearance.MouseOverBackColor = Color.Blue
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Image = My.Resources.Resources.refreshblack
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(654, 23)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 53)
        Button2.TabIndex = 0
        Button2.Text = "Atualizar"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.FlatAppearance.MouseOverBackColor = Color.Blue
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Image = My.Resources.Resources.copy
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(509, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 53)
        Button1.TabIndex = 0
        Button1.Text = "Copiar"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(848, 10)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 562)
        Panel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 562)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gainsboro
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(838, 70)
        Label1.TabIndex = 5
        Label1.Text = "Atualização dos Eans"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(858, 10)
        Panel4.TabIndex = 3
        ' 
        ' TelaAtualizaEan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "TelaAtualizaEan"
        Size = New Size(858, 572)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel

End Class
