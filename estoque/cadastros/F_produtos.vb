Imports MySql.Data.MySqlClient
Public Class F_produtos

    Private Sub BT_salvar_Click(sender As Object, e As EventArgs) Handles BT_salvar.Click

        If resultado > 0 Then
            sql = "uptade produtos set descricao='" & TB_descricao.Text & "',"
            sql += "estoque='" & NumericUpDown1.Text & "',"
            sql += "compra='" & TB_compra.Text & "',"
            sql += "venda='" & TB_venda.Text & "',"
            sql += "categoria='" & ComboBox1.SelectedValue & "',"
            sql += "vencimento='" & DateTimePicker1.Text & "',"
            sql += "fornecedor='" & TB_fornecedor.Text & "'"
            sql += "where codigo='" & TB_cproduto.Text & "'"

        ElseIf resultado = 0 Then
            sql = " insert into produtos (codigo,descricao,estoque,compra,venda,categoria,vencimento,fornecedor)"
            sql += "values ('" & TB_cproduto.Text & "',"
            sql += "'" & TB_descricao.Text & "',"
            sql += "'" & NumericUpDown1.Text & "',"
            sql += "'" & TB_compra.Text & "',"
            sql += "'" & TB_venda.Text & "',"
            sql += "'" & ComboBox1.SelectedValue & "',"
            sql += "'" & DateTimePicker1.Text & "',"
            sql += "'" & TB_fornecedor.Text & "')"
            MsgBox("inseridos com sucesso")
        End If

        conectar.Open()
        comando = New MySqlCommand(sql)
        comando.Connection = conectar
        comando.ExecuteNonQuery()
        conectar.Close()
        limpar()
        TB_cproduto.Text = ""
        TB_cproduto.Focus()
    End Sub

    Private Sub F_produtos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar = New MySqlConnection
        conectar.ConnectionString = cnn

    End Sub

    Private Sub limpar()

        TB_cproduto.Text = ""
        TB_compra.Text = ""
        TB_descricao.Text = ""
        TB_fornecedor.Text = ""
        TB_venda.Text = ""
        DateTimePicker1.Text = ""
        NumericUpDown1.Text = ""
        ComboBox1.SelectedValue = Nothing
    End Sub

    Private Sub BT_limpar_Click(sender As Object, e As EventArgs) Handles BT_limpar.Click
        limpar()

    End Sub

    Private Sub TB_cproduto_Validated(sender As Object, e As EventArgs) Handles TB_cproduto.Validated
        If TB_cproduto.Text = "" Then
            MsgBox("por favor digite o codigo")
        End If
        sql = "select * from produtos where codigo="
        sql += "'" & TB_cproduto.Text & "'"
        conectar.Open()
        adaptar = New MySqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "produtos")
        resultado = local.Tables("produtos").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("produtos").Rows(0)

            TB_compra.Text = registro("compra")
            TB_descricao.Text = registro("descricao")
            TB_fornecedor.Text = registro("fornecedor")
            TB_venda.Text = registro("venda")
            DateTimePicker1.Text = registro("vencimento")
            ComboBox1.SelectedValue = registro("categoria")
            NumericUpDown1.Text = ("estoque")
            BT_salvar.Text = "editar"
        ElseIf resultado = 0 Then
            BT_salvar.Text = "inserir"

        End If
    End Sub

    Private Sub BT_excluir_Click(sender As Object, e As EventArgs) Handles BT_excluir.Click
        conectar.Close()
        sql = "delete from produtos where codigo='" & TB_cproduto.Text & "'"
        If MsgBox("deletar", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If resultado > 0 Then
                conectar.Open()
                comando = New MySqlCommand(sql)
                comando.Connection = conectar
                comando.ExecuteNonQuery()
                conectar.Close()
                MsgBox("dados apagados")

            Else
                MsgBox("nao exite dados a serem eliminados")
            End If
        End If
        limpar()
        TB_cproduto.Text = ""
    End Sub

    Private Sub BT_sair_Click(sender As Object, e As EventArgs) Handles BT_sair.Click
        F_principal.Show()
        Me.Hide()
        limpar()
    End Sub
End Class