Public Class F_relclientes
    Private Sub ElementHost1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs) 

    End Sub

    Private Sub F_relclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'cadastroDataSet3.clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.clientesTableAdapter.Fill(Me.cadastroDataSet3.clientes)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class