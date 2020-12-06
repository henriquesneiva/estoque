Imports MySql.Data.MySqlClient
Module conexao
    Public conectar As MySqlConnection
    Public comando As MySqlCommand
    Public local As DataSet
    Public adaptar As MySqlDataAdapter
    Public sql As String
    Public resultado As Integer
    Public registro As DataRow
    Public dt As DataSet
    Public cnn As String = "server=localhost;database=cadastro;user=root;password=97873638hsn"
    Public vnivel As String
    Public contador As Integer

End Module