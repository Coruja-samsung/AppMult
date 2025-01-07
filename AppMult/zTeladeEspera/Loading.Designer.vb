<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        panelBody = New Panel()
        ProgressBar1 = New ProgressBar()
        panelTitleBar = New Panel()
        labelCaption = New Label()
        panelButtons = New Panel()
        Label1 = New Label()
        panelBody.SuspendLayout()
        panelTitleBar.SuspendLayout()
        panelButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelBody
        ' 
        panelBody.BackColor = Color.WhiteSmoke
        panelBody.Controls.Add(ProgressBar1)
        panelBody.Dock = DockStyle.Fill
        panelBody.Location = New Point(0, 40)
        panelBody.Margin = New Padding(4, 3, 4, 3)
        panelBody.Name = "panelBody"
        panelBody.Padding = New Padding(12, 12, 0, 0)
        panelBody.Size = New Size(441, 107)
        panelBody.TabIndex = 6
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(30, 35)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(380, 37)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 0
        ProgressBar1.Value = 30
        ' 
        ' panelTitleBar
        ' 
        panelTitleBar.BackColor = Color.CornflowerBlue
        panelTitleBar.Controls.Add(labelCaption)
        panelTitleBar.Dock = DockStyle.Top
        panelTitleBar.Location = New Point(0, 0)
        panelTitleBar.Margin = New Padding(4, 3, 4, 3)
        panelTitleBar.Name = "panelTitleBar"
        panelTitleBar.Size = New Size(441, 40)
        panelTitleBar.TabIndex = 4
        ' 
        ' labelCaption
        ' 
        labelCaption.AutoSize = True
        labelCaption.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelCaption.ForeColor = Color.White
        labelCaption.Location = New Point(10, 9)
        labelCaption.Margin = New Padding(4, 0, 4, 0)
        labelCaption.Name = "labelCaption"
        labelCaption.Size = New Size(78, 17)
        labelCaption.TabIndex = 4
        labelCaption.Text = "Aguarde ..."
        ' 
        ' panelButtons
        ' 
        panelButtons.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        panelButtons.Controls.Add(Label1)
        panelButtons.Dock = DockStyle.Bottom
        panelButtons.Location = New Point(0, 147)
        panelButtons.Margin = New Padding(4, 3, 4, 3)
        panelButtons.Name = "panelButtons"
        panelButtons.Size = New Size(441, 51)
        panelButtons.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(329, 16)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 17)
        Label1.TabIndex = 5
        Label1.Text = "Carregando ..."
        ' 
        ' Loading
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 198)
        Controls.Add(panelBody)
        Controls.Add(panelTitleBar)
        Controls.Add(panelButtons)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(406, 167)
        Name = "Loading"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loading"
        panelBody.ResumeLayout(False)
        panelTitleBar.ResumeLayout(False)
        panelTitleBar.PerformLayout()
        panelButtons.ResumeLayout(False)
        panelButtons.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents panelBody As Panel
    Private WithEvents panelTitleBar As Panel
    Private WithEvents labelCaption As Label
    Private WithEvents panelButtons As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Private WithEvents Label1 As Label
End Class
