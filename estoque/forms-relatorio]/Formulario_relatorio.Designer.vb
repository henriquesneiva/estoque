<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_relatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario_relatorio))
        Me.R_produtos = New System.Windows.Forms.RadioButton()
        Me.R_usuarios = New System.Windows.Forms.RadioButton()
        Me.R_clientes = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BT_sair = New System.Windows.Forms.Button()
        Me.BT_relatorio = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R_produtos
        '
        Me.R_produtos.AutoSize = True
        Me.R_produtos.Location = New System.Drawing.Point(12, 37)
        Me.R_produtos.Name = "R_produtos"
        Me.R_produtos.Size = New System.Drawing.Size(66, 17)
        Me.R_produtos.TabIndex = 0
        Me.R_produtos.TabStop = True
        Me.R_produtos.Text = "produtos"
        Me.R_produtos.UseVisualStyleBackColor = True
        '
        'R_usuarios
        '
        Me.R_usuarios.AutoSize = True
        Me.R_usuarios.Location = New System.Drawing.Point(12, 69)
        Me.R_usuarios.Name = "R_usuarios"
        Me.R_usuarios.Size = New System.Drawing.Size(64, 17)
        Me.R_usuarios.TabIndex = 1
        Me.R_usuarios.TabStop = True
        Me.R_usuarios.Text = "usuarios"
        Me.R_usuarios.UseVisualStyleBackColor = True
        '
        'R_clientes
        '
        Me.R_clientes.AutoSize = True
        Me.R_clientes.Location = New System.Drawing.Point(12, 101)
        Me.R_clientes.Name = "R_clientes"
        Me.R_clientes.Size = New System.Drawing.Size(61, 17)
        Me.R_clientes.TabIndex = 2
        Me.R_clientes.TabStop = True
        Me.R_clientes.Text = "clientes"
        Me.R_clientes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(139, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 307)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BT_sair
        '
        Me.BT_sair.BackColor = System.Drawing.Color.Transparent
        Me.BT_sair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_sair.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_sair.Image = CType(resources.GetObject("BT_sair.Image"), System.Drawing.Image)
        Me.BT_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_sair.Location = New System.Drawing.Point(107, 250)
        Me.BT_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_sair.Name = "BT_sair"
        Me.BT_sair.Size = New System.Drawing.Size(62, 59)
        Me.BT_sair.TabIndex = 35
        Me.BT_sair.Text = "menu"
        Me.BT_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_sair.UseVisualStyleBackColor = False
        '
        'BT_relatorio
        '
        Me.BT_relatorio.BackColor = System.Drawing.Color.Transparent
        Me.BT_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_relatorio.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_relatorio.Image = CType(resources.GetObject("BT_relatorio.Image"), System.Drawing.Image)
        Me.BT_relatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_relatorio.Location = New System.Drawing.Point(9, 250)
        Me.BT_relatorio.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_relatorio.Name = "BT_relatorio"
        Me.BT_relatorio.Size = New System.Drawing.Size(84, 59)
        Me.BT_relatorio.TabIndex = 34
        Me.BT_relatorio.Text = "gerar relatorio"
        Me.BT_relatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_relatorio.UseVisualStyleBackColor = False
        '
        'Formulario_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(462, 310)
        Me.Controls.Add(Me.BT_sair)
        Me.Controls.Add(Me.BT_relatorio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.R_clientes)
        Me.Controls.Add(Me.R_usuarios)
        Me.Controls.Add(Me.R_produtos)
        Me.Name = "Formulario_relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario_relatorio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents R_produtos As RadioButton
    Friend WithEvents R_usuarios As RadioButton
    Friend WithEvents R_clientes As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BT_sair As Button
    Friend WithEvents BT_relatorio As Button
End Class
