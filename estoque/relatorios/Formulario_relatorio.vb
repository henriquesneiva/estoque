Public Class Formulario_relatorio
    Private Sub Formulario_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_relatorio_Click(sender As Object, e As EventArgs) Handles BT_relatorio.Click
        If R_clientes.Checked = True Then
            F_relclientes.Show()
        ElseIf R_produtos.Checked = True Then
            ' F_relprodutos.show()
        ElseIf R_usuarios.Checked = True Then
            ' F_relusuarios
        End If

    End Sub


End Class