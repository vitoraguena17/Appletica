Imports System.Collections.Concurrent
Imports System.Collections.Specialized
Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography.X509Certificates
Imports System.Web.UI.WebControls
Imports System.Windows
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class frm_entrar
    
    Private Sub frm_entrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            sql = "SELECT * FROM tb_cadastro_aluno WHERE email_aluno = '" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                frm_pagAluno.Show()
                Me.Hide()
            ElseIf rs.EOF = True Then
                sql = "SELECT * FROM tb_cadastro_atletica WHERE email_atletica='" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    frm_pagAtletica.Show()
                    Me.Hide()
                Else
                    btn_atletica.Focus()
                    MsgBox("CAMPOS NÃO CONFEREM", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Else
                btn_aluno.Focus()
                MsgBox("CAMPOS NÃO CONFEREM", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
        End Try

        If txt_email.Text = "" OrElse txt_senha.Text = "" Then
            MsgBox("PREENCHA TODOS OS CAMPOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_entrar.PerformClick() ' Executa o evento Click do botão "btn_entrar"
        End If
    End Sub
    Private Sub btn_aluno_Click(sender As Object, e As EventArgs) Handles btn_aluno.Click
        frm_cadastroAluno.Show()
        Me.Hide()
    End Sub

    Private Sub btn_atletica_Click(sender As Object, e As EventArgs) Handles btn_atletica.Click
        limpar_login()
        frm_cadastrarAtletica.Show()
        Me.Hide()
    End Sub

    Private Sub cb_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_visualizar.CheckedChanged
        If cb_visualizar.Checked Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub txt_email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_senha.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_senha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_entrar.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Label_esqueceu_Click(sender As Object, e As EventArgs) Handles Label_esqueceu.Click
        Try
            If txt_email.Text = "" Then
                MsgBox("Por favor, digite um e-mail.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "SELECT * FROM tb_cadastro_aluno WHERE email_aluno = '" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If Not rs.EOF Then
                    Dim senhaAluno As String = rs.Fields("senha_aluno").Value.ToString()
                    EnviarSenhaPorEmail(senhaAluno, txt_email.Text)
                Else
                    sql = "SELECT * FROM tb_cadastro_atletica WHERE email_atletica='" & txt_email.Text & "'"
                    rs = db.Execute(sql)
                    If Not rs.EOF Then
                        Dim senhaAtletica As String = rs.Fields("senha_atletica").Value.ToString()
                        EnviarSenhaPorEmail(senhaAtletica, txt_email.Text)
                    Else
                        MsgBox("Este e-mail '" & txt_email.Text & "' não consta em nosso banco de dados.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub EnviarSenhaPorEmail(ByVal senha As String, ByVal destinatario As String)
        Dim from, pass, messageBody As String
        Dim message As MailMessage = New MailMessage()
        Dim toUser As String = destinatario
        from = "naoresponda40@gmail.com"
        pass = "uvhhfrvveusoxfvn"
        messageBody = "Sua senha é: " + senha
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "APPLETICA - Senha"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("Verifique seu e-mail para obter a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label_esqueceu_MouseEnter(sender As Object, e As EventArgs) Handles Label_esqueceu.MouseEnter
        Label_esqueceu.ForeColor = Color.FromArgb(3, 71, 196) ' Define a cor azul com o código RGB 3, 71, 196
        Label_esqueceu.Font = New Font(Label_esqueceu.Font, FontStyle.Bold) ' Aplica o estilo de fonte negrito
    End Sub

    Private Sub Label_esqueceu_MouseLeave(sender As Object, e As EventArgs) Handles Label_esqueceu.MouseLeave
        Label_esqueceu.ForeColor = DefaultForeColor ' Restaura a cor padrão do texto
        Label_esqueceu.Font = New Font(Label_esqueceu.Font, FontStyle.Regular) ' Remove o estilo de fonte negrito
    End Sub
End Class


