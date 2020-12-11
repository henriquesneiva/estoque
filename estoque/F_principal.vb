Public Class F_principal
    Private Sub F_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        F_clientes.Show()
        Me.Hide()

    End Sub

    Private Sub BT_clientes_Click(sender As Object, e As EventArgs) Handles BT_clientes.Click
        F_clientes.Show()

    End Sub

    Private Sub BT_produtos_Click(sender As Object, e As EventArgs) Handles BT_produtos.Click
        F_produtos.Show()

    End Sub

    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click
        F_produtos.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        F_usuarios.Show()

    End Sub

    Private Sub BT_usuarios_Click(sender As Object, e As EventArgs) Handles BT_usuarios.Click
        F_usuarios.Show
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formulario_relatorio.Show()

    End Sub
End Class