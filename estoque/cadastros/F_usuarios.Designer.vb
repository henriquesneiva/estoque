<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_usuarios))
        Me.TB_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_confirmar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_nome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_nivel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BT_sair = New System.Windows.Forms.Button()
        Me.BT_limpar = New System.Windows.Forms.Button()
        Me.BT_excluir = New System.Windows.Forms.Button()
        Me.BT_salvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_usuario
        '
        Me.TB_usuario.Location = New System.Drawing.Point(95, 22)
        Me.TB_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_usuario.Multiline = True
        Me.TB_usuario.Name = "TB_usuario"
        Me.TB_usuario.Size = New System.Drawing.Size(108, 17)
        Me.TB_usuario.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(11, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "usuario"
        '
        'TB_senha
        '
        Me.TB_senha.Location = New System.Drawing.Point(95, 59)
        Me.TB_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_senha.Multiline = True
        Me.TB_senha.Name = "TB_senha"
        Me.TB_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_senha.Size = New System.Drawing.Size(108, 17)
        Me.TB_senha.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "senha"
        '
        'TB_confirmar
        '
        Me.TB_confirmar.Location = New System.Drawing.Point(95, 100)
        Me.TB_confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_confirmar.Multiline = True
        Me.TB_confirmar.Name = "TB_confirmar"
        Me.TB_confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_confirmar.Size = New System.Drawing.Size(108, 17)
        Me.TB_confirmar.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(11, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "confirmar"
        '
        'TB_nome
        '
        Me.TB_nome.Location = New System.Drawing.Point(280, 23)
        Me.TB_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_nome.Multiline = True
        Me.TB_nome.Name = "TB_nome"
        Me.TB_nome.Size = New System.Drawing.Size(108, 17)
        Me.TB_nome.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(221, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "nome"
        '
        'TB_nivel
        '
        Me.TB_nivel.Location = New System.Drawing.Point(280, 61)
        Me.TB_nivel.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_nivel.Multiline = True
        Me.TB_nivel.Name = "TB_nivel"
        Me.TB_nivel.Size = New System.Drawing.Size(108, 17)
        Me.TB_nivel.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(221, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "nivel"
        '
        'BT_sair
        '
        Me.BT_sair.BackColor = System.Drawing.Color.Transparent
        Me.BT_sair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_sair.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_sair.Image = CType(resources.GetObject("BT_sair.Image"), System.Drawing.Image)
        Me.BT_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_sair.Location = New System.Drawing.Point(280, 165)
        Me.BT_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_sair.Name = "BT_sair"
        Me.BT_sair.Size = New System.Drawing.Size(47, 58)
        Me.BT_sair.TabIndex = 34
        Me.BT_sair.Text = "sair"
        Me.BT_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_sair.UseVisualStyleBackColor = False
        '
        'BT_limpar
        '
        Me.BT_limpar.BackColor = System.Drawing.Color.Transparent
        Me.BT_limpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_limpar.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_limpar.Image = CType(resources.GetObject("BT_limpar.Image"), System.Drawing.Image)
        Me.BT_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_limpar.Location = New System.Drawing.Point(216, 165)
        Me.BT_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_limpar.Name = "BT_limpar"
        Me.BT_limpar.Size = New System.Drawing.Size(47, 58)
        Me.BT_limpar.TabIndex = 33
        Me.BT_limpar.Text = "limpar"
        Me.BT_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_limpar.UseVisualStyleBackColor = False
        '
        'BT_excluir
        '
        Me.BT_excluir.BackColor = System.Drawing.Color.Transparent
        Me.BT_excluir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_excluir.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_excluir.Image = CType(resources.GetObject("BT_excluir.Image"), System.Drawing.Image)
        Me.BT_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_excluir.Location = New System.Drawing.Point(156, 165)
        Me.BT_excluir.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_excluir.Name = "BT_excluir"
        Me.BT_excluir.Size = New System.Drawing.Size(47, 58)
        Me.BT_excluir.TabIndex = 32
        Me.BT_excluir.Text = "ecluir"
        Me.BT_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_excluir.UseVisualStyleBackColor = False
        '
        'BT_salvar
        '
        Me.BT_salvar.BackColor = System.Drawing.Color.Transparent
        Me.BT_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_salvar.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_salvar.Image = CType(resources.GetObject("BT_salvar.Image"), System.Drawing.Image)
        Me.BT_salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_salvar.Location = New System.Drawing.Point(94, 165)
        Me.BT_salvar.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_salvar.Name = "BT_salvar"
        Me.BT_salvar.Size = New System.Drawing.Size(47, 58)
        Me.BT_salvar.TabIndex = 31
        Me.BT_salvar.Text = "salvar"
        Me.BT_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_salvar.UseVisualStyleBackColor = False
        '
        'F_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(402, 234)
        Me.Controls.Add(Me.BT_sair)
        Me.Controls.Add(Me.BT_limpar)
        Me.Controls.Add(Me.BT_excluir)
        Me.Controls.Add(Me.BT_salvar)
        Me.Controls.Add(Me.TB_nivel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_confirmar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_senha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Name = "F_usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro de ususarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_confirmar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_nome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_nivel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BT_sair As Button
    Friend WithEvents BT_limpar As Button
    Friend WithEvents BT_excluir As Button
    Friend WithEvents BT_salvar As Button
End Class
