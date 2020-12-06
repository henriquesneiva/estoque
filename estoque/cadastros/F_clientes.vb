Imports MySql.Data.MySqlClient
Public Class F_clientes
    Private Sub F_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar = New MySqlConnection
        conectar.ConnectionString = cnn
    End Sub

    Private Sub limpar()
        TB_nome.Text = ""
        TB_telefone.Text = ""
        TB_cpf.Text = ""
        TB_endereco.Text = ""
    End Sub

    Private Sub TB_codigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            TB_nome.Focus()
        End If
    End Sub

    Private Sub TB_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_nome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            TB_cpf.Focus()
        End If
    End Sub

    Private Sub TB_cpf_KeyUp(sender As Object, e As KeyEventArgs) Handles TB_cpf.KeyUp
        sql = "select * from clientes where cpf="
        sql += "'" & TB_cpf.Text & "'"
        conectar.Open()
        adaptar = New MySqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "clientes")
        resultado = local.Tables("clientes").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("clientes").Rows(0)
            TB_nome.Text = registro("nome")
            TB_telefone.Text = registro("telefone")
            TB_endereco.Text = registro("indereço")
            BT_salvar.Text = "editar"
            TB_nome.Focus()
        ElseIf resultado = 0 Then
            BT_salvar.Text = "inserir"

        End If
    End Sub


    Private Sub TB_cpf_Validated(sender As Object, e As EventArgs) Handles TB_cpf.Validated
        If TB_cpf.Text = "" Then
            LB_msg.Text = "por favor digite o cpf"
        End If
        sql = "select * from clientes where cpf="
        sql += "'" & TB_cpf.Text & "'"
        conectar.Open()
        adaptar = New MySqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "clientes")
        resultado = local.Tables("clientes").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("clientes").Rows(0)
            TB_nome.Text = registro("nome")
            TB_telefone.Text = registro("telefone")
            TB_endereco.Text = registro("indereço")
            BT_salvar.Text = "editar"
            TB_nome.Focus()
        ElseIf resultado = 0 Then
            BT_salvar.Text = "inserir"

        End If
    End Sub

    ' Private Sub TB_codigo_Validated(sender As Object, e As EventArgs)
    '  contador = contador + 1
    '  End Sub

    Private Sub BT_excluir_Click(sender As Object, e As EventArgs) Handles BT_excluir.Click
        conectar.Close()
        sql = "delete from clientes where cpf='" & TB_cpf.Text & "'"
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
                TB_cpf.Text = ""
        TB_cpf.Focus()
    End Sub

    Private Sub BT_salvar_Click(sender As Object, e As EventArgs) Handles BT_salvar.Click
        If resultado > 0 Then
            sql = "uptade clientes set nome='" & TB_nome.Text & "',"
            sql += "indereço='" & TB_endereco.Text & "',"
            sql += "telefone='" & TB_telefone.Text & "'"
            sql += "where cpf='" & TB_cpf.Text & "'"

        ElseIf resultado = 0 Then
            sql = " insert into clientes (cpf,nome,telefone,indereço)"
            sql += "values ('" & TB_cpf.Text & "',"
            sql += "'" & TB_nome.Text & "',"
            sql += "'" & TB_telefone.Text & "',"
            sql += "'" & TB_endereco.Text & "')"
            MsgBox("inseridos com sucesso")
        End If

        Try
            conectar.Open()
            comando = New MySqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        conectar.Close()
        limpar()
        TB_cpf.Text = ""
        TB_cpf.Focus()
    End Sub

    Private Sub BT_limpar_Click(sender As Object, e As EventArgs) Handles BT_limpar.Click
        limpar()
    End Sub

    Private Sub TB_cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_cpf.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            TB_telefone.Focus()
        End If
    End Sub

    Private Sub TB_telefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_telefone.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            TB_endereco.Focus()
        End If
    End Sub

    Private Sub BT_sair_Click(sender As Object, e As EventArgs) Handles BT_sair.Click
        F_principal.Show()
        Me.Hide()
        limpar()

    End Sub

End Class