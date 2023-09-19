Public Class frm_cadastrarAtletica
    Private Sub btn_cadastrar_atletica_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_atletica.Click
        Dim email As String = txt_email_atletica.Text
        Dim senha As String = txt_senha_atletica.Text

        If txt_email_atletica.Text = "" OrElse txt_nome_atletica.Text = "" OrElse txt_senha_atletica.Text = "" OrElse txt_confirmarSenha_atletica.Text = "" Then
            MsgBox("PREENCHA TODOS OS CAMPOS", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cadastro_atletica()
        ElseIf txt_senha_atletica.Text <> txt_confirmarSenha_atletica.Text Then
            MsgBox("Senhas não conferem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf senha.Length < 4 Then
            MsgBox("A senha deve ter pelo menos 4 caracteres!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf Not ValidarEmail(email) Then
            MsgBox("Email inválido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        Else
            Try
                ' Verificar se o email já está cadastrado na tabela de atleticas
                sql = "SELECT * FROM tb_cadastro_atletica WHERE email_atletica = '" & txt_email_atletica.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("EMAIL JÁ CADASTRADO PARA ATLETICA!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    sql = "SELECT * FROM tb_cadastro_aluno WHERE email_aluno = '" & frm_cadastroAluno.txt_email_aluno.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        MsgBox("EMAIL JÁ CADASTRADO PARA ALUNO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        ' Continuar com a lógica de cadastro
                    Else
                        sql = "INSERT INTO tb_cadastro_atletica VALUES ('" & txt_nome_atletica.Text & "'," &
                                                          "'" & txt_email_atletica.Text & "'," &
                                                          "'" & txt_senha_atletica.Text & "', " &
                                                          "'" & cmb_instituicao.Text & "')"
                        db.Execute(UCase(sql))
                        MsgBox("DADOS GRAVADOS COM SUCESSO!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        frm_entrar.Show()
                        Me.Hide()
                    End If
                End If
            Catch ex As Exception
                MsgBox("ERRO AO GRAVAR", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro_atletica()
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
    Private Sub txt_nome_atletica_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome_atletica.DoubleClick
        limpar_cadastro_atletica()
    End Sub

    Private Sub btn_loginAtletica_Click(sender As Object, e As EventArgs) Handles btn_loginAtletica.Click
        Me.Hide()
        frm_entrar.Show()
    End Sub

    Private Sub cb_visualizar_atletica_CheckedChanged(sender As Object, e As EventArgs) Handles cb_visualizar_atletica.CheckedChanged
        If cb_visualizar_atletica.Checked Then
            txt_confirmarSenha_atletica.PasswordChar = ""
            txt_senha_atletica.PasswordChar = ""
        Else
            txt_confirmarSenha_atletica.PasswordChar = "•"
            txt_senha_atletica.PasswordChar = "•"
        End If
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
    Private Sub txt_nome_atletica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nome_atletica.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_email_atletica.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txt_email_atletica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_email_atletica.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_senha_atletica.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txt_senha_atletica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_senha_atletica.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_confirmarSenha_atletica.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txt_confirmarSenha_atletica_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_confirmarSenha_atletica.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_instituicao.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub cmb_instituicao_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_instituicao.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_cadastrar_atletica.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_cadastrar_atletica.PerformClick() ' Executa o evento Click do botão "btn_entrar"
        End If
    End Sub
End Class
