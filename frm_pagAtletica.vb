Imports Microsoft.Office.Interop

Public Class frm_pagAtletica
    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click
        Guna2PictureBox1.Visible = False
        pn_gestao.Visible = True
        btn_show.Visible = True
        btn_hide.Visible = False
        pn_gestao.Width = 30
        Guna2Transition1.HideSync(pn_gestao)
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        Guna2PictureBox1.Visible = True
        pn_gestao.Visible = True
        btn_hide.Visible = True
        btn_show.Visible = False
        pn_gestao.Width = 184
        Guna2Transition1.ShowSync(pn_gestao)
    End Sub


    Private Sub frm_pagAtletica_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna2PictureBox1.Visible = False
        pn_gestao.Visible = True
        btn_hide.Visible = False
        btn_show.Visible = True
        pn_gestao.Width = 30
    End Sub

    Private Sub btn_sairGestao_Click(sender As Object, e As EventArgs) Handles btn_sairGestao.Click
        Me.Hide()
        frm_entrar.Show()
    End Sub

    Private Sub btn_organizarEvento_Click(sender As Object, e As EventArgs) Handles btn_organizarEvento.Click
        Me.Hide()
        frm_organizarEvento.Show()
    End Sub

    Private Sub btn_reuniao_Click(sender As Object, e As EventArgs) Handles btn_reuniao.Click
        Me.Hide()
        frm_organizarReuniao.Show()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs) Handles btn_financeiro.Click
        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook
        Dim excelWorksheet As Excel.Worksheet

        ' Abre a planilha existente
        excelWorkbook = excelApp.Workbooks.Open("C:\Users\vitor\Desktop\FATEC\interV2\Projeto_InterV2\bin\Debug\excel\planilha_financ")

        excelWorksheet = excelWorkbook.Sheets(1)

        ' Exibe o aplicativo do Excel
        excelApp.Visible = True

        ' Ativa a planilha
        excelWorksheet.Activate()

        excelWorksheet = Nothing
        excelWorkbook = Nothing
        excelApp = Nothing
    End Sub

    Private Sub btn_vendas_Click(sender As Object, e As EventArgs) Handles btn_vendas.Click
        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook
        Dim excelWorksheet As Excel.Worksheet

        excelWorkbook = excelApp.Workbooks.Open("C:\Users\vitor\Desktop\FATEC\interV2\Projeto_InterV2\bin\Debug\excel\planilha_vendas")


        excelWorksheet = excelWorkbook.Sheets(1)

        ' Exibe o aplicativo do Excel
        excelApp.Visible = True

        ' Ativa a planilha
        excelWorksheet.Activate()

        excelWorksheet = Nothing
        excelWorkbook = Nothing
        excelApp = Nothing
    End Sub

    Private Sub btn_pnEventos_Click(sender As Object, e As EventArgs) Handles btn_pnEventos.Click
        Me.Hide()
        frm_dgvEventos.Show()
    End Sub

    Private Sub btn_pnReunioes_Click(sender As Object, e As EventArgs) Handles btn_pnReunioes.Click
        Me.Hide()
        frm_dgvReunioes.Show()
    End Sub

    Private Sub btn_pnTreinos_Click(sender As Object, e As EventArgs) Handles btn_pnTreinos.Click
        Me.Hide()
        frm_dgvTreinos.Show()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub btn_organizarTreino_Click(sender As Object, e As EventArgs) Handles btn_organizarTreino.Click
        frm_organizarTreino.Show()
        Me.Hide()
    End Sub
End Class