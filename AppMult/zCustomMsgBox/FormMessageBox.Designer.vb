<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMessageBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelTitleBar = New Panel()
        labelCaption = New Label()
        btnClose = New Button()
        panelButtons = New Panel()
        button3 = New Button()
        button2 = New Button()
        button1 = New Button()
        panelBody = New Panel()
        labelMessage = New Label()
        pictureBoxIcon = New PictureBox()
        panelTitleBar.SuspendLayout()
        panelButtons.SuspendLayout()
        panelBody.SuspendLayout()
        CType(pictureBoxIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelTitleBar
        ' 
        panelTitleBar.BackColor = Color.CornflowerBlue
        panelTitleBar.Controls.Add(labelCaption)
        panelTitleBar.Controls.Add(btnClose)
        panelTitleBar.Dock = DockStyle.Top
        panelTitleBar.Location = New Point(0, 0)
        panelTitleBar.Margin = New Padding(4, 3, 4, 3)
        panelTitleBar.Name = "panelTitleBar"
        panelTitleBar.Size = New Size(408, 40)
        panelTitleBar.TabIndex = 1
        ' 
        ' labelCaption
        ' 
        labelCaption.AutoSize = True
        labelCaption.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelCaption.ForeColor = Color.White
        labelCaption.Location = New Point(10, 9)
        labelCaption.Margin = New Padding(4, 0, 4, 0)
        labelCaption.Name = "labelCaption"
        labelCaption.Size = New Size(86, 17)
        labelCaption.TabIndex = 4
        labelCaption.Text = "labelCaption"
        ' 
        ' btnClose
        ' 
        btnClose.Dock = DockStyle.Right
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(79), CByte(95))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(361, 0)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(47, 40)
        btnClose.TabIndex = 3
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' panelButtons
        ' 
        panelButtons.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
        panelButtons.Controls.Add(button3)
        panelButtons.Controls.Add(button2)
        panelButtons.Controls.Add(button1)
        panelButtons.Dock = DockStyle.Bottom
        panelButtons.Location = New Point(0, 104)
        panelButtons.Margin = New Padding(4, 3, 4, 3)
        panelButtons.Name = "panelButtons"
        panelButtons.Size = New Size(408, 69)
        panelButtons.TabIndex = 2
        ' 
        ' button3
        ' 
        button3.BackColor = Color.SeaGreen
        button3.FlatAppearance.BorderSize = 0
        button3.FlatStyle = FlatStyle.Flat
        button3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button3.ForeColor = Color.WhiteSmoke
        button3.Location = New Point(270, 14)
        button3.Margin = New Padding(4, 3, 4, 3)
        button3.Name = "button3"
        button3.Size = New Size(117, 40)
        button3.TabIndex = 2
        button3.Text = "button3"
        button3.UseVisualStyleBackColor = False
        ' 
        ' button2
        ' 
        button2.BackColor = Color.SeaGreen
        button2.FlatAppearance.BorderSize = 0
        button2.FlatStyle = FlatStyle.Flat
        button2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button2.ForeColor = Color.WhiteSmoke
        button2.Location = New Point(146, 14)
        button2.Margin = New Padding(4, 3, 4, 3)
        button2.Name = "button2"
        button2.Size = New Size(117, 40)
        button2.TabIndex = 1
        button2.Text = "button2"
        button2.UseVisualStyleBackColor = False
        ' 
        ' button1
        ' 
        button1.BackColor = Color.SeaGreen
        button1.FlatAppearance.BorderSize = 0
        button1.FlatStyle = FlatStyle.Flat
        button1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button1.ForeColor = Color.WhiteSmoke
        button1.Location = New Point(22, 14)
        button1.Margin = New Padding(4, 3, 4, 3)
        button1.Name = "button1"
        button1.Size = New Size(117, 40)
        button1.TabIndex = 0
        button1.Text = "button1"
        button1.UseVisualStyleBackColor = False
        ' 
        ' panelBody
        ' 
        panelBody.BackColor = Color.WhiteSmoke
        panelBody.Controls.Add(labelMessage)
        panelBody.Controls.Add(pictureBoxIcon)
        panelBody.Dock = DockStyle.Fill
        panelBody.Location = New Point(0, 40)
        panelBody.Margin = New Padding(4, 3, 4, 3)
        panelBody.Name = "panelBody"
        panelBody.Padding = New Padding(12, 12, 0, 0)
        panelBody.Size = New Size(408, 64)
        panelBody.TabIndex = 3
        ' 
        ' labelMessage
        ' 
        labelMessage.AutoSize = True
        labelMessage.Dock = DockStyle.Fill
        labelMessage.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelMessage.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        labelMessage.Location = New Point(59, 12)
        labelMessage.Margin = New Padding(4, 0, 4, 0)
        labelMessage.MaximumSize = New Size(700, 0)
        labelMessage.Name = "labelMessage"
        labelMessage.Padding = New Padding(6, 6, 12, 17)
        labelMessage.Size = New Size(113, 40)
        labelMessage.TabIndex = 1
        labelMessage.Text = "labelMessage"
        labelMessage.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pictureBoxIcon
        ' 
        pictureBoxIcon.Dock = DockStyle.Left
        pictureBoxIcon.Image = My.Resources.Resources.chat
        pictureBoxIcon.Location = New Point(12, 12)
        pictureBoxIcon.Margin = New Padding(4, 3, 4, 3)
        pictureBoxIcon.Name = "pictureBoxIcon"
        pictureBoxIcon.Size = New Size(47, 52)
        pictureBoxIcon.TabIndex = 0
        pictureBoxIcon.TabStop = False
        ' 
        ' FormMessageBox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 173)
        Controls.Add(panelBody)
        Controls.Add(panelButtons)
        Controls.Add(panelTitleBar)
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(406, 167)
        Name = "FormMessageBox"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormMessageBox"
        panelTitleBar.ResumeLayout(False)
        panelTitleBar.PerformLayout()
        panelButtons.ResumeLayout(False)
        panelBody.ResumeLayout(False)
        panelBody.PerformLayout()
        CType(pictureBoxIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Private WithEvents panelTitleBar As Panel
    Private WithEvents labelCaption As Label
    Private WithEvents btnClose As Button
    Private WithEvents panelButtons As Panel
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents panelBody As Panel
    Private WithEvents labelMessage As Label
    Private WithEvents pictureBoxIcon As PictureBox
End Class
