Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports System.Data

Public Class frm_cadastroAluno
    Private Sub btn_cadastrar_aluno_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_aluno.Click
        Dim email As String = txt_email_aluno.Text

        If txt_email_aluno.Text = "" OrElse txt_nome_aluno.Text = "" OrElse txt_senha_aluno.Text = "" OrElse txt_confirmarSenha_aluno.Text = "" Then
            MsgBox("PREENCHA TODOS OS CAMPOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cadastro_aluno()
        ElseIf txt_senha_aluno.Text <> txt_confirmarSenha_aluno.Text Then
            MsgBox("Senhas não conferem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_senha_aluno.Text.Length < 4 Then
            MsgBox("A senha deve ter pelo menos 4 caracteres!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf Not ValidarEmail(email) Then
            MsgBox("Email inválido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                sql = "SELECT * FROM tb_cadastro_aluno WHERE email_aluno = '" & txt_email_aluno.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("EMAIL JÁ CADASTRADO PARA ALUNO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "SELECT * FROM tb_cadastro_atletica WHERE email_atletica = '" & frm_cadastrarAtletica.txt_email_atletica.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        MsgBox("EMAIL JÁ CADASTRADO PARA ATLETICA!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                    Else
                        sql = "INSERT INTO tb_cadastro_aluno VALUES ('" & txt_nome_aluno.Text & "', '" & txt_email_aluno.Text & "', '" & txt_senha_aluno.Text & "')"
                        db.Execute(UCase(sql))
                        MsgBox("DADOS GRAVADOS COM SUCESSO!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        frm_entrar.Show()
                        Me.Hide()
                    End If
                End If
            Catch ex As Exception
                MsgBox("ERRO AO GRAVAR!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_aluno()
            End Try
        End If
    End Sub
    Private Function ValidarEmail(email As String) As Boolean
        Dim partesEmail() As String = email.Split("@"c)

        If partesEmail.Length = 2 AndAlso partesEmail(0).Length > 0 AndAlso partesEmail(1).Contains(".") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub txt_nome_aluno_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome_aluno.DoubleClick
        limpar_cadastro_aluno()
    End Sub

    Private Sub btn_loginAluno_Click(sender As Object, e As EventArgs) Handles btn_loginAluno.Click
        Me.Hide()
        frm_entrar.Show()
    End Sub

    Private Sub cb_visualizar_aluno_CheckedChanged(sender As Object, e As EventArgs) Handles cb_visualizar_aluno.CheckedChanged
        If cb_visualizar_aluno.Checked Then
            txt_confirmarSenha_aluno.PasswordChar = ""
            txt_senha_aluno.PasswordChar = ""
        Else
            txt_confirmarSenha_aluno.PasswordChar = "•"
            txt_senha_aluno.PasswordChar = "•"
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private Sub txt_nome_aluno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nome_aluno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_email_aluno.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_email_aluno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_email_aluno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_senha_aluno.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txt_senha_aluno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_senha_aluno.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_confirmarSenha_aluno.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txt_confirmarSenha_aluno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_confirmarSenha_aluno.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_cadastrar_aluno.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_cadastrar_aluno.PerformClick() ' Executa o evento Click do botão "btn_entrar"
        End If
    End Sub
    Private Sub frm_pagAtletica_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarItensComboBox(cmb_selectAtletica, "tb_cadastro_atletica", "nome_atletica")
    End Sub
End Class
