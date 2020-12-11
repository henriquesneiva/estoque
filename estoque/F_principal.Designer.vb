<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaPorCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatorioEspecificoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BT_clientes = New System.Windows.Forms.Button()
        Me.BT_produtos = New System.Windows.Forms.Button()
        Me.BT_usuarios = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.RelatoriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(405, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.CadastrosToolStripMenuItem.Text = "cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "clientes"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrosToolStripMenuItem.Text = "produtos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuariosToolStripMenuItem.Text = "usuarios"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaGeralToolStripMenuItem, Me.ConsultaPorCategoriaToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.ConsultasToolStripMenuItem.Text = "consultas"
        '
        'ConsultaGeralToolStripMenuItem
        '
        Me.ConsultaGeralToolStripMenuItem.Name = "ConsultaGeralToolStripMenuItem"
        Me.ConsultaGeralToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConsultaGeralToolStripMenuItem.Text = "consulta geral"
        '
        'ConsultaPorCategoriaToolStripMenuItem
        '
        Me.ConsultaPorCategoriaToolStripMenuItem.Name = "ConsultaPorCategoriaToolStripMenuItem"
        Me.ConsultaPorCategoriaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConsultaPorCategoriaToolStripMenuItem.Text = "consulta por categoria"
        '
        'RelatoriosToolStripMenuItem
        '
        Me.RelatoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatorioEspecificoToolStripMenuItem})
        Me.RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        Me.RelatoriosToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.RelatoriosToolStripMenuItem.Text = "relatorios"
        '
        'RelatorioEspecificoToolStripMenuItem
        '
        Me.RelatorioEspecificoToolStripMenuItem.Name = "RelatorioEspecificoToolStripMenuItem"
        Me.RelatorioEspecificoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RelatorioEspecificoToolStripMenuItem.Text = "relatorio especifico"
        '
        'BT_clientes
        '
        Me.BT_clientes.BackColor = System.Drawing.Color.Transparent
        Me.BT_clientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_clientes.Image = CType(resources.GetObject("BT_clientes.Image"), System.Drawing.Image)
        Me.BT_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_clientes.Location = New System.Drawing.Point(42, 49)
        Me.BT_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_clientes.Name = "BT_clientes"
        Me.BT_clientes.Size = New System.Drawing.Size(56, 58)
        Me.BT_clientes.TabIndex = 11
        Me.BT_clientes.Text = "clientes"
        Me.BT_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_clientes.UseVisualStyleBackColor = False
        '
        'BT_produtos
        '
        Me.BT_produtos.BackColor = System.Drawing.Color.Transparent
        Me.BT_produtos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_produtos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_produtos.Image = CType(resources.GetObject("BT_produtos.Image"), System.Drawing.Image)
        Me.BT_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_produtos.Location = New System.Drawing.Point(118, 49)
        Me.BT_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_produtos.Name = "BT_produtos"
        Me.BT_produtos.Size = New System.Drawing.Size(62, 58)
        Me.BT_produtos.TabIndex = 12
        Me.BT_produtos.Text = "produtos"
        Me.BT_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_produtos.UseVisualStyleBackColor = False
        '
        'BT_usuarios
        '
        Me.BT_usuarios.BackColor = System.Drawing.Color.Transparent
        Me.BT_usuarios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BT_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_usuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_usuarios.Image = CType(resources.GetObject("BT_usuarios.Image"), System.Drawing.Image)
        Me.BT_usuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_usuarios.Location = New System.Drawing.Point(193, 49)
        Me.BT_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_usuarios.Name = "BT_usuarios"
        Me.BT_usuarios.Size = New System.Drawing.Size(62, 58)
        Me.BT_usuarios.TabIndex = 13
        Me.BT_usuarios.Text = " usuario"
        Me.BT_usuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_usuarios.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(268, 49)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 58)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "RELATORIOS"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'F_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(405, 210)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BT_usuarios)
        Me.Controls.Add(Me.BT_produtos)
        Me.Controls.Add(Me.BT_clientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaPorCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatorioEspecificoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_clientes As Button
    Friend WithEvents BT_produtos As Button
    Friend WithEvents BT_usuarios As Button
    Friend WithEvents Button1 As Button
End Class
