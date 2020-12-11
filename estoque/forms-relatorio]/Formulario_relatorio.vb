Public Class Formulario_relatorio
    Private Sub Formulario_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_relatorio_Click(sender As Object, e As EventArgs) Handles BT_relatorio.Click
        If R_clientes.Checked = True Then
            F_relclientes.Show()
        ElseIf R_produtos.Checked = True Then
            F_relprodutos.Show()
        ElseIf R_usuarios.Checked = True Then
            F_relusuarios.Show()

        End If

    End Sub

    Private Sub BT_sair_Click(sender As Object, e As EventArgs) Handles BT_sair.Click
        F_principal.Show()
        Me.Hide()
    End Sub
End Class