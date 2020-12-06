Imports MySql.Data.MySqlClient
Public Class F_usuarios
    Private Sub F_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New MySqlConnection
        conectar.ConnectionString = cnn
    End Sub

    Private Sub BT_sair_Click(sender As Object, e As EventArgs) Handles BT_sair.Click
        F_principal.Show()
        Me.Hide()
        limpar()
    End Sub

    Private Sub BT_limpar_Click(sender As Object, e As EventArgs) Handles BT_limpar.Click
        limpar()
    End Sub

    Private Sub limpar()
        TB_nome.Text = ""
        TB_confirmar.Text = ""
        TB_nivel.Text = ""
        TB_senha.Text = ""
        TB_usuario.Text = ""
    End Sub

    Private Sub BT_salvar_Click(sender As Object, e As EventArgs) Handles BT_salvar.Click
        If resultado > 0 Then
            sql = "uptade login set senha='" & TB_senha.Text & "',"
            sql += "nome='" & TB_nome.Text & "',"
            sql += "nivel='" & TB_nivel.Text & "'"
            sql += "where usuario='" & TB_usuario.Text & "'"

        ElseIf resultado = 0 Then
            sql = " insert into login (usuario,senha,nivel,nome)"
            sql += "values ('" & TB_usuario.Text & "',"
            sql += "'" & TB_senha.Text & "',"
            sql += "'" & TB_nivel.Text & "',"
            sql += "'" & TB_nome.Text & "')"
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
        TB_usuario.Text = ""
    End Sub

    Private Sub TB_usuario_Validated(sender As Object, e As EventArgs) Handles TB_usuario.Validated
        If TB_usuario.Text = "" Then
            MsgBox("preencha o campo usuario por favor")
            TB_nome.Focus()

        End If
        sql = "select * from login where usuario="
        sql += "'" & TB_usuario.Text & "'"
        conectar.Open()
        adaptar = New MySqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "usuario")
        resultado = local.Tables("usuario").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("usuario").Rows(0)
            TB_senha.Text = registro("senha")
            TB_nivel.Text = registro("nivel")
            TB_nome.Text = registro("nome")
            BT_salvar.Text = "editar"

        ElseIf resultado = 0 Then
            BT_salvar.Text = "inserir"

        End If
    End Sub

    Private Sub BT_excluir_Click(sender As Object, e As EventArgs) Handles BT_excluir.Click
        conectar.Close()
        sql = "delete from login where usuario='" & TB_usuario.Text & "'"
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
        TB_usuario.Text = ""
    End Sub

    Private Sub TB_confirmar_Validated(sender As Object, e As EventArgs) Handles TB_confirmar.Validated
        If TB_senha.Text <> TB_confirmar.Text Then
            MsgBox("as senhas estao diferentes")
            TB_senha.Text = ""
            TB_confirmar.Text = ""
            Exit Sub
        End If
    End Sub
End Class