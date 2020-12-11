Imports MySql.Data.MySqlClient
Public Class f_login
    Private Sub f_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New MySqlConnection
        conectar.ConnectionString = cnn

    End Sub

    Private Sub BTN_login_Click(sender As Object, e As EventArgs) Handles BTN_login.Click
        TB_senha_Validated(sender, e)
        F_principal.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_sair_Click(sender As Object, e As EventArgs) Handles BTN_sair.Click
        If MsgBox("deseja sair ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub TB_senha_Validated(sender As Object, e As EventArgs)
        If TB_usuario.Text = "" Or TB_senha.Text = "" Then
            LB_info.Text = "insira o usuario e senha"
            TB_usuario.Focus()
            Exit Sub
        End If
        sql = "select * from login where usuario="
        sql += "'" & TB_usuario.Text & "'and senha="
        sql += "'" & TB_senha.Text & "'"
        conectar.Open()
        adaptar = New MySqlDataAdapter(sql, conectar)
        local = New DataSet
        conectar.Close()
        adaptar.Fill(local, "login")
        resultado = local.Tables("login").Rows.Count
        If resultado > 0 Then
            registro = local.Tables("login").Rows(0)
            vnivel = registro("nivel")
            BTN_login.Enabled = True
            BTN_login.Focus()
        ElseIf resultado = 0 Then
            BTN_login.Enabled = False
            BTN_sair.Focus()
        End If
    End Sub


    Private Sub TB_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_usuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            TB_senha.Focus()
        End If
    End Sub

    Private Sub TB_senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_senha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            TB_senha_Validated(sender, e)
        End If
    End Sub

End Class
