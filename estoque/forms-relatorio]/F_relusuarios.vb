Public Class F_relusuarios
    Private Sub F_relusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'cadastroDataSet5.login'. Você pode movê-la ou removê-la conforme necessário.
        Me.loginTableAdapter.Fill(Me.cadastroDataSet5.login)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class