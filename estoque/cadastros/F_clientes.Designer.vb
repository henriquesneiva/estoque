<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_clientes))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_nome = New System.Windows.Forms.TextBox()
        Me.TB_cpf = New System.Windows.Forms.TextBox()
        Me.TB_endereco = New System.Windows.Forms.TextBox()
        Me.TB_telefone = New System.Windows.Forms.TextBox()
        Me.BT_salvar = New System.Windows.Forms.Button()
        Me.BT_excluir = New System.Windows.Forms.Button()
        Me.BT_limpar = New System.Windows.Forms.Button()
        Me.BT_sair = New System.Windows.Forms.Button()
        Me.LB_msg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(8, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "cpf"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(8, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "telefone"
        '
        'TB_nome
        '
        Me.TB_nome.Location = New System.Drawing.Point(85, 20)
        Me.TB_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_nome.Name = "TB_nome"
        Me.TB_nome.Size = New System.Drawing.Size(137, 20)
        Me.TB_nome.TabIndex = 6
        '
        'TB_cpf
        '
        Me.TB_cpf.Location = New System.Drawing.Point(85, 51)
        Me.TB_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_cpf.Name = "TB_cpf"
        Me.TB_cpf.Size = New System.Drawing.Size(137, 20)
        Me.TB_cpf.TabIndex = 7
        '
        'TB_endereco
        '
        Me.TB_endereco.Location = New System.Drawing.Point(85, 114)
        Me.TB_endereco.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_endereco.Multiline = True
        Me.TB_endereco.Name = "TB_endereco"
        Me.TB_endereco.Size = New System.Drawing.Size(191, 59)
        Me.TB_endereco.TabIndex = 8
        '
        'TB_telefone
        '
        Me.TB_telefone.Location = New System.Drawing.Point(85, 85)
        Me.TB_telefone.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_telefone.Name = "TB_telefone"
        Me.TB_telefone.Size = New System.Drawing.Size(137, 20)
        Me.TB_telefone.TabIndex = 9
        '
        'BT_salvar
        '
        Me.BT_salvar.BackColor = System.Drawing.Color.Transparent
        Me.BT_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_salvar.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_salvar.Image = CType(resources.GetObject("BT_salvar.Image"), System.Drawing.Image)
        Me.BT_salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_salvar.Location = New System.Drawing.Point(156, 194)
        Me.BT_salvar.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_salvar.Name = "BT_salvar"
        Me.BT_salvar.Size = New System.Drawing.Size(47, 58)
        Me.BT_salvar.TabIndex = 10
        Me.BT_salvar.Text = "salvar"
        Me.BT_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_salvar.UseVisualStyleBackColor = False
        '
        'BT_excluir
        '
        Me.BT_excluir.BackColor = System.Drawing.Color.Transparent
        Me.BT_excluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_excluir.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_excluir.Image = CType(resources.GetObject("BT_excluir.Image"), System.Drawing.Image)
        Me.BT_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_excluir.Location = New System.Drawing.Point(215, 194)
        Me.BT_excluir.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_excluir.Name = "BT_excluir"
        Me.BT_excluir.Size = New System.Drawing.Size(47, 58)
        Me.BT_excluir.TabIndex = 11
        Me.BT_excluir.Text = "ecluir"
        Me.BT_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_excluir.UseVisualStyleBackColor = False
        '
        'BT_limpar
        '
        Me.BT_limpar.BackColor = System.Drawing.Color.Transparent
        Me.BT_limpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_limpar.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_limpar.Image = CType(resources.GetObject("BT_limpar.Image"), System.Drawing.Image)
        Me.BT_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_limpar.Location = New System.Drawing.Point(273, 194)
        Me.BT_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_limpar.Name = "BT_limpar"
        Me.BT_limpar.Size = New System.Drawing.Size(47, 58)
        Me.BT_limpar.TabIndex = 12
        Me.BT_limpar.Text = "limpar"
        Me.BT_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_limpar.UseVisualStyleBackColor = False
        '
        'BT_sair
        '
        Me.BT_sair.BackColor = System.Drawing.Color.Transparent
        Me.BT_sair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_sair.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_sair.Image = CType(resources.GetObject("BT_sair.Image"), System.Drawing.Image)
        Me.BT_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_sair.Location = New System.Drawing.Point(333, 194)
        Me.BT_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_sair.Name = "BT_sair"
        Me.BT_sair.Size = New System.Drawing.Size(47, 58)
        Me.BT_sair.TabIndex = 13
        Me.BT_sair.Text = "sair"
        Me.BT_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_sair.UseVisualStyleBackColor = False
        '
        'LB_msg
        '
        Me.LB_msg.AutoSize = True
        Me.LB_msg.BackColor = System.Drawing.Color.Transparent
        Me.LB_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_msg.ForeColor = System.Drawing.Color.Red
        Me.LB_msg.Location = New System.Drawing.Point(226, 68)
        Me.LB_msg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_msg.Name = "LB_msg"
        Me.LB_msg.Size = New System.Drawing.Size(0, 15)
        Me.LB_msg.TabIndex = 14
        '
        'F_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(393, 261)
        Me.Controls.Add(Me.LB_msg)
        Me.Controls.Add(Me.BT_sair)
        Me.Controls.Add(Me.BT_limpar)
        Me.Controls.Add(Me.BT_excluir)
        Me.Controls.Add(Me.BT_salvar)
        Me.Controls.Add(Me.TB_telefone)
        Me.Controls.Add(Me.TB_endereco)
        Me.Controls.Add(Me.TB_cpf)
        Me.Controls.Add(Me.TB_nome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastros-clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_nome As TextBox
    Friend WithEvents TB_cpf As TextBox
    Friend WithEvents TB_endereco As TextBox
    Friend WithEvents TB_telefone As TextBox
    Friend WithEvents BT_salvar As Button
    Friend WithEvents BT_excluir As Button
    Friend WithEvents BT_limpar As Button
    Friend WithEvents BT_sair As Button
    Friend WithEvents LB_msg As Label
End Class
