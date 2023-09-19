Module mod_geral
    Public db As ADODB.Connection
    Public rs As ADODB.Recordset
    Public sql As String
    Public dir_banco As String = "banco_dados\Banco_Dados.mdb"

    Sub conectar_banco()
        Try
            db = New ADODB.Connection
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
            MsgBox("Conectado ao banco!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro_atletica()
        With frm_cadastrarAtletica
            .txt_nome_atletica.Clear()
            .txt_email_atletica.Clear()
            .txt_senha_atletica.Clear()
            .txt_confirmarSenha_atletica.Clear()
            .txt_nome_atletica.Focus()
        End With
    End Sub

    Sub limpar_cadastro_aluno()
        With frm_cadastroAluno
            .txt_nome_aluno.Clear()
            .txt_email_aluno.Clear()
            .txt_senha_aluno.Clear()
            .txt_confirmarSenha_aluno.Clear()
            .txt_nome_aluno.Focus()
        End With
    End Sub

    Sub limpar_login()
        With frm_entrar
            .txt_email.Clear()
            .txt_senha.Clear()
        End With
    End Sub

    Public Function GetNomeAtletica(ByVal nomeAtleticaLogada As String) As String
        Dim nomeAtletica As String = ""

        Try
            conectar_banco() ' Abre a conexão com o banco de dados

            ' Consulta SQL para obter o nome da atlética logada com base no nome da atlética
            Dim query As String = "SELECT nome_atletica FROM tb_cadastro_atletica WHERE nome_atletica = ?"
            Dim command As New ADODB.Command()
            command.ActiveConnection = mod_geral.db
            command.CommandText = query

            ' Adiciona o parâmetro ao comando
            Dim nomeParameter As ADODB.Parameter = command.CreateParameter()
            nomeParameter.Name = "nome"
            nomeParameter.Type = ADODB.DataTypeEnum.adVarChar
            nomeParameter.Size = 255
            nomeParameter.Value = nomeAtleticaLogada
            command.Parameters.Append(nomeParameter)

            mod_geral.db.Open() ' Abre a conexão com o banco de dados

            ' Executa a consulta e obtém o nome da atlética
            Dim rs As ADODB.Recordset = command.Execute()
            If Not rs.EOF Then
                nomeAtletica = rs.Fields("nome_atletica").Value.ToString()
            End If

            rs.Close()

            ' Fecha a conexão com o banco de dados
            mod_geral.db.Close()

            ' Exibe o valor retornado em um MessageBox
            MessageBox.Show("Nome da atlética: " & nomeAtletica)
        Catch ex As Exception
            MessageBox.Show("Erro ao obter o nome da atlética: " & ex.Message)
        End Try

        Return nomeAtletica
    End Function
    Public Sub CarregarItensComboBox(cmb As ComboBox, nomeTabela As String, nomeColuna As String)
        Try
            ' Consulta SQL para obter os itens da coluna no banco de dados
            Dim query As String = "SELECT " & nomeColuna & " FROM " & nomeTabela

            ' Crie um objeto de comando
            Dim command As New ADODB.Command()
            command.ActiveConnection = mod_geral.db
            command.CommandText = query

            ' Execute a consulta e obtenha os dados
            Dim recordSet As ADODB.Recordset = command.Execute()

            ' Verifique se há registros retornados
            If Not recordSet.EOF Then
                ' Crie uma lista para armazenar os dados
                Dim dataList As New List(Of String)()

                ' Percorra os registros e armazene os valores na lista
                While Not recordSet.EOF
                    dataList.Add(recordSet.Fields(nomeColuna).Value.ToString())
                    recordSet.MoveNext()
                End While

                ' Defina a origem de dados do ComboBox
                cmb.DataSource = dataList
            End If

            ' Feche o objeto de registro
            recordSet.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar itens do ComboBox: " & ex.Message)
        End Try
    End Sub
End Module
