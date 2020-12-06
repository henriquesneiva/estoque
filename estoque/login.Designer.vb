<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_info = New System.Windows.Forms.Label()
        Me.TB_usuario = New System.Windows.Forms.TextBox()
        Me.TB_senha = New System.Windows.Forms.TextBox()
        Me.BTN_login = New System.Windows.Forms.Button()
        Me.BTN_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(33, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "senha:"
        '
        'LB_info
        '
        Me.LB_info.AutoSize = True
        Me.LB_info.BackColor = System.Drawing.Color.Transparent
        Me.LB_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_info.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LB_info.Location = New System.Drawing.Point(43, 130)
        Me.LB_info.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LB_info.Name = "LB_info"
        Me.LB_info.Size = New System.Drawing.Size(0, 20)
        Me.LB_info.TabIndex = 2
        '
        'TB_usuario
        '
        Me.TB_usuario.Location = New System.Drawing.Point(102, 40)
        Me.TB_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_usuario.Name = "TB_usuario"
        Me.TB_usuario.Size = New System.Drawing.Size(115, 20)
        Me.TB_usuario.TabIndex = 3
        '
        'TB_senha
        '
        Me.TB_senha.Location = New System.Drawing.Point(102, 71)
        Me.TB_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.TB_senha.Name = "TB_senha"
        Me.TB_senha.Size = New System.Drawing.Size(115, 20)
        Me.TB_senha.TabIndex = 4
        '
        'BTN_login
        '
        Me.BTN_login.Enabled = False
        Me.BTN_login.Location = New System.Drawing.Point(102, 101)
        Me.BTN_login.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.Size = New System.Drawing.Size(50, 20)
        Me.BTN_login.TabIndex = 5
        Me.BTN_login.Text = "Logar"
        Me.BTN_login.UseVisualStyleBackColor = True
        '
        'BTN_sair
        '
        Me.BTN_sair.Location = New System.Drawing.Point(165, 101)
        Me.BTN_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_sair.Name = "BTN_sair"
        Me.BTN_sair.Size = New System.Drawing.Size(50, 20)
        Me.BTN_sair.TabIndex = 6
        Me.BTN_sair.Text = "sair"
        Me.BTN_sair.UseVisualStyleBackColor = True
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(265, 159)
        Me.Controls.Add(Me.BTN_sair)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.TB_senha)
        Me.Controls.Add(Me.TB_usuario)
        Me.Controls.Add(Me.LB_info)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "f_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LB_info As Label
    Friend WithEvents TB_usuario As TextBox
    Friend WithEvents TB_senha As TextBox
    Friend WithEvents BTN_login As Button
    Friend WithEvents BTN_sair As Button
End Class
