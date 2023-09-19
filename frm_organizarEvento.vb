Imports System.Drawing.Text

Public Class frm_organizarEvento

    Private nomeEventoOriginal As String
    Private dadosAlternados As Boolean = False
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private Sub btn_sairAluno_Click(sender As Object, e As EventArgs) Handles btn_sairAluno.Click
        Me.Close()
        frm_pagAtletica.Show()
    End Sub
    Private Sub btn_proximoEvento_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub CamposAlterados(sender As Object, e As EventArgs) Handles dtp_dataEvento.ValueChanged, txt_localEvento.TextChanged, txt_descricaoEvento.TextChanged
        dadosAlternados = True
    End Sub

    Private Sub txt_nomeEvento_TextChanged(sender As Object, e As EventArgs) Handles txt_nomeEvento.TextChanged
        If Not String.IsNullOrEmpty(txt_nomeEvento.Text) Then
            Dim nomeEvento As String = txt_nomeEvento.Text
            Try
                Dim query As String = "SELECT * FROM tb_eventos_atletica WHERE nome_evento = ?"
                Dim command As New ADODB.Command()
                command.ActiveConnection = mod_geral.db
                command.CommandText = query
                command.Parameters.Append(command.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeEvento))

                Dim rs As ADODB.Recordset = command.Execute()

                If Not rs.EOF Then
                    ' Preencher os campos com os dados correspondentes
                    dtp_dataEvento.Value = CType(rs.Fields("data_evento").Value, DateTime)
                    txt_localEvento.Text = rs.Fields("local_evento").Value.ToString()
                    txt_descricaoEvento.Text = rs.Fields("descricao_evento").Value.ToString()

                    ' Armazenar o nome original do treino
                    nomeEventoOriginal = nomeEvento
                End If
                rs.Close()
            Catch ex As Exception
                MessageBox.Show("Erro ao buscar dados do treino: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_criarEvento_Click_1(sender As Object, e As EventArgs) Handles btn_criarEvento.Click
        Dim nomeEvento As String = txt_nomeEvento.Text
        Dim dataEvento As DateTime = dtp_dataEvento.Value.Date
        Dim localEvento As String = txt_localEvento.Text
        Dim descricaoEvento As String = txt_descricaoEvento.Text

        Try
            ' Verificar se o evento já existe no banco de dados
            Dim selectQuery As String = "SELECT COUNT(*) FROM tb_eventos_atletica WHERE nome_evento = ?"
            Dim selectCommand As New ADODB.Command()
            selectCommand.ActiveConnection = mod_geral.db
            selectCommand.CommandText = selectQuery
            selectCommand.Parameters.Append(selectCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeEvento))
            Dim count As Integer = CInt(selectCommand.Execute().Fields(0).Value)

            If count = 0 Then
                ' O evento não existe, efetuar o cadastro
                Dim insertQuery As String = "INSERT INTO tb_eventos_atletica (nome_evento, data_evento, local_evento, descricao_evento) VALUES (?, ?, ?, ?)"
                Dim insertCommand As New ADODB.Command()
                insertCommand.ActiveConnection = mod_geral.db
                insertCommand.CommandText = insertQuery
                insertCommand.Parameters.Append(insertCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeEvento))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("data", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , dataEvento))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("local", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, localEvento))
                insertCommand.Parameters.Append(insertCommand.CreateParameter("descricao", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 1000, descricaoEvento))
                insertCommand.Execute()

                MessageBox.Show("Evento cadastrado com sucesso!")
            Else
                ' O evento já existe, buscar e preencher os campos com os dados correspondentes
                Dim updateQuery As String = "UPDATE tb_eventos_atletica SET data_evento = ?, local_evento = ?, descricao_evento = ? WHERE nome_evento = ?"
                Dim updateCommand As New ADODB.Command()
                updateCommand.ActiveConnection = mod_geral.db
                updateCommand.CommandText = updateQuery
                updateCommand.Parameters.Append(updateCommand.CreateParameter("data", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , dataEvento))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("local", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, localEvento))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("descricao", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 1000, descricaoEvento))
                updateCommand.Parameters.Append(updateCommand.CreateParameter("nome", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, nomeEvento))
                updateCommand.Execute()

                MessageBox.Show("Evento atualizado com sucesso!")
            End If

            Me.Close()
            frm_pagAtletica.Show()
            frm_dgvEventos.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar/atualizar evento: " & ex.Message)
        End Try
    End Sub

    Private Sub frm_organizarEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class