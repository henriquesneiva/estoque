Public Class F_relprodutos
    Private Sub F_relprodutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'cadastroDataSet4.produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.produtosTableAdapter.Fill(Me.cadastroDataSet4.produtos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class