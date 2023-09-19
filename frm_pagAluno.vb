Public Class frm_pagAluno
    Private Sub btn_sairAluno_Click(sender As Object, e As EventArgs) Handles btn_sairAluno.Click
        Me.Close()
        frm_entrar.Show()
    End Sub
    Private Sub carregarDadosdgv_eventos()
        Try
            ' Consultar os dados da tabela "tb_eventos_atletica"
            Dim query As String = "SELECT * FROM tb_eventos_atletica"
            mod_geral.rs = New ADODB.Recordset()
            mod_geral.rs.Open(query, mod_geral.db)

            ' Preencher o DataGridView
            dgv_eventosAlunos.Rows.Clear()
            dgv_eventosAlunos.ColumnCount = mod_geral.rs.Fields.Count
            Dim row As Object() = New Object(mod_geral.rs.Fields.Count - 1) {}

            While Not mod_geral.rs.EOF
                For i As Integer = 0 To mod_geral.rs.Fields.Count - 1
                    row(i) = mod_geral.rs.Fields(i).Value
                Next

                dgv_eventosAlunos.Rows.Add(row)
                mod_geral.rs.MoveNext()
            End While
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub
    Private Sub frm_eventoalunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarDadosdgv_eventos()
        carregarDadosdgv_treinos()

    End Sub
    Private Sub carregarDadosdgv_treinos()
        Try
            ' Consultar os dados da tabela "tb_eventos_atletica"
            Dim query As String = "SELECT * FROM tb_treinos_atletica"
            mod_geral.rs = New ADODB.Recordset()
            mod_geral.rs.Open(query, mod_geral.db)

            ' Preencher o DataGridView
            dgv_treinosAlunos.Rows.Clear()
            dgv_treinosAlunos.ColumnCount = mod_geral.rs.Fields.Count
            Dim row As Object() = New Object(mod_geral.rs.Fields.Count - 1) {}

            While Not mod_geral.rs.EOF
                For i As Integer = 0 To mod_geral.rs.Fields.Count - 1
                    row(i) = mod_geral.rs.Fields(i).Value
                Next

                dgv_treinosAlunos.Rows.Add(row)
                mod_geral.rs.MoveNext()
            End While
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os dados: " & ex.Message)
        End Try
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class