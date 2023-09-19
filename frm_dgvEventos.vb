Public Class frm_dgvEventos
    Private Sub frm_dgvEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosdgv_eventos()
    End Sub

    Private Sub carregarDadosdgv_eventos()
        Try
            dgv_eventosGestao.Rows.Clear()
            dgv_eventosGestao.Columns.Clear()

            dgv_eventosGestao.Columns.Add("nome_evento", "Nome do Evento")
            dgv_eventosGestao.Columns.Add("data_evento", "Data do Evento")
            dgv_eventosGestao.Columns.Add("local_evento", "Local do Evento")
            dgv_eventosGestao.Columns.Add("descricao_evento", "Descrição do Evento")
            dgv_eventosGestao.Columns.Add(CreateEditColumn()) ' Coluna de Editar
            dgv_eventosGestao.Columns.Add(CreateDeleteColumn()) ' Coluna de Excluir

            ' Consultar os dados da tabela "tb_eventos_atletica"
            Dim query As String = "SELECT nome_evento, data_evento, local_evento, descricao_evento FROM tb_eventos_atletica"
            mod_geral.rs = New ADODB.Recordset()
            mod_geral.rs.Open(query, mod_geral.db)

            While Not mod_geral.rs.EOF
                Dim row As New DataGridViewRow()
                row.CreateCells(dgv_eventosGestao)
                row.Cells(0).Value = mod_geral.rs.Fields("nome_evento").Value
                row.Cells(1).Value = CType(mod_geral.rs.Fields("data_evento").Value, DateTime)
                row.Cells(2).Value = mod_geral.rs.Fields("local_evento").Value
                row.Cells(3).Value = mod_geral.rs.Fields("descricao_evento").Value
                row.Cells(4).Value = Nothing ' Coluna de Editar
                row.Cells(5).Value = Nothing ' Coluna de Excluir

                dgv_eventosGestao.Rows.Add(row)
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

    Private Sub dgv_eventosGestao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eventosGestao.CellContentClick
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 Then
            ' Clicou na coluna de Editar
            Dim rowIndex As Integer = e.RowIndex
            Dim frmOrganizarTreino As New frm_organizarTreino()
            frm_organizarEvento.ShowDialog()
        ElseIf e.ColumnIndex = dgv_eventosGestao.Columns.Count - 1 Then
            ' Clicou na coluna de Excluir
            Dim result As DialogResult = MessageBox.Show("Deseja realmente excluir o evento?", "Excluir Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim rowIndex As Integer = e.RowIndex

                ' Obtém o valor da coluna do nome do evento para identificar o registro a ser excluído
                Dim nomeEvento As String = dgv_eventosGestao.Rows(rowIndex).Cells(0).Value.ToString()

                ' Remove a linha do DataGridView
                dgv_eventosGestao.Rows.RemoveAt(rowIndex)

                ' Exclui o registro do banco de dados
                Dim query As String = $"DELETE FROM tb_eventos_atletica WHERE nome_evento = '{nomeEvento}'"
                mod_geral.db.Execute(query)

                MessageBox.Show("Evento excluído com sucesso!", "Excluir Evento", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_dgvSairEventos_Click(sender As Object, e As EventArgs) Handles btn_dgvSairEventos.Click
        Me.Close()
        frm_pagAtletica.Show()
    End Sub

    Private Sub dgv_eventosGestao_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv_eventosGestao.DataError
        HandleDataGridViewDataError(dgv_eventosGestao, e)
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
End Class
