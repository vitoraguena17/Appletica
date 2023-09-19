Public Class frm_organizarReuniao
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        frm_pagAtletica.Show()
    End Sub
    Private nomeReuniaoOriginal As String ' Variável para armazenar o nome original da reunião
    Private dadosAlteradosReuniao As Boolean = False ' Variável para verificar se os dados foram alterados

    Private Sub txt_nomeReuniao_TextChanged(sender As Object, e As EventArgs) Handles txt_nomeReuniao.TextChanged
        ' Verificar se o campo "txt_nomeReuniao" não está vazio
        If Not String.IsNullOrEmpty(txt_nomeReuniao.Text) Then
            Dim nomeReuniao As String = txt_nomeReuniao.Text

            Try
                ' Buscar dados correspondentes no banco de dados
                Dim query As String = "SELECT * FROM tb_reunioes_atletica WHERE nome_reuniao = ?"
                Dim command As New ADODB.Command()
                command.ActiveConnection = mod_geral.db
                command.CommandText = query

                ' Define o parâmetro usando o método CreateParameter
                command.Parameters.Append(command.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeReuniao))

                Dim rs As ADODB.Recordset = command.Execute()

                If Not rs.EOF Then
                    ' Preencher os campos com os dados correspondentes
                    dtp_dataReuniao.Value = CType(rs.Fields("data_reuniao").Value, DateTime)
                    txt_localReuniao.Text = rs.Fields("local_reuniao").Value.ToString()
                    txt_descricaoReuniao.Text = rs.Fields("descricao_reuniao").Value.ToString()

                    ' Armazenar o nome original da reunião
                    nomeReuniaoOriginal = nomeReuniao
                End If

                rs.Close()
            Catch ex As Exception
                MessageBox.Show("Erro ao buscar dados da reunião: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_criarReuniao_Click(sender As Object, e As EventArgs) Handles btn_criarReuniao.Click
        Dim nomeReuniao As String = txt_nomeReuniao.Text
        Dim dataReuniao As DateTime = dtp_dataReuniao.Value.Date
        Dim localReuniao As String = txt_localReuniao.Text
        Dim descricaoReuniao As String = txt_descricaoReuniao.Text

        Try
            ' Verificar se a reunião já existe no banco de dados
            Dim selectQuery As String = "SELECT COUNT(*) FROM tb_reunioes_atletica WHERE nome_reuniao = ?"
            Dim selectCommand As New ADODB.Command()
            selectCommand.ActiveConnection = mod_geral.db
            selectCommand.CommandText = selectQuery
            selectCommand.Parameters.Append(selectCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeReuniao))
            Dim count As Integer = CInt(selectCommand.Execute().Fields(0).Value)

            If count = 0 Then
                ' A reunião não existe, efetuar o cadastro
                Dim insertQuery As String = "INSERT INTO tb_reunioes_atletica (nome_reuniao, data_reuniao, local_reuniao, descricao_reuniao) VALUES (?, ?, ?, ?)"
                Dim insertCommand As New ADODB.Command()
                insertCommand.ActiveConnection = mod_geral.db
                insertCommand.CommandText = insertQuery
                insertCommand.Parameters.Append(insertCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeReuniao))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("data", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , dataReuniao))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("local", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, localReuniao))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("descricao", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 1000, descricaoReuniao))
                insertCommand.Execute()

                MessageBox.Show("Reunião cadastrada com sucesso!")
            Else
                ' A reunião já existe, atualizar os campos correspondentes
                Dim updateQuery As String = "UPDATE tb_reunioes_atletica SET data_reuniao = ?, local_reuniao = ?, descricao_reuniao = ? WHERE nome_reuniao = ?"
                Dim updateCommand As New ADODB.Command()
                updateCommand.ActiveConnection = mod_geral.db
                updateCommand.CommandText = updateQuery
                updateCommand.Parameters.Append(updateCommand.CreateParameter("data", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , dataReuniao))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("local", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, localReuniao))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("descricao", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 1000, descricaoReuniao))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeReuniao))
                updateCommand.Execute()

                MessageBox.Show("Reunião atualizada com sucesso!")
            End If

            Me.Close()
            frm_pagAtletica.Show()
            frm_dgvReunioes.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar/atualizar reunião: " & ex.Message)
        End Try
    End Sub



    Private Sub CamposAlteradosReuniao(sender As Object, e As EventArgs) Handles dtp_dataReuniao.ValueChanged, txt_localReuniao.TextChanged, txt_descricaoReuniao.TextChanged
        dadosAlteradosReuniao = True
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private Sub btn_sairReuniao_Click(sender As Object, e As EventArgs) Handles btn_sairReuniao.Click
        Me.Close()
        frm_pagAtletica.Show()
    End Sub
End Class