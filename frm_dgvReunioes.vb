Imports System.Drawing

Public Class frm_dgvReunioes
    Private Sub frm_dgvReunioes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosdgv_reunioes()
    End Sub

    Private Sub carregarDadosdgv_reunioes()
        Try
            dgv_reunioes.Rows.Clear()
            dgv_reunioes.Columns.Clear()

            dgv_reunioes.Columns.Add("nome_reuniao", "Nome da Reunião")
            dgv_reunioes.Columns.Add("data_reuniao", "Data da Reunião")
            dgv_reunioes.Columns.Add("local_reuniao", "Local da Reunião")
            dgv_reunioes.Columns.Add("descricao_reuniao", "Descrição da Reunião")
            dgv_reunioes.Columns.Add(CreateEditColumn()) ' Coluna de Editar
            dgv_reunioes.Columns.Add(CreateDeleteColumn()) ' Coluna de Excluir

            ' Consultar os dados da tabela "tb_reunioes_atletica"
            Dim query As String = "SELECT nome_reuniao, data_reuniao, local_reuniao, descricao_reuniao FROM tb_reunioes_atletica"
            mod_geral.rs = New ADODB.Recordset()
            mod_geral.rs.Open(query, mod_geral.db)

            While Not mod_geral.rs.EOF
                Dim row As New DataGridViewRow()
                row.CreateCells(dgv_reunioes)
                row.Cells(0).Value = mod_geral.rs.Fields("nome_reuniao").Value
                row.Cells(1).Value = mod_geral.rs.Fields("data_reuniao").Value
                row.Cells(2).Value = mod_geral.rs.Fields("local_reuniao").Value
                row.Cells(3).Value = mod_geral.rs.Fields("descricao_reuniao").Value
                row.Cells(4).Value = Nothing ' Coluna de Editar
                row.Cells(5).Value = Nothing ' Coluna de Excluir

                dgv_reunioes.Rows.Add(row)
                mod_geral.rs.MoveNext()
            End While
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub

    Private Function CreateEditColumn() As DataGridViewImageColumn
        Dim colEditar As New DataGridViewImageColumn()
        colEditar.HeaderText = "Editar"
        colEditar.Image = Image.FromFile("C:\Users\vitor\Desktop\FATEC\interV2\Projeto_InterV2\bin\Debug\icons\icons8-editar-30.png")
        colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom
        Return colEditar
    End Function

    Private Function CreateDeleteColumn() As DataGridViewImageColumn
        Dim colExcluir As New DataGridViewImageColumn()
        colExcluir.HeaderText = "Excluir"
        colExcluir.Image = Image.FromFile("C:\Users\vitor\Desktop\FATEC\interV2\Projeto_InterV2\bin\Debug\icons\icons8-delete-30.png")
        colExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom
        Return colExcluir
    End Function

    Private Sub dgv_reunioes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_reunioes.CellContentClick
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 Then
            ' Clicou na coluna de Editar
            Dim rowIndex As Integer = e.RowIndex
            Dim frmOrganizarReuniao As New frm_organizarReuniao()
            frmOrganizarReuniao.ShowDialog()

        ElseIf e.ColumnIndex = dgv_reunioes.Columns.Count - 1 Then
            ' Clicou na coluna de Excluir
            Dim result As DialogResult = MessageBox.Show("Deseja realmente excluir a reunião?", "Excluir Reunião", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim rowIndex As Integer = e.RowIndex

                ' Obtém o valor da coluna do nome da reunião para identificar o registro a ser excluído
                Dim nomeReuniao As String = dgv_reunioes.Rows(rowIndex).Cells(0).Value.ToString()

                ' Remove a linha do DataGridView
                dgv_reunioes.Rows.RemoveAt(rowIndex)

                ' Exclui o registro do banco de dados
                Dim query As String = $"DELETE FROM tb_reunioes_atletica WHERE nome_reuniao = '{nomeReuniao}'"
                mod_geral.db.Execute(query)

                MessageBox.Show("Reunião excluída com sucesso!", "Excluir Reunião", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgv_reunioes_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv_reunioes.DataError
        HandleDataGridViewDataError(dgv_reunioes, e)
    End Sub

    Private Sub HandleDataGridViewDataError(dataGridView As DataGridView, e As DataGridViewDataErrorEventArgs)
        If e.Exception IsNot Nothing AndAlso TypeOf e.Exception Is FormatException AndAlso e.Context = DataGridViewDataErrorContexts.Formatting AndAlso dataGridView.Columns(e.ColumnIndex).ValueType Is GetType(Image) Then
            MessageBox.Show("Erro ao converter o valor da célula para uma imagem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
        End If
        e.ThrowException = False
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub btn_dgvSairReunioes_Click(sender As Object, e As EventArgs) Handles btn_dgvSairReunioes.Click
        Me.Close()
        frm_pagAtletica.Show()
    End Sub
End Class
