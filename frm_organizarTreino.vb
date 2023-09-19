Public Class frm_organizarTreino
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private nomeTreinoOriginal As String ' Variável para armazenar o nome original do treino
    Private dadosAlterados As Boolean = False ' Variável para verificar se os dados foram alterados

    Private Sub txt_nomeTreino_TextChanged(sender As Object, e As EventArgs) Handles txt_nomeTreino.TextChanged
        ' Verificar se o campo "txt_nomeTreino" não está vazio
        If Not String.IsNullOrEmpty(txt_nomeTreino.Text) Then
            Dim nomeTreino As String = txt_nomeTreino.Text

            Try
                ' Buscar dados correspondentes no banco de dados
                Dim query As String = "SELECT * FROM tb_treinos_atletica WHERE nome_treino = ?"
                Dim command As New ADODB.Command()
                command.ActiveConnection = mod_geral.db
                command.CommandText = query

                ' Define o parâmetro usando o método CreateParameter
                command.Parameters.Append(command.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeTreino))

                Dim rs As ADODB.Recordset = command.Execute()

                If Not rs.EOF Then
                    ' Preencher os campos com os dados correspondentes
                    dtp_dataTreino.Value = CType(rs.Fields("data_treino").Value, DateTime)
                    txt_localTreino.Text = rs.Fields("local_treino").Value.ToString()
                    txt_descricaoTreino.Text = rs.Fields("descricao_treino").Value.ToString()

                    ' Armazenar o nome original do treino
                    nomeTreinoOriginal = nomeTreino
                End If

                rs.Close()
            Catch ex As Exception
                MessageBox.Show("Erro ao buscar dados do treino: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_criarTreino_Click(sender As Object, e As EventArgs) Handles btn_criarTreino.Click
        Dim nomeTreino As String = txt_nomeTreino.Text
        Dim dataTreino As DateTime = dtp_dataTreino.Value.Date
        Dim localTreino As String = txt_localTreino.Text
        Dim descricaoTreino As String = txt_descricaoTreino.Text

        Try
            ' Verificar se o treino já existe no banco de dados
            Dim selectQuery As String = "SELECT COUNT(*) FROM tb_treinos_atletica WHERE nome_treino = ?"
            Dim selectCommand As New ADODB.Command()
            selectCommand.ActiveConnection = mod_geral.db
            selectCommand.CommandText = selectQuery
            selectCommand.Parameters.Append(selectCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeTreino))
            Dim count As Integer = CInt(selectCommand.Execute().Fields(0).Value)

            If count = 0 Then
                ' O treino não existe, efetuar o cadastro
                Dim insertQuery As String = "INSERT INTO tb_treinos_atletica (nome_treino, data_treino, local_treino, descricao_treino) VALUES (?, ?, ?, ?)"
                Dim insertCommand As New ADODB.Command()
                insertCommand.ActiveConnection = mod_geral.db
                insertCommand.CommandText = insertQuery
                insertCommand.Parameters.Append(insertCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeTreino))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("data", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , dataTreino))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("local", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, localTreino))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("descricao", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 1000, descricaoTreino))
                insertCommand.Execute()

                MessageBox.Show("Treino cadastrado com sucesso!")
            Else
                ' O treino já existe, efetuar a atualização
                Dim updateQuery As String = "UPDATE tb_treinos_atletica SET data_treino = ?, local_treino = ?, descricao_treino = ? WHERE nome_treino = ?"
                Dim updateCommand As New ADODB.Command()
                updateCommand.ActiveConnection = mod_geral.db
                updateCommand.CommandText = updateQuery
                updateCommand.Parameters.Append(updateCommand.CreateParameter("data", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , dataTreino))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("local", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, localTreino))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("descricao", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 1000, descricaoTreino))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeTreino))
                updateCommand.Execute()

                MessageBox.Show("Treino atualizado com sucesso!")
            End If

            Me.Close()
            frm_pagAtletica.Show()
            frm_dgvTreinos.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar/atualizar treino: " & ex.Message)
        End Try
    End Sub


    Private Sub CamposAlterados(sender As Object, e As EventArgs) Handles dtp_dataTreino.ValueChanged, txt_localTreino.TextChanged, txt_descricaoTreino.TextChanged
        dadosAlterados = True
    End Sub

    Private Sub btn_sairTreino_Click(sender As Object, e As EventArgs) Handles btn_sairTreino.Click
        Me.Close()
        frm_pagAtletica.Show()
    End Sub
End Class