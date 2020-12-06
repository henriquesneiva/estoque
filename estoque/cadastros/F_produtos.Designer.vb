<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_produtos))
        Me.BT_sair = New System.Windows.Forms.Button()
        Me.BT_limpar = New System.Windows.Forms.Button()
        Me.BT_excluir = New System.Windows.Forms.Button()
        Me.BT_salvar = New System.Windows.Forms.Button()
        Me.TB_cproduto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_descricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_compra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_fornecedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_venda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_sair
        '
        Me.BT_sair.BackColor = System.Drawing.Color.Transparent
        Me.BT_sair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_sair.ForeColor = System.Drawing.SystemColors.Control
        Me.BT_sair.Image = CType(resources.GetObject("BT_sair.Image"), System.Drawing.Image)
        Me.BT_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_sair.Location = New System.Drawing.Point(382, 256)
        Me.BT_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_sair.Name = "BT_sair"
        Me.BT_sair.Size = New System.Drawing.Size(47, 58)
        Me.BT_sair.TabIndex = 19
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
        Me.BT_limpar.Location = New System.Drawing.Point(318, 256)
        Me.BT_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_limpar.Name = "BT_limpar"
        Me.BT_limpar.Size = New System.Drawing.Size(47, 58)
        Me.BT_limpar.TabIndex = 18
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
        Me.BT_excluir.Location = New System.Drawing.Point(258, 256)
        Me.BT_excluir.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_excluir.Name = "BT_excluir"
        Me.BT_excluir.Size = New System.Drawing.Size(47, 58)
        Me.BT_excluir.TabIndex = 17
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
        Me.BT_salvar.Location = New System.Drawing.Point(196, 256)
        Me.BT_salvar.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_salvar.Name = "BT_salvar"
        Me.BT_salvar.Size = New System.Drawing.Size(47, 58)
        Me.BT_salvar.TabIndex = 16
        Me.BT_salvar.Text = "salvar"
        Me.BT_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_salvar.UseVisualStyleBackColor = False
        '
        'TB_cproduto
        '
        Me.TB_cproduto.Location = New System.Drawing.Point(117, 16)
        Me.TB_cproduto.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_cproduto.Multiline = True
        Me.TB_cproduto.Name = "TB_cproduto"
        Me.TB_cproduto.Size = New System.Drawing.Size(62, 19)
        Me.TB_cproduto.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(183, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "quantidade em estoque"
        '
        'TB_descricao
        '
        Me.TB_descricao.Location = New System.Drawing.Point(118, 50)
        Me.TB_descricao.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_descricao.Multiline = True
        Me.TB_descricao.Name = "TB_descricao"
        Me.TB_descricao.Size = New System.Drawing.Size(311, 80)
        Me.TB_descricao.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(11, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "descriçáo"
        '
        'TB_compra
        '
        Me.TB_compra.Location = New System.Drawing.Point(145, 149)
        Me.TB_compra.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_compra.Name = "TB_compra"
        Me.TB_compra.Size = New System.Drawing.Size(62, 20)
        Me.TB_compra.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(11, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "valor de compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(11, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "categoria"
        '
        'TB_fornecedor
        '
        Me.TB_fornecedor.Location = New System.Drawing.Point(145, 221)
        Me.TB_fornecedor.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_fornecedor.Name = "TB_fornecedor"
        Me.TB_fornecedor.Size = New System.Drawing.Size(263, 20)
        Me.TB_fornecedor.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(11, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "fornecedor"
        '
        'TB_venda
        '
        Me.TB_venda.Location = New System.Drawing.Point(346, 147)
        Me.TB_venda.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_venda.Name = "TB_venda"
        Me.TB_venda.Size = New System.Drawing.Size(62, 20)
        Me.TB_venda.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(225, 148)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "valor da venda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(255, 183)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = " data venc"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(370, 15)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDown1.TabIndex = 34
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"medicamentos", "materiais", "equipamentos"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 183)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox1.TabIndex = 35
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(349, 183)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(59, 20)
        Me.DateTimePicker1.TabIndex = 36
        '
        'F_produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(458, 325)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_venda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_fornecedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_compra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_descricao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_sair)
        Me.Controls.Add(Me.BT_limpar)
        Me.Controls.Add(Me.BT_excluir)
        Me.Controls.Add(Me.BT_salvar)
        Me.Controls.Add(Me.TB_cproduto)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "F_produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastros de produtos"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_sair As Button
    Friend WithEvents BT_limpar As Button
    Friend WithEvents BT_excluir As Button
    Friend WithEvents BT_salvar As Button
    Friend WithEvents TB_cproduto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_descricao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_compra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_fornecedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_venda As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
